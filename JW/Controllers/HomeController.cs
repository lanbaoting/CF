using Bll.Service;
using Entity;
using JW.Models;
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

            //二级导航

            Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            string url = GetPathBasePathUri(Request);
            var navigation1 = navigation1List.Find(w => w.LinkAddress == url);
            ViewBag.Navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(navigation1.Id);

            // 快速搜索 暂时不做搜索

            //游戏类型
            Jw_DjGameTypeService djGameTypeService = new Jw_DjGameTypeService();
            ViewBag.GameTypeList = djGameTypeService.GetDjGameTypeList();

            //游戏类型的推荐游戏
            Jw_DjGameTypeGameService djGameTypeGameService = new Jw_DjGameTypeGameService();
            ViewBag.jGameTypeGameList = djGameTypeGameService.GetDjGameTypeGameList();

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
 
            return View();
        }

       
    }
}
