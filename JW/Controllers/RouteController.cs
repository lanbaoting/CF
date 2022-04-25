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
    public class RouteController : BaseController
    {

        public IActionResult Index()
        {

            string url = HttpContext.Request.Path.ToString().ToLower();
            ViewBag.Path = url;
            string[]  paramsArr = url.Split('/');         
            string paramStr = paramsArr.Last();

            if (paramStr == "") 
            {
                paramStr = paramsArr[paramsArr.Length-2];
            }

            paramsArr = paramStr.Split("_");

            if (paramsArr[0] == "chuzu")
            {
                var m = ChangFangChuZu(url);
                return View("~/Views/ChangFang/ChuZu.cshtml", m);
            }
            else if (paramsArr[0] == "chushou")
            {
                var m = ChangFangChuShou(url);
                return View("~/Views/ChangFang/ChuShou.cshtml", m);
            }
            else if (paramsArr[0] == "cangkuchuzu")
            {
                var m = CangKuChuZu(url);
                return View("~/Views/CangKu/ChuZu.cshtml", m);
            }          
            else if (paramsArr[0] == "tesechuzu")
            {                              
                var  m = TeSeChangFang(url);                
                return View("~/Views/TeSeChangFang/ChuZu.cshtml", m);
            }
            else if (paramsArr[0] == "tesechushou")
            {
                var m = TeSeChangFang(url);
                return View("~/Views/TeSeChangFang/ChuShou.cshtml", m);
            }
            else if (paramsArr[0] == "hangyechushou")
            {
                var m = TeSeChangFang(url);
                return View("~/Views/TeSeChangFang/ChuShou.cshtml", m);
            }
            else if (paramsArr[0] == "hangyechuzu")
            {
                var m = TeSeChangFang(url);
                return View("~/Views/TeSeChangFang/ChuZu.cshtml", m);
            }
            else if (paramsArr[0] == "changfang")
            {
                ChangFang(url);
                return View("~/Views/ChangFang/XiangQing.cshtml");
            }
            return View();        
        }



        public IPagedList<Cf_FactoryHouse> ChangFangChuShou(string url )
        {
            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            string[] strs = url.Split('/').Where(w=>!string.IsNullOrEmpty(w)).ToArray();
            string areaCode = "";
            if (strs.Length > 1)
            {
                areaCode = strs[1];
            }
            else
            {
                areaCode = "shenyang";
            }
            
            var area = factoryHouseDictionaryService.GetDictionaryByCode(areaCode);
            area.Code = area.Code == "shenyang" ? "" : "/" + area.Code;
            ViewBag.Area = area;

            List<Cf_FactoryHouseDictionary> parentDics = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByCodes(new List<string> {"tese","biaoqian"});

            List<Cf_FactoryHouseDictionary> dics = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByParentIds(parentDics.Select(s=>s.Id).ToList());

            var teste = parentDics.Find(w => w.Code == "tese");
            var teseDics = dics.Where(w => w.ParentId == teste.Id);
            ViewBag.TeseDics = teseDics;


            var biaoqian = parentDics.Find(w => w.Code == "biaoqian");
            var biaoqianDics = dics.Where(w => w.ParentId == biaoqian.Id);
            ViewBag.BiaoqianDics = biaoqianDics;


            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(area.Id);
            ViewBag.NavigationList = navigationList;
            ViewBag.Path = url;
            int pageNumber;
                             
            //条件
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
            var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(area.Id, 2);
            ViewBag.CitySiteRangeSearchList = citySiteRangeSearchList;

   
            var urlDicPramArr = new List<int>(); 
            pageNumber = 1;
            
            if (url.Contains(".html"))
            {
                string urlPramStr = url.Split('/').Last();
                string urlPrams = urlPramStr.Replace(".html", "").Replace("chushou_", "");
                var urlPramArr = urlPrams.Split('_').Select(s => int.Parse(s)).ToList();        
                pageNumber = urlPramArr.Last();
                urlDicPramArr = urlPramArr.Take(urlPramArr.Count - 1).ToList();
            }
            ViewBag.UrlPramStr = string.Join("_", urlDicPramArr);
            
            var urlDicPramList = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByIds(urlDicPramArr);
            ViewBag.UrlDicPramArr = urlDicPramArr;
 

            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var houseData = factoryHouseService.GetPageFactoryHouse(101, area.Id, urlDicPramList);
                          var m = houseData.ToPagedList(pageNumber, 20);


            //厂房出租信息
            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, 143);
            ViewBag.FactoryHouseList = factoryHouseChuZuList;




            return m;
        }




        public IPagedList<Cf_FactoryHouse> ChangFangChuZu(string url)
        {


            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            string[] strs = url.Split('/').Where(w => !string.IsNullOrEmpty(w)).ToArray();
            string areaCode = "";
            if (strs.Length > 1)
            {
                areaCode = strs[1];
            }
            else
            {
                areaCode = "shenyang";
            }

            var area = factoryHouseDictionaryService.GetDictionaryByCode(areaCode);
            area.Code = area.Code == "shenyang" ? "" : "/" + area.Code;
            ViewBag.Area = area;

            List<Cf_FactoryHouseDictionary> parentDics = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByCodes(new List<string> { "tese", "biaoqian" });

            List<Cf_FactoryHouseDictionary> dics = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByParentIds(parentDics.Select(s => s.Id).ToList());

            var teste = parentDics.Find(w => w.Code == "tese");
            var teseDics = dics.Where(w => w.ParentId == teste.Id);
            ViewBag.TeseDics = teseDics;


            var biaoqian = parentDics.Find(w => w.Code == "biaoqian");
            var biaoqianDics = dics.Where(w => w.ParentId == biaoqian.Id);
            ViewBag.BiaoqianDics = biaoqianDics;


            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(area.Id);
            ViewBag.NavigationList = navigationList;
            ViewBag.Path = url;
            int pageNumber;

            //条件
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
            var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(area.Id, 2);
            ViewBag.CitySiteRangeSearchList = citySiteRangeSearchList;


            var urlDicPramArr = new List<int>();
            pageNumber = 1;

            if (url.Contains(".html"))
            {
                string urlPramStr = url.Split('/').Last();
                string urlPrams = urlPramStr.Replace(".html", "").Replace("chuzu_", "");
                var urlPramArr = urlPrams.Split('_').Select(s => int.Parse(s)).ToList();
                pageNumber = urlPramArr.Last();
                urlDicPramArr = urlPramArr.Take(urlPramArr.Count - 1).ToList();
            }
            ViewBag.UrlPramStr = string.Join("_", urlDicPramArr);

            var urlDicPramList = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByIds(urlDicPramArr);
            ViewBag.UrlDicPramArr = urlDicPramArr;


            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var houseData = factoryHouseService.GetPageFactoryHouse(143, area.Id, urlDicPramList);
            var m = houseData.ToPagedList(pageNumber, 20);


            //厂房出租信息
            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, 101);
            ViewBag.FactoryHouseList = factoryHouseChuZuList;

            return m;
         
        }



        public IPagedList<Cf_StorageHouse> CangKuChuZu(string url)
        {
            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            string[] strs = url.Split('/').Where(w => !string.IsNullOrEmpty(w)).ToArray();
            string areaCode = "";
            if (strs.Length > 1)
            {
                areaCode = strs[1];
            }
            else
            {
                areaCode = "shenyang";
            }
            var area = factoryHouseDictionaryService.GetDictionaryByCode(areaCode);
            area.Code = area.Code == "shenyang" ? "" : "/" + area.Code;
            ViewBag.Area = area;


            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
            var navigationList = navigationService.GetNavigationList(area.Id);
            ViewBag.NavigationList = navigationList;
            ViewBag.Path = url;
            int pageNumber;

            //条件
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
            var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(area.Id, 3);
            ViewBag.CitySiteRangeSearchList = citySiteRangeSearchList;


            var urlDicPramArr = new List<int>();
            pageNumber = 1;

            if (url.Contains(".html"))
            {
                string urlPramStr = url.Split('/').Last();
                string urlPrams = urlPramStr.Replace(".html", "").Replace("cangkuchuzu_", "");
                var urlPramArr = urlPrams.Split('_').Select(s => int.Parse(s)).ToList();
                pageNumber = urlPramArr.Last();
                urlDicPramArr = urlPramArr.Take(urlPramArr.Count - 1).ToList();
            }
            ViewBag.UrlPramStr = string.Join("_", urlDicPramArr);

            var urlDicPramList = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByIds(urlDicPramArr);
            ViewBag.UrlDicPramArr = urlDicPramArr;


            //游戏分页列表
            Cf_StorageHouseService storageHouseService = new Cf_StorageHouseService();
            var houseData = storageHouseService.GetPageStorageHouse(143, area.Id, urlDicPramList);
            var m = houseData.ToPagedList(pageNumber, 20);

            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            //厂房出租信息
            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, 143);
            ViewBag.FactoryHouseChuZuList = factoryHouseChuZuList;


            return m;




        }



        public void ChangFang(string url)
        {

            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            string[] strs = url.Split('/').Where(w => !string.IsNullOrEmpty(w)).ToArray();
            string areaCode = "";
            if (strs.Length > 1)
            {
                areaCode = strs[1];
            }
            else
            {
                areaCode = "shenyang";
            }
            var area = factoryHouseDictionaryService.GetDictionaryByCode(areaCode);
            area.Code = area.Code == "shenyang" ? "" : "/" + area.Code;
            ViewBag.Area = area;


           
            ViewBag.Path = url;
            int factoryHouseId;

        
            string id = strs.Last().Replace(".html", "").Replace("changfang_", "");
            if (!int.TryParse(id, out factoryHouseId))
            {
                 PageNotFound();
            }


            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            var factoryHouse = factoryHouseService.GetFactoryHouse(factoryHouseId);

            if (factoryHouse == null)
            {
                 PageNotFound();
            }
            ViewBag.FactoryHouse = factoryHouse;



            Cf_FactoryHouseDetailsService factoryHouseDetailsService = new Cf_FactoryHouseDetailsService();
            var factoryHouseDetials = factoryHouseDetailsService.GetFactoryHouseDetials(factoryHouseId);
            ViewBag.FactoryHouseDetials = factoryHouseDetials;

 

 
            Cf_FactoryHousePicturesService factoryHousePicturesService = new Cf_FactoryHousePicturesService();

            var factoryHousePicturesList = factoryHousePicturesService.GetFactoryHousePicturesList(factoryHouse.Id);

            List<int> parentIds = new List<int>();
            if (!string.IsNullOrEmpty(factoryHouseDetials.ChangFangLeiBie)) 
            {
                parentIds.Add(6);
            }
            if (!string.IsNullOrEmpty(factoryHouseDetials.ChangFangTeSe))
            {
                parentIds.Add(7);
            }

            if (parentIds.Count > 0) 
            {
               ViewBag.FactoryHouseDictionarys =  factoryHouseDictionaryService.GetFactoryHouseDictionaryListByParentIds(parentIds);
            }

         
            ViewBag.FactoryHousePicturesList = factoryHousePicturesList;

 
            Cf_FactoryHouseCategoryService factoryHouseCategoryService = new Cf_FactoryHouseCategoryService();


            var factoryHouseCategoryList = factoryHouseCategoryService.GetFactoryHouseCategoryList(factoryHouse.Id);

 

            if (factoryHouse.FloorTypeId != null || factoryHouse.HousingStructureId != null || factoryHouseCategoryList.Count > 0)
            {
                //条件
                Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
                var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(area.Id, 2);

                var list = citySiteRangeSearchList.Where(w => w.ParentId == 0).OrderBy(s => s.Sort);

                List<List<int>> citySiteRangeSearchIds = new List<List<int>>();

                foreach (var s in list) {
                    var ids = citySiteRangeSearchList.Where(w => w.ParentId == s.Id).Select(s => s.FactoryHouseDictionaryId).ToList();
                    citySiteRangeSearchIds.Add(ids);
                }
                ViewBag.CitySiteRangeSearchIds = citySiteRangeSearchIds;
            }

            Cf_FactoryHouseFeatureService factoryHouseFeatureService = new Cf_FactoryHouseFeatureService();
            var factoryHouseFeatureList = factoryHouseFeatureService.GetFactoryHouseFeatureList(factoryHouse.Id);
            ViewBag.FactoryHouseFeatureList = factoryHouseFeatureList;
            

            //厂房出租信息
            var factoryHouseList = factoryHouseService.GetFactoryHouseList(10, factoryHouse);
            ViewBag.FactoryHouseList = factoryHouseList;

            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, 143);
            ViewBag.FactoryHouseChuZuList = factoryHouseChuZuList;
            var factoryHouseChuShouList = factoryHouseService.GetFactoryHouseList(10, 101);
            ViewBag.FactoryHouseChuShouList = factoryHouseChuShouList;


        }

 
        public IPagedList<Cf_FactoryHouse> TeSeChangFang(string url)
        {

            //一级导航
            Cf_NavigationService navigationService = new Cf_NavigationService();
        

            ViewBag.Path = url;

            int pageNumber;
         
            Cf_FactoryHouseDictionaryService factoryHouseDictionaryService = new Cf_FactoryHouseDictionaryService();
            string[] strs = url.Split('/').Where(w => !string.IsNullOrEmpty(w)).ToArray();
            string areaCode = "";
            if (strs.Length > 2)
            {
                areaCode = strs[1];
            }
            else
            {
                areaCode = "shenyang";
            }
            var area = factoryHouseDictionaryService.GetDictionaryByCode(areaCode);
            area.Code = area.Code == "shenyang" ? "" : "/" + area.Code;
            ViewBag.Area = area;
            var navigationList = navigationService.GetNavigationList(area.Id);
            ViewBag.NavigationList = navigationList;


            //条件
            Cf_CitySiteRangeSearchService citySiteRangeSearchService = new Cf_CitySiteRangeSearchService();
            var citySiteRangeSearchList = citySiteRangeSearchService.GetCitySiteRangeSearchList(area.Id, 2);
            ViewBag.CitySiteRangeSearchList = citySiteRangeSearchList;



            pageNumber = 1;
            int teseDicId = 0;
            
            string urlPrams = url.Split('/').Last().Replace(".html", "");
            var urlPramArr = urlPrams.Split('_');
            pageNumber = int.Parse(urlPramArr[2]);
            teseDicId = int.Parse(urlPramArr[1]);
          
            ViewBag.TeseDic = factoryHouseDictionaryService.GetDictionaryById(teseDicId);

            //游戏分页列表
            Cf_FactoryHouseService factoryHouseService = new Cf_FactoryHouseService();
            int transactionModeId = 101;

            if (urlPramArr[0].Contains("chuzu"))
            {
                transactionModeId = 143;
            }





            var factoryHouseChuZuList = factoryHouseService.GetFactoryHouseList(10, transactionModeId);
            ViewBag.FactoryHouseList = factoryHouseChuZuList;


            List<Cf_FactoryHouseDictionary> parentDics = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByCodes(new List<string> { "tese", "biaoqian" });

            List<Cf_FactoryHouseDictionary> dics = factoryHouseDictionaryService.GetFactoryHouseDictionaryListByParentIds(parentDics.Select(s => s.Id).ToList());

            var teste = parentDics.Find(w => w.Code == "tese");
            var teseDics = dics.Where(w => w.ParentId == teste.Id);
            ViewBag.TeseDics = teseDics;


            var biaoqian = parentDics.Find(w => w.Code == "biaoqian");
            var biaoqianDics = dics.Where(w => w.ParentId == biaoqian.Id);
            ViewBag.BiaoqianDics = biaoqianDics;




            if (urlPramArr[0].Contains("hangye"))
            {
                var houseData = factoryHouseService.GetPageTageFactoryHouse(transactionModeId, area.Id, 0, teseDicId);
                var m = houseData.ToPagedList(pageNumber, 20);
                return m;                
            }
            else
            {
                var houseData = factoryHouseService.GetPageFactoryHouse(transactionModeId, area.Id, 0, teseDicId);
                var m = houseData.ToPagedList(pageNumber, 20);
                return m;
            }
 
        }

    }
}
