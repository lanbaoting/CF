using Bll.Service;
using Entity;
using JW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
 

namespace JW.Controllers
{
    public class GameDetailsController : BaseController
    {

        public IActionResult Index()
        {

            string paramStr = GetParams(Request.Path);
            int gameId;
            if (!int.TryParse(paramStr, out gameId))
            {
                return PageNotFound();
            }
            //获取游戏基础信息
            Jw_DjGameService djGameService = new Jw_DjGameService();
            var djGame = djGameService.GetDjGameById(gameId);           
            if (djGame == null)
            {
                return PageNotFound();
            }
            ViewBag.DjGame = djGame;



           //获取游戏详细信息
           Jw_DjGameDetailsService djGameDetailsService = new Jw_DjGameDetailsService();
            var djGameDetails = djGameDetailsService.GetDjGameDetailsById(gameId);
            if (djGameDetails == null)
            {
                return PageNotFound();
            }
            ViewBag.DjGameDetails = djGameDetails;



            //一级导航
            Jw_Navigation1Service navigation1Service = new Jw_Navigation1Service();
            var navigation1List = navigation1Service.GetNavigation1List();
            ViewBag.Navigation1List = navigation1List;

   
            //获取全部单机游戏分类
            Jw_DjGameClassService djGameClassService = new Jw_DjGameClassService();
            var gameClassList = djGameClassService.GetDjGameClassList();
            ViewBag.GameClassList = gameClassList;

            // 获取同类游戏的推荐游戏
            Jw_DjGameRecommendService djGameRecommendService =  new Jw_DjGameRecommendService();
            ViewBag.GameRecommendList = djGameRecommendService.GetDjGameRecommendListByClassId(djGame.DjGameClassId);

            // 获取同类游戏的游戏排行
            Jw_DjGameRankingService djGameRankingService = new Jw_DjGameRankingService();
            ViewBag.GameRankingList = djGameRankingService.Get_DjGameRankingListByClassId(djGame.DjGameClassId);

            // 获取同类游戏的游戏排行
            Jw_DjGamePicturesService djGamePicturesService = new Jw_DjGamePicturesService();
            ViewBag.GamePictureList = djGamePicturesService.GetDjGamePictureList(djGame.Id);

            
            Jw_DjGameArticleService djGameArticleService = new Jw_DjGameArticleService();
            // 游戏攻略 
            ViewBag.GameArticleList1 = djGameArticleService.GetDjGameArticleList(djGame.Id, 1, 10);
            //  游戏新闻
            ViewBag.GameArticleList2 = djGameArticleService.GetDjGameArticleList(djGame.Id, 2, 10);


            return View();
        }

       
    }
}
