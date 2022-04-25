using Bll.Service;
using Entity;
using Entity.Models;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace JW.Controllers
{
    public class ChangFangController : BaseController
    {

        public IActionResult ChuShou()
        {
            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(2);
            ViewBag.NavigationList = navigationList;
            string url = HttpContext.Request.Path.ToString().ToLower();
           ViewBag.Path = url;

            int pageNumber;
            //  string gameClassCode = GetRouteName(Request.Path, 1);

            // 区域
            Cf_AreaService areaService = new Cf_AreaService();
            var areaList = areaService.GetAreaList(2);
            ViewBag.AreaList = areaList;

            //var areaList = areaService.GetAreaList(2);
            //ViewBag.AreaList = areaList;

            //条件
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
            var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(2,2);
            ViewBag.CitySiteRangeSearchList = citySiteRangeSearchList;

            var urlPramArr = new List<int>();

            var urlDicPramArr = new List<int>();

            pageNumber = 1;
            int districtId = 0;
            if (url.Contains(".html"))
            {
                string urlPrams = url.Split('/').Last().Replace(".html", "");
                urlPramArr = urlPrams.Split('_').Select(s=>int.Parse(s)).ToList();
                districtId = urlPramArr[0];
                pageNumber = urlPramArr.Last();
                urlDicPramArr = urlPramArr.Take(urlPramArr.Count - 2).ToList(); 
            }

            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            var urlDicPramList  =  factoryHouseDictionaryService.GetFactoryHouseDictionaryListByIds(urlDicPramArr);
            ViewBag.UrlPramArr = urlPramArr;
     
          
          
            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var houseData = factoryHouseService.GetPageFactoryHouse(101,2, urlDicPramList);
            var m = houseData.ToPagedList(pageNumber, 20);


            //厂房出租信息
            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, 143);
            ViewBag.FactoryHouseChuZuList = factoryHouseChuZuList;


            return View(m);

          


        }

        public IActionResult ChuZu()
        {

            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(2);
            ViewBag.NavigationList = navigationList;
            string url = HttpContext.Request.Path.ToString().ToLower();
            ViewBag.Path = url;

            int pageNumber;
        

            // 区域
            Cf_AreaService areaService = new Cf_AreaService();
            var areaList = areaService.GetAreaList(2);
            ViewBag.AreaList = areaList;



            //条件
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
            var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(2, 2);
            ViewBag.CitySiteRangeSearchList = citySiteRangeSearchList;





            var urlPramArr = new List<int>();

            var urlDicPramArr = new List<int>();

            pageNumber = 1;
            int districtId = 0;
            if (url.Contains(".html"))
            {
                string urlPrams = url.Split('/').Last().Replace(".html", "");
                urlPramArr = urlPrams.Split('_').Select(s => int.Parse(s)).ToList();
                districtId = urlPramArr[0];
                pageNumber = urlPramArr.Last();
                urlDicPramArr = urlPramArr.Take(urlPramArr.Count - 2).ToList();
            }

            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            var urlDicPramList = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByIds(urlDicPramArr);


            ViewBag.UrlPramArr = urlPramArr;






            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var houseData = factoryHouseService.GetPageFactoryHouse(143,2, urlDicPramList);

            var m = houseData.ToPagedList(pageNumber, 20);


            var factoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(10, 101);
            ViewBag.FactoryHouseChuShouList = factoryHouseChuShouList;

            return View(m);




        }
    }
}
