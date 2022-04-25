using Bll.Service;
using Entity;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace JW.Controllers
{
    public class FactoryHouseDetailsController : BaseController
    {

        public IActionResult Index()
        {

            string paramStr = GetParams(Request.Path);
            int factoryHouseId;
            if (!int.TryParse(paramStr, out factoryHouseId))
            {
                return PageNotFound();
            }
      

            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var factoryHouse = factoryHouseService.GetFactoryHouse(factoryHouseId);

            if (factoryHouse == null)
            {
                return PageNotFound();
            }
            ViewBag.FactoryHouse = factoryHouse;


             
            Cf_FactoryHouseDetailsService factoryHouseDetailsService = new Cf_FactoryHouseDetailsService();
            var factoryHouseDetials = factoryHouseDetailsService.GetFactoryHouseDetials(factoryHouseId);
            ViewBag.FactoryHouseDetials = factoryHouseDetials;
            





            Cf_FactoryHousePicturesService factoryHousePicturesService = new Cf_FactoryHousePicturesService();

            var factoryHousePicturesList =  factoryHousePicturesService.GetFactoryHousePicturesList(factoryHouse.Id);

            ViewBag.FactoryHousePicturesList = factoryHousePicturesList;


           


            //厂房出租信息
            var factoryHouseList = factoryHouseService.GetFactoryHouseList(10, factoryHouse.TransactionModeId.Value);
            ViewBag.FactoryHouseList = factoryHouseList;






            ////图片
            //Jw_AzGamePicturesService azGamePicturesService = new Jw_AzGamePicturesService();
            //ViewBag.GamePictureList = azGamePicturesService.GetAzGamePictureList(gameId);



            ////一级导航
            //Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            //var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(8);
            //ViewBag.Navigation2List = navigation2List;

            ////获取游戏详细信息
            //Jw_AzGameDetailsService azGameDetailsService = new Jw_AzGameDetailsService();
            //var azGameDetails = azGameDetailsService.GetAzGameDetailsById(gameId);
            //if (azGameDetails == null)
            //{
            //    return PageNotFound();
            //}
            //ViewBag.AzGameDetails = azGameDetails;

            //Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            //var gameClass = azGameClassService.GetAzGameClassModelById(azGame.AzGameClassId);
            //ViewBag.AzGameClass = gameClass;

            ////获取安卓游戏分类
            //var gameClassList = azGameClassService.GetAzGameClassList();
            //ViewBag.GameClassList = gameClassList;

            ////获取全部文章分类
            //Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            //var articleTypeList = articleTypeService.GetArticleTypeList();
            //ViewBag.ArticleTypeList = articleTypeList;

            ////图片
            //Jw_AzGamePicturesService azGamePicturesService = new Jw_AzGamePicturesService();
            //ViewBag.GamePictureList = azGamePicturesService.GetAzGamePictureList(gameId);

            ////视频
            //Jw_AzGameVideoService azGameVideoService = new Jw_AzGameVideoService();
            //ViewBag.GameVideoList = azGameVideoService.GetAzGameVideoList(gameId);

            ////主推
            //Jw_AzGameMainPushService azGameMainPushService = new Jw_AzGameMainPushService();
            //ViewBag.AzGameMainPushList = azGameMainPushService.GetAzGameMainPushList();

            ////全部安卓游戏排行
            //Jw_AzGameRankingService azGameRankingService = new Jw_AzGameRankingService();
            //var azGameRankingList = azGameRankingService.GetAzGameRankingList(azGame.AzGameClassId, 20);
            //ViewBag.AzGameRankingList = azGameRankingList;

            ////全部安卓游戏推荐
            //Jw_AzGameRecommendService azGameRecommendService = new Jw_AzGameRecommendService();
            //var azGameRecommendList = azGameRecommendService.GetAzGameRecommendList(azGame.AzGameClassId, 21);
            //ViewBag.AzGameRecommendList = azGameRecommendList;


            //Jw_AzGameArticleService azGameArticleService = new Jw_AzGameArticleService();
            //List<AzGroupArticleTypeArticle> azGroupArticleTypeArticleList = azGameArticleService.GetAzGroupArticleTypeArticleList(azGame.Id);        
            //ViewBag.AzGroupArticleTypeArticleList = azGroupArticleTypeArticleList;


            ////新闻攻略
            //Jw_AzGameArticleService azGameArticleService = new Jw_AzGameArticleService();
            //ViewBag.GameArticleList1 = azGameArticleService.GetAzGameArticleList(gameId,1, 10);

            //ViewBag.GameArticleList2 = azGameArticleService.GetAzGameArticleList(gameId,2, 10);


            return View();
        }


    }
}
