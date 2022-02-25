using Bll.Service;
using Entity;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace JW.Controllers
{
    public class FactoryHouseListController : BaseController
    {

        public IActionResult ChuShou()
        {

            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(1);
            ViewBag.NavigationList = navigationList;

            ViewBag.Path = HttpContext.Request.Path;

            int pageNumber;
            //  string gameClassCode = GetRouteName(Request.Path, 1);

            // 区域
            Cf_AreaService areaService = new Cf_AreaService();
            var areaList = areaService.GetAreaList(1);
            ViewBag.AreaList = areaList;

    

            //条件
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
            var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(1,2);
            ViewBag.CitySiteRangeSearchList = citySiteRangeSearchList;



            if (Request.Path.ToString().ToLower().Contains(".html"))
            {
                string paramsStr = GetParams(Request.Path);

                if (!int.TryParse(paramsStr, out pageNumber))
                {
                    return PageNotFound();
                }
            }
            else
            {
                pageNumber = 1;
            }




            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var houseData = factoryHouseService.GetPageFactoryHouse("");

            var m = houseData.ToPagedList(pageNumber, 20);

            return View(m);

          


        }


    }
}
