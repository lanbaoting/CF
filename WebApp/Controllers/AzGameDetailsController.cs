using Bll.Service;
using Entity;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
 

namespace JW.Controllers
{
    public class AzGameDetailsController : BaseController
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
            Jw_AzGameService azGameService = new Jw_AzGameService();
            var azGame = azGameService.GetAzGameById(gameId);           
            if (azGame == null)
            {
                return PageNotFound();
            }
            ViewBag.AzGame = azGame;



            //获取游戏详细信息
            Jw_AzGameDetailsService azGameDetailsService = new Jw_AzGameDetailsService();
            var azGameDetails = azGameDetailsService.GetAzGameDetailsById(gameId);
            if (azGameDetails == null)
            {
                return PageNotFound();
            }
            ViewBag.AzGameDetails = azGameDetails;


           
            Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            var gameClass = azGameClassService.GetAzGameClassModelById(azGame.AzGameClassId);
            ViewBag.GameClass = gameClass;




            //获取安卓游戏分类
            var gameClassList = azGameClassService.GetAzGameClassList();
            ViewBag.GameClassList = gameClassList;

            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;

            //图片
            Jw_AzGamePicturesService azGamePicturesService = new Jw_AzGamePicturesService();
            ViewBag.GamePictureList = azGamePicturesService.GetAzGamePictureList(gameId);

            //视屏
            Jw_AzGameVideoService azGameVideoService = new Jw_AzGameVideoService();
            ViewBag.GameVideoList = azGameVideoService.GetAzGameVideoList(gameId);

            Jw_AzGameArticleService azGameArticleService = new Jw_AzGameArticleService();
            List<AzGroupArticleTypeArticle> azGroupArticleTypeArticleList = azGameArticleService.GetAzGroupArticleTypeArticleList(azGame.Id);
            ViewBag.AzGroupArticleTypeArticleList = azGroupArticleTypeArticleList;

            //新闻攻略
            //Jw_AzGameArticleService azGameArticleService = new Jw_AzGameArticleService();
            //ViewBag.GameArticleList = azGameArticleService.GetAzGameArticleList(gameId,10);

            ViewBag.GameList = azGameService.GetGameList(8);


            return View();
        }

       
    }
}
