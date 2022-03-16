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

            Cf_NavigationService navigationService = new Cf_NavigationService();
            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            Cf_AreaService areaService = new Cf_AreaService();
            //导航
            var navigationList = navigationService.GetNavigationList(1);
            ViewBag.NavigationList = navigationList;
            ViewBag.Path = HttpContext.Request.Path;



            //获取全部文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;

            //获取全部的文章分页列表
            Jw_ArticleService articleService = new Jw_ArticleService();
            var articleData = articleService.GetPageArticleList();
            var m1 = articleData.ToPagedList(pageNumber,20);


            //厂房出售信息
            var factoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(10, 101);
            ViewBag.FactoryHouseChuShouList = factoryHouseChuShouList;

            //厂房出租信息
            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, 143);
            ViewBag.FactoryHouseChuZuList = factoryHouseChuShouList;
 
            ViewBag.ReadingRankingArticleList = articleService.GetReadingRankingArticleList(20);





            return View(m1);

          
        }

       
    }
}
