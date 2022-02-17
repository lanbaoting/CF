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

        public IActionResult Index()
        {

            //int pageNumber;
            //string gameClassCode = GetRouteName(Request.Path, 1);



            //if (Request.Path.ToString().ToLower().Contains(".html"))
            //{
            //    string paramsStr = GetParams(Request.Path);

            //    if (!int.TryParse(paramsStr, out pageNumber))
            //    {
            //        return PageNotFound();
            //    }
            //}
            //else {

            //    pageNumber = 1;
            //}



            ////一级导航
            //Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            //var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(8);
            //ViewBag.Navigation2List = navigation2List;

            ////导航
            //var navigation2 = navigation2List.FirstOrDefault(w => Request.QueryString.ToString().Contains(w.LinkAddress));
            //if (navigation2 == null) {
            //    navigation2 = navigation2List.FirstOrDefault();
            //}

            //ViewBag.Navigation2 = navigation2;

            ////全部安卓游戏分类
            //Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            //var azGameClassList = azGameClassService.GetAzGameClassList();           
            //ViewBag.AzGameClassList = azGameClassList;

            //var azGameClass = azGameClassList.FirstOrDefault(w => w.Code == gameClassCode);
            //ViewBag.AzGameClass = azGameClass;

            ////游戏分页列表
            //Jw_AzGameService azGameService = new Jw_AzGameService();
            //var gameData = azGameService.GetPageGameList(azGameClass.Id);

            //var m = gameData.ToPagedList(pageNumber, 18);

            //return View(m);

            return View();


        }


    }
}
