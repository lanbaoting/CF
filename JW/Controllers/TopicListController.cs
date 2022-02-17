using Bll.Service;
using Entity;
using X.PagedList;  
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Entity.Models;

namespace JW.Controllers
{
    public class TopicListController : BaseController
    {

        public IActionResult Index()
        {


            string path = Request.Path.ToString().ToLower();

            int pageNumber = 1;
            string[] strArr = path.Split("/");
            string typeCode = strArr[1].Substring(4);
            if (path.Contains("list"))
            {                           
             
                string paramSring = path.Replace(".html", "").Split('_')[1];             
                if (!int.TryParse(paramSring, out pageNumber))
                {
                    return PageNotFound();
                }

            }

          
            Jw_TopicTypeService topicTypeService = new Jw_TopicTypeService();
            var topicType = topicTypeService.GetTopicTypeByCode(typeCode);
            if (topicType == null)
            {
                return PageNotFound();
            }
            ViewBag.Jw_TopicType = topicType;



            //一级导航
            Jw_Navigation1Service navigation1Service = new Jw_Navigation1Service();
            var navigation1List = navigation1Service.GetNavigation1List();
            ViewBag.Navigation1List = navigation1List;

            //获取全部专题分类
            var topicTypeList = topicTypeService.GetTopicTypeList();
            ViewBag.TopicTypeList = topicTypeList;



            //获取全部的专题分页列表
            Jw_DjGameTopicsService djGameTopicsService = new Jw_DjGameTopicsService();
            var djGameTopics = djGameTopicsService.GetDjGameTopicsList();
            var m1 = djGameTopics.ToPagedList(pageNumber, 20);

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
