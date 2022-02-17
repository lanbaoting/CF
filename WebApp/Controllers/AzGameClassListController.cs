using Bll.Service;
using Entity;
using X.PagedList;  
using Microsoft.AspNetCore.Mvc;
using System.Linq;
 

namespace JW.Controllers
{
    public class AzGameClassListController : BaseController
    {

        public IActionResult Index()
        {


            int pageNumber;
            string gameClassCode = GetRouteName(Request.Path, 1);



            if (Request.Path.ToString().ToLower().Contains(".html"))
            {
                string paramsStr = GetParams(Request.Path);

                if (!int.TryParse(paramsStr, out pageNumber))
                {
                    return PageNotFound();
                }
            }
            else
            {
                pageNumber = 1;
            }


            Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(8);
            ViewBag.Navigation2List = navigation2List;

   

            Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            var azGameClass = azGameClassService.GetAzGameClassByCode(gameClassCode);
            if (azGameClass == null)
            {
                return PageNotFound();
            }
            ViewBag.AzGameClass = azGameClass;

            //获取有游戏分类
            var azGameClassList = azGameClassService.GetAzGameClassList();
            ViewBag.GameClassList = azGameClassList;



            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;
 
            //游戏分页列表
            Jw_AzGameService azGameService = new Jw_AzGameService();         
           var gameData = azGameService.GetPageGameList(azGameClass.Id);

            var  m = gameData.ToPagedList(pageNumber, 20);
            
            return View(m);
        }

       
    }
}
