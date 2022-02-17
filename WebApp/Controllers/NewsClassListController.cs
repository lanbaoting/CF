using Bll.Service;
using Entity;
using X.PagedList;  
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Entity.Models;

namespace JW.Controllers
{
    public class NewsClassListController : BaseController
    {

        public IActionResult Index()
        {
 
            int pageNumber = 1;
            string typeCode = GetRouteName(Request.Path, 1);
            if (Request.Path.ToString().ToLower().Contains(".html"))
            {
                string paramsStr = GetParams(Request.Path);

                if (!int.TryParse(paramsStr, out pageNumber))
                {
                    return PageNotFound();
                }
            }


            Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(5);
            ViewBag.Navigation2List = navigation2List;


            //文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleType = articleTypeService.GetArticleTypeByCode(typeCode);
            if (articleType == null)
            {
                return PageNotFound();
            }
            ViewBag.ArticleType = articleType;



            //一级导航
            Jw_Navigation1Service navigation1Service = new Jw_Navigation1Service();
            var navigation1List = navigation1Service.GetNavigation1List();
            ViewBag.Navigation1List = navigation1List;

            //获取全部文章分类          
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;

            //获取全部单机游戏分类
            Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            var gameClassList = azGameClassService.GetAzGameClassList();
            ViewBag.GameClassList = gameClassList;


            //获取全部的文章分页列表
            Jw_ArticleService articleService =  new Jw_ArticleService();
            var articleData = articleService.GetPageArticleListByArticleTypeId(articleType.Id); 
            var  m1 = articleData.ToPagedList(pageNumber, 20);

            //热点图文
            Jw_HotGraphicsService hotGraphicsService = new Jw_HotGraphicsService();
            ViewBag.HotGraphicsList = hotGraphicsService.GeHotGraphicsList();


            //主推
            Jw_AzGameMainPushService azGameMainPushService = new Jw_AzGameMainPushService();
            ViewBag.AzGameMainPushList = azGameMainPushService.GetAzGameMainPushList();




            return View(m1);
        }

       
    }
}
