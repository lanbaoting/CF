using Bll.Service;
using Entity;
using X.PagedList;  
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Entity.Models;
using Entity.ViewModels;
using System.Collections.Generic;

namespace JW.Controllers
{
    public class NewsDetailsController : BaseController
    {

        public IActionResult Index()
        {
            string path = Request.Path.ToString().ToLower();


           string paramStr = path.Split('/').LastOrDefault().Replace(".html", "");
             
            
            int articleId;
            if (!int.TryParse(paramStr, out articleId))
            {
                return PageNotFound();
            }
            //获取文章基础信息
            Jw_ArticleService articleService = new Jw_ArticleService();
            var article = articleService.GetDjArticleById(articleId);
            if (article == null)
            {
                return PageNotFound();
            }
            ViewBag.Article = article;





            //获取文章详细信息
            Jw_ArticleDetailsService articleDetailsService = new Jw_ArticleDetailsService();
            var artileDetails = articleDetailsService.GetDjArticleById(article.Id);
            if (artileDetails == null)
            {
                return PageNotFound();
            }
            ViewBag.ArtileDetails = artileDetails;


            //获取文章分类信息
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleType = articleTypeService.GetArticleTypeById(article.ArticleTypeId);
            if (artileDetails == null)
            {
                return PageNotFound();
            }
            ViewBag.ArticleType = articleType;


            //获取全部文章分类
 
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;


            //热点图文
            Jw_HotGraphicsService hotGraphicsService = new Jw_HotGraphicsService();
            ViewBag.HotGraphicsList = hotGraphicsService.GeHotGraphicsList();

            ////热门大作
            //Jw_DjHotWorkService djHotWorkService = new Jw_DjHotWorkService();
            //ViewBag.DjHotWorkList = djHotWorkService.GeDjHotWorkList();

            //主推
            Jw_AzGameMainPushService azGameMainPushService = new Jw_AzGameMainPushService();
            ViewBag.AzGameMainPushList = azGameMainPushService.GetAzGameMainPushList();


           
            ViewBag.LastArticle = articleService.GetLastArticleById(article.Id);
            ViewBag.NextArticle = articleService.GetNextArticleById(article.Id);




            Jw_AzGameArticleService azGameArticleService = new Jw_AzGameArticleService();
            //
            var azGameArticle = azGameArticleService.GetAzGameArticleByArticleId(article.Id);
            if (azGameArticle != null)
            {
                Jw_AzGameService azGameService = new Jw_AzGameService();
                var azGame = azGameService.GetAzGameById(azGameArticle.AzGameId);
               

                if (azGame != null) 
                {                 
                    List<AzGroupArticleTypeArticle> azGroupArticleTypeArticleList = azGameArticleService.GetAzGroupArticleTypeArticleList(azGame.Id);
                    ViewBag.AzGroupArticleTypeArticleList = azGroupArticleTypeArticleList;
                    ViewBag.AzGame = azGame;
                }

                

            }







            return View();


        }



         



       



    }
}
