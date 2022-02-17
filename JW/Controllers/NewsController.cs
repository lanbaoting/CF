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


            var ps = Request.Path.ToString().Split("/");

            int pageNumber = 1;

            if (ps.Length>3)
            {                           
                          
                if (!int.TryParse(ps[2], out pageNumber))
                {
                    return PageNotFound();
                }                
            }

            //一级导航
            Jw_Navigation1Service navigation1Service = new Jw_Navigation1Service();
            var navigation1List = navigation1Service.GetNavigation1List();
            ViewBag.Navigation1List = navigation1List;

            var navigation1 = navigation1List.FirstOrDefault(w => w.Id == 5);
            ViewBag.Navigation1 = navigation1;


            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;

            //获取全部的文章分页列表
            Jw_ArticleService articleService = new Jw_ArticleService();
            var articleData = articleService.GetPageArticleList();
            var m1 = articleData.ToPagedList(pageNumber,20);

            //热点图文
            Jw_HotGraphicsService hotGraphicsService = new Jw_HotGraphicsService();
            ViewBag.HotGraphicsList = hotGraphicsService.GeHotGraphicsList();

            //热门大作
            Jw_AzGameMainPushService azGameMainPushService = new Jw_AzGameMainPushService();
            ViewBag.AzGameMainPushList = azGameMainPushService.GetAzGameMainPushList();



            return View(m1);

          
        }

       
    }
}
