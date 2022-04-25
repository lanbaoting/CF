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
    public class TeSeChangFangController : BaseController
    {

        public IActionResult ChuShou(string url) 
        {

            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(2);
            ViewBag.NavigationList = navigationList;
          
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

 

            pageNumber = 1;
            int teseDicId = 0;
            if (url.Contains(".html"))
            {
                string urlPrams = url.Split('/').Last().Replace(".html", "").Replace("tese", "");
                var urlPramArr = urlPrams.Split('_');
                pageNumber = int.Parse(urlPramArr[2]);
                teseDicId = int.Parse(urlPramArr[1]);
            }
            ViewBag.TeseDicId = teseDicId;

            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var houseData = factoryHouseService.GetPageFactoryHouse(101, 2, 0, teseDicId);

            var m = houseData.ToPagedList(pageNumber, 20);


            var factoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(10, 101);
            ViewBag.FactoryHouseChuShouList = factoryHouseChuShouList;

            return View(m);




        }
 
        public IPagedList<Cf_FactoryHouse> ChuZu(string url)
        {

            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(2);
            ViewBag.NavigationList = navigationList;

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



            pageNumber = 1;
            int teseDicId = 0;
            if (url.Contains(".html"))
            {
                string urlPrams = url.Split('/').Last().Replace(".html", "").Replace("tese", "");
                var urlPramArr = urlPrams.Split('_');
                pageNumber = int.Parse(urlPramArr[2]);
                teseDicId = int.Parse(urlPramArr[1]);
            }
            ViewBag.TeseDicId = teseDicId;

            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var houseData = factoryHouseService.GetPageFactoryHouse(143, 2, 0, teseDicId);

            var m = houseData.ToPagedList(pageNumber, 20);


            var factoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(10, 101);
            ViewBag.FactoryHouseChuShouList = factoryHouseChuShouList;

            return m;




        }
    }
}
