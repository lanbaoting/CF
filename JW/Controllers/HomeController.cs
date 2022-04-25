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
            Cf_NavigationService navigationService = new Cf_NavigationService();
            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();

            string url = HttpContext.Request.Path.ToString().ToLower();
            ViewBag.Path = url;

            string[] strs = url.Split('/');
            string areaCode = "";
            if (strs.Length > 2){
                areaCode = strs[strs.Length - 2];
            }else {
                areaCode = "shenyang";
            }           
            
           
            //字典根节点
            var parenteDictionarys = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByCodes(new List<string>() { "louceng", "tese", "jiegou" , areaCode });

            //字典二级节点
            var dictionaryIds = parenteDictionarys.Select(s => s.Id).ToList();
            var dictionarys = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByParentIds(dictionaryIds);

            //城市
            var area = parenteDictionarys.Find(w=>w.Code == areaCode) ;         
            area.Code = area.Code == "shenyang" ? "": "/" + area.Code;
            ViewBag.Area = area;


            //城市导航集合
            var navigationList = navigationService.GetNavigationList(area.Id);
            ViewBag.NavigationList = navigationList;

            //城市导航
            var navigation = navigationList.Find(w => url.Contains(w.LinkAddress));
            ViewBag.Navigation = navigation;
 
            //区域                     
            var areaList = dictionarys.Where(w=>w.ParentId == area.Id).ToList();
            ViewBag.AreaList = areaList;
            //省份
            var parentArea = factoryHouseDictionaryService.GetFactoryHouseDictionaryListById(area.ParentId.Value);
            ViewBag.ParentArea = parentArea;

            //区域查询条件数量
            var citySiteRangeSearchCount = citySiteRangeSearchService.GetCitySiteRangeSearchCount(area.Id, 2, 0);
            ViewBag.CitySiteRangeSearchCount = citySiteRangeSearchCount;










            //特色
            var dictionaryTese = parenteDictionarys.FirstOrDefault(w => w.Code == "tese");
            var teseHousingList = dictionarys.Where(w => w.ParentId == dictionaryTese.Id).ToList();
            ViewBag.TeseHousingList = teseHousingList;


            //厂房出售信息
            var factoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(10, 101);
            ViewBag.FactoryHouseChuShouList = factoryHouseChuShouList;

            //厂房出租信息
            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, 143);
            ViewBag.FactoryHouseChuZuList = factoryHouseChuZuList;

        
            var ids1 = factoryHouseChuShouList.Select(s => s.Id).ToList();
            var ids2 = factoryHouseChuZuList.Select(s => s.Id).ToList();
            ids1.AddRange(ids2);

            
          

            //字典结构
            var parenteDictionaryJieGou = parenteDictionarys.FirstOrDefault(w => w.Code == "jiegou");
            var dictionarysJieGous = dictionarys.Where(w => w.ParentId == parenteDictionaryJieGou.Id).Take(4).ToList();
            ViewBag.DictionarysJieGous = dictionarysJieGous;

 
            //结构厂房列表
            var dictionarysJieGouIds = dictionarysJieGous.Select(s=>s.Id).ToList();
            var housingStructureHouseList = factoryHouseService.GetHousingStructureHouseList(ids1, dictionarysJieGouIds, 15);
            ViewBag.HousingStructureHouseList = housingStructureHouseList;
            foreach (var m in housingStructureHouseList) 
            {
                var jieGou = dictionarysJieGous.FirstOrDefault(w => w.Id == m.FactoryHouseDictionaryId);
                m.FactoryHouseDictionaryName = jieGou.Name;
                var  ids3 = m.FactoryHouseList.Select(s => s.Id);
               ids1.AddRange(ids3);
            }
            ids1 = ids1.Distinct().ToList();


            var dictionaryLouCeng= parenteDictionarys.FirstOrDefault(w => w.Code == "louceng");
            var louCengHousingList = dictionarys.Where(w => w.ParentId == dictionaryLouCeng.Id).ToList();            
            ViewBag.LouCengHousingList = louCengHousingList;

            var dictionaryLouCengsIds = louCengHousingList.Select(s => s.Id).ToList();                  
            var floorTypeFactoryHouseList = factoryHouseService.GetFloorTypeFactoryHouseList(ids1, dictionaryLouCengsIds, 10);
            foreach (var m in floorTypeFactoryHouseList) 
            {
                var type = louCengHousingList.FirstOrDefault(w => w.Id == m.FactoryHouseDictionaryId);
                m.FactoryHouseDictionaryName = type.Name;
            }
            ViewBag.FloorTypeFactoryHouseList = floorTypeFactoryHouseList;


            Jw_ArticleService articleService = new Jw_ArticleService();
             ViewBag.ArticleList = articleService.GetArticleList(5);

            return View();
        }

       
    }
}
