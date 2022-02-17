using Bll.Service;
using Entity;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
 

namespace JW.Controllers
{
    public class AzHomeController : BaseController
    {

        public IActionResult Index()
        {
            //一级导航
            Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(8);
            ViewBag.Navigation2List = navigation2List;
  

            //轮播
            Jw_AzGameRotationService azGameRotationService = new Jw_AzGameRotationService();
            var azGameRotationList = azGameRotationService.GetAzGameRotationList();
            ViewBag.AzGameRotationList = azGameRotationList;


            //轮播右边
            Jw_AzGameRotationRightService azGameRotationRightService = new Jw_AzGameRotationRightService();
            var azGameRotationRightList = azGameRotationRightService.GetAzGameRotationRightList();
            ViewBag.AzGameRotationRightList = azGameRotationRightList;
 
            //全部安卓游戏分类
            Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            var azGameClassList = azGameClassService.GetAzGameClassList(10);           
            ViewBag.AzGameClassList = azGameClassList;


            //全部安卓游戏排行
            Jw_AzGameRankingService azGameRankingService = new Jw_AzGameRankingService();
            var azGameRankingList = azGameRankingService.GetAzGameRankingList(null,20);
            ViewBag.AzGameRankingList = azGameRankingList;


            //全部安卓游戏推荐
            Jw_AzGameRecommendService azGameRecommendService = new Jw_AzGameRecommendService();
            var azGameRecommendList = azGameRecommendService.GetAzGameRecommendList(null, 21);
            ViewBag.AzGameRecommendList = azGameRecommendList;

 
            //获取 安卓 游戏
            Jw_AzGameService azGameService = new Jw_AzGameService();      
            ViewBag.AzGameList = azGameService.GetGameSortCreateDateList(21);

            List<AzGroupGameClassGame> azGroupGameClassGameList = new List<AzGroupGameClassGame>();
            for (int i = 0; i < 6; i++) {
                if (i + 1 > azGameClassList.Count()) {
                    break;
                }
                AzGroupGameClassGame azGroupGameClassGame = new AzGroupGameClassGame()
                {
                    AzGameClassId = azGameClassList[i].Id,
                    AzGameClassName = azGameClassList[i].Name,
                    AzGameClassCode = azGameClassList[i].Code
                };
                azGroupGameClassGameList.Add(azGroupGameClassGame);
                var azGameList = azGameService.GetGameList(azGroupGameClassGame.AzGameClassId, 5);
                azGroupGameClassGame.AzGameList = azGameList;
            }
            ViewBag.AzGroupGameClassGameList = azGroupGameClassGameList;



            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;


            Jw_ArticleService articleService = new Jw_ArticleService();
 
            List<AzGroupArticleTypeArticle> azGroupArticleTypeArticleList = new List<AzGroupArticleTypeArticle>();
            for (int i = 0; i < 3; i++)
            {
                if (i + 1 > articleTypeList.Count())
                {
                    break;
                }
                AzGroupArticleTypeArticle azGroupArticleTypeArticle = new AzGroupArticleTypeArticle()
                {
                    ArticleTypeId = articleTypeList[i].Id,
                    ArticleTypeName = articleTypeList[i].Name,
                    ArticleCode = articleTypeList[i].Code
                };
                azGroupArticleTypeArticleList.Add(azGroupArticleTypeArticle);
                var azArticleList = articleService.GetArticleByAticleTypeList(azGroupArticleTypeArticle.ArticleTypeId, 5);
                azGroupArticleTypeArticle.ArticleList = azArticleList;
            }
            ViewBag.AzGroupArticleTypeArticleList = azGroupArticleTypeArticleList;


            Jw_AzGameClassLinksService azGameClassLinksService = new Jw_AzGameClassLinksService();
            var azGameClassLinksList = azGameClassLinksService.GetAzGameClassLinksList();
            ViewBag.AzGameClassLinksList = azGameClassLinksList;



            return View();
        }

       
    }
}
