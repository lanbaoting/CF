using Bll.Service;
using Entity;
using X.PagedList;  
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Entity.Models;

namespace JW.Controllers
{
    public class NewsClassListController : BaseController
    {

        public IActionResult Index()
        {
 
            int pageNumber;
         
            string path = Request.Path.ToString().ToLower();

            string[] strArr = path.Split("/");
            string typeCode = strArr[2];

            if (path.Contains(".html"))
            {

                string paramsStr = path.Split('/').LastOrDefault().Replace(".html", "");

                if (!int.TryParse(paramsStr, out pageNumber))
                {
                    return PageNotFound();
                }
            }
            else {
                pageNumber = 1;
            }
             
 
 
            //文章分类
            Jw_ArticleTypeService articleTypeService = new Jw_ArticleTypeService();
            var articleType = articleTypeService.GetArticleTypeByCode(typeCode);
            if (articleType == null)
            {
                return PageNotFound();
            }
            ViewBag.ArticleType = articleType;



            //一级导航
            Jw_Navigation1Service navigation1Service = new Jw_Navigation1Service();
            var navigation1List = navigation1Service.GetNavigation1List();
            ViewBag.Navigation1List = navigation1List;

            //获取全部文章分类          
            var articleTypeList = articleTypeService.GetArticleTypeList();
            ViewBag.ArticleTypeList = articleTypeList;

            //获取全部的文章分页列表
            Jw_ArticleService articleService =  new Jw_ArticleService();
            var articleData = articleService.GetPageArticleListByArticleTypeId(articleType.Id); 
            var  m1 = articleData.ToPagedList(pageNumber, 20);

            //热点图文
            Jw_HotGraphicsService hotGraphicsService = new Jw_HotGraphicsService();
            ViewBag.HotGraphicsList = hotGraphicsService.GeHotGraphicsList();

            //热门大作
            //Jw_DjHotWorkService djHotWorkService = new Jw_DjHotWorkService();
            //ViewBag.DjHotWorkList = djHotWorkService.GeDjHotWorkList();

            //主推
            Jw_AzGameMainPushService azGameMainPushService = new Jw_AzGameMainPushService();
            ViewBag.AzGameMainPushList = azGameMainPushService.GetAzGameMainPushList();


            return View(m1);
        }

       
    }
}
