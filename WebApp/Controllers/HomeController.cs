using Bll.Service;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
 

namespace JW.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            //一级导航
          Jw_Navigation1Service navigation1Service = new Jw_Navigation1Service();
            var navigation1List = navigation1Service.GetNavigation1List();
            ViewBag.Navigation1List = navigation1List;

            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;

            // 快速搜索 暂时不做搜索

            ////游戏类型
            //Jw_DjGameTypeService djGameTypeService = new Jw_DjGameTypeService();
            //ViewBag.GameTypeList = djGameTypeService.GetDjGameTypeList();

            ////游戏类型的推荐游戏
            //Jw_DjGameTypeGameService djGameTypeGameService = new Jw_DjGameTypeGameService();
            //ViewBag.jGameTypeGameList = djGameTypeGameService.GetDjGameTypeGameList();

            //屏
            Jw_DjSectionService djSectionService = new Jw_DjSectionService();
            ViewBag.SectionList = djSectionService.GetDjSectionList();

            //屏左模块
            Jw_DjSectionCoreService djSectionCoreService = new Jw_DjSectionCoreService();
            ViewBag.SectionCoreList = djSectionCoreService.GetDjSectionCoreList();

            //屏左模块项目
            Jw_DjSectionCoreItemService djSectionCoreItemService = new Jw_DjSectionCoreItemService();
            ViewBag.SectionCoreItemList = djSectionCoreItemService.GetDjSectionCoreItemList();

            //屏左模块项目游戏
            Jw_DjSectionCoreItemGameService djSectionCoreItemGameService = new Jw_DjSectionCoreItemGameService();
            ViewBag.SectionCoreItemGameList = djSectionCoreItemGameService.GetDjSectionCoreItemGameList();

            //屏右模块
           Jw_DjSectionAsideService djSectionAsideService = new Jw_DjSectionAsideService();
            ViewBag.SectionAsideList = djSectionAsideService.GetDjSectionAsideList();

            //屏右模块游戏
            Jw_DjSectionAsideGameService djSectionAsideGameService = new Jw_DjSectionAsideGameService();
            ViewBag.SectionAsideGameList = djSectionAsideGameService.GetDjSectionAsideGameList();

            //获取全部单机游戏分类
            Jw_DjGameClassService djGameClassService = new Jw_DjGameClassService();
            var gameClassList = djGameClassService.GetDjGameClassList();
            ViewBag.GameClassList = gameClassList;

            //获取全部单机游戏
            Jw_DjGameService djGameService = new Jw_DjGameService();
            var gameClassIds = gameClassList.Select(s => s.Id).ToList();
            ViewBag.GameGroupByClassList = djGameService.GetDjGameGroupByClassList(gameClassIds);


            Jw_ArticleService articleService = new Jw_ArticleService();

            ViewBag.Type1ArticleList = articleService.GetArticleList(1,10);
            ViewBag.Type2ArticleList = articleService.GetArticleList(2, 10);



            return View();
        }

       
    }
}
