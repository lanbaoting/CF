using Bll.Service;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
 

namespace JW.Controllers
{
    public class AzGameController : BaseController
    {

        public IActionResult Index()
        {

            Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(8);
            ViewBag.Navigation2List = navigation2List;

            //导航
            var navigation2 = navigation2List.FirstOrDefault(w => Request.Path.ToString().Contains(w.LinkAddress));
            if (navigation2 == null)
            {
                navigation2 = navigation2List.FirstOrDefault();
            }

            ViewBag.Navigation2 = navigation2;



            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;


            //获取全部单机游戏分类
            Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            var gameClassList = azGameClassService.GetAzGameClassList();
            ViewBag.GameClassList = gameClassList;


            //全部安卓游戏推荐
            Jw_AzGameRecommendService azGameRecommendService = new Jw_AzGameRecommendService();
            var azGameRecommendList = azGameRecommendService.GetAzGameRecommendList(null, 20);
            ViewBag.AzGameRecommendList = azGameRecommendList;



            //获取 安卓 游戏
            Jw_AzGameService azGameService = new Jw_AzGameService();
            ViewBag.AzGameList = azGameService.GetGameSortCreateDateList(20);

            return View();
        }

       
    }
}
