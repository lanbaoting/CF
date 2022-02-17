using Bll.Service;
using Entity;
using X.PagedList;  
using Microsoft.AspNetCore.Mvc;
using System.Linq;
 

namespace JW.Controllers
{
    public class GameClassListController : BaseController
    {

        public IActionResult Index()
        {


            int pageNumber;
            string gameClassCode = GetRouteName(Request.Path, 0);
            if (Request.Path.ToString().ToLower().Contains("list"))
            {
                string paramsStr = GetParams(Request.Path, 1);

                if (!int.TryParse(paramsStr, out pageNumber))
                {
                    return PageNotFound();
                }
            }
            else
            {
                pageNumber = 1;
            }
 
            //获取有游戏分类
            Jw_DjGameClassService djGameClassService = new Jw_DjGameClassService();
            var djGameClass = djGameClassService.GetDjGameClassByCode(gameClassCode);
            if (djGameClass == null)
            {
                return PageNotFound();
            }
            ViewBag.DjGameClass = djGameClass;
            var djGameClassList = djGameClassService.GetDjGameClassList();
            ViewBag.GameClassList = djGameClassList;



            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;


            //一级导航
            Jw_Navigation1Service navigation1Service = new Jw_Navigation1Service();
            var navigation1List = navigation1Service.GetNavigation1List();
            ViewBag.Navigation1List = navigation1List;


            if (pageNumber == 1) {

                //获取全部单机游戏分类标签
                Jw_DjGameClassTabService djGameClassTabService = new Jw_DjGameClassTabService();
                var gameClassTabList = djGameClassTabService.GetDjGameClassTabListByClassId(djGameClass.Id);
                ViewBag.GameClassTabList = gameClassTabList;

                //分类标签关联的游戏
                Jw_DjGameClassTabGameService djGameClassTabGameService = new Jw_DjGameClassTabGameService();
                ViewBag.GetDjGameClassTabGameListList = djGameClassTabGameService.GetDjGameClassTabGameList();
            }

 

            //游戏分页列表
            Jw_DjGameService djGameService = new Jw_DjGameService();
         

           var gameData = djGameService.GetPageGameList(djGameClass.Id);

            var  m = gameData.ToPagedList(pageNumber, 1);
            
            return View(m);
        }

       
    }
}
