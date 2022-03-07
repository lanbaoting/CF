using Bll.Service;
using Entity;
using JW.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
 

namespace JW.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            //导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(1);
            ViewBag.NavigationList = navigationList;

            ViewBag.Path = HttpContext.Request.Path;

            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            //厂房出售信息
             var factoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(20, 101);
            ViewBag.FactoryHouseChuShouList = factoryHouseChuShouList;

            //厂房出租信息
            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(20, 101);
            ViewBag.FactoryHouseChuZuList = factoryHouseChuShouList;

            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();

            var ids1 = factoryHouseChuShouList.Select(s => s.Id).ToList();
            var ids2 = factoryHouseChuZuList.Select(s => s.Id).ToList();
            ids1.AddRange(ids2);

            var parenteDictionarys = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByCodes(new List<string>() { "louceng", "leibie" });
            var dictionaryIds = parenteDictionarys.Select(s => s.Id).ToList();
            var dictionarys = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByParentIds(dictionaryIds);



            var parenteDictionaryLeiBie = parenteDictionarys.FirstOrDefault(w => w.Code == "leibie");

            var dictionarysLeiBies = dictionarys.Where(w => w.ParentId == parenteDictionaryLeiBie.Id).ToList();
            ViewBag.DictionarysLeiBies = dictionarysLeiBies;
            var dictionarysLeiBieIds = dictionarysLeiBies.Select(s => s.Id).ToList();
            var factoryHouseCategoryHouseList = factoryHouseService.GetFactoryHouseCategoryHouseList(ids1, dictionarysLeiBieIds, 10);


            ViewBag.FactoryHouseCategoryHouseList = factoryHouseCategoryHouseList;
            foreach (var m in factoryHouseCategoryHouseList) 
            {
                var  ids3 = m.FactoryHouseList.Select(s => s.Id);
               ids1.AddRange(ids3);
            }


            var parenteDictionaryLouCeng= parenteDictionarys.FirstOrDefault(w => w.Code == "louceng");
            var parenteDictionaryLouCengs = dictionarys.Where(w => w.ParentId == parenteDictionaryLouCeng.Id).ToList();
            ViewBag.ParenteDictionaryLouCengs = parenteDictionaryLouCengs;
            var dictionaryLouCengsIds = parenteDictionaryLouCengs.Select(s => s.Id).ToList();         
            var floorTypeFactoryHouseList = factoryHouseService.GetFactoryHouseCategoryHouseList(ids1, dictionaryLouCengsIds, 10);
            ViewBag.FloorTypeFactoryHouseList = floorTypeFactoryHouseList;

     
 


            return View();
        }

       
    }
}
