using Bll.Service;
using Entity;
using X.PagedList;  
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Entity.Models;

namespace JW.Controllers
{
    public class NewsController : BaseController
    {

        public IActionResult Index()
        {


            
            Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(5);
            ViewBag.Navigation2List = navigation2List;

            //导航
            var navigation2 = navigation2List.FirstOrDefault(w => w.Id ==15);
            if (navigation2 == null)
            {
                navigation2 = navigation2List.FirstOrDefault();
            }

            ViewBag.Navigation2 = navigation2;

            int pageNumber = 1;
            var p = Request.Path.ToString().Split('/');
            if (p.Length>3)
            {
                
                if (!int.TryParse(p[2], out pageNumber))
                {
                    return PageNotFound();
                }
            }
            

            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;

            //获取全部单机游戏分类
            Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            var gameClassList = azGameClassService.GetAzGameClassList();
            ViewBag.GameClassList = gameClassList;



            //获取全部的文章分页列表
            Jw_ArticleService articleService = new Jw_ArticleService();
            var articleData = articleService.GetPageArticleList();
            var m1 = articleData.ToPagedList(pageNumber, 20);

            //热点图文
            Jw_HotGraphicsService hotGraphicsService = new Jw_HotGraphicsService();
            ViewBag.HotGraphicsList = hotGraphicsService.GeHotGraphicsList();

            //热门大作
            Jw_DjHotWorkService djHotWorkService = new Jw_DjHotWorkService();
            ViewBag.DjHotWorkList = djHotWorkService.GeDjHotWorkList();



            return View(m1);

          
        }

       
    }
}
