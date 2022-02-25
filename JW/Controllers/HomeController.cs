using Bll.Service;
using Entity;
using JW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
 

namespace JW.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(1);
            ViewBag.NavigationList = navigationList;

            ViewBag.Path = HttpContext.Request.Path;

            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            ViewBag.FactoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(20,11);
            ViewBag.FactoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(20,12);

            return View();
        }

       
    }
}
