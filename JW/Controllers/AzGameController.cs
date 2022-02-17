using Bll.Service;
using Entity;
using Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
 

namespace JW.Controllers
{
    public class AzGameController : BaseController
    {

        public IActionResult Index()
        {
            //一级导航
            Jw_Navigation2Service navigation2Service = new Jw_Navigation2Service();
            var navigation2List = navigation2Service.GetNavigation2ByNavigation1IdList(8);
            ViewBag.Navigation2List = navigation2List;

            //导航
            var navigation2 = navigation2List.FirstOrDefault(w => Request.Path.ToString().Contains(w.LinkAddress));
            if (navigation2 == null) {
                navigation2 = navigation2List.FirstOrDefault();
            }
            
            ViewBag.Navigation2 = navigation2;
 
            //全部安卓游戏分类
            Jw_AzGameClassService azGameClassService = new Jw_AzGameClassService();
            var azGameClassList = azGameClassService.GetAzGameClassList();           
            ViewBag.AzGameClassList = azGameClassList;

 
            //获取 安卓 游戏
            Jw_AzGameService azGameService = new Jw_AzGameService();      
      

            List<AzGroupGameClassGame> azGroupGameClassGameList = new List<AzGroupGameClassGame>();
            for (int i = 0; i < azGameClassList.Count(); i++) {
                
                AzGroupGameClassGame azGroupGameClassGame = new AzGroupGameClassGame()
                {
                    AzGameClassId = azGameClassList[i].Id,
                    AzGameClassName = azGameClassList[i].Name,
                    AzGameClassCode = azGameClassList[i].Code
                };
                azGroupGameClassGameList.Add(azGroupGameClassGame);
                var azGameList = azGameService.GetGameList(azGroupGameClassGame.AzGameClassId, 5);
                azGroupGameClassGame.AzGameList = azGameList;
            }
            ViewBag.AzGroupGameClassGameList = azGroupGameClassGameList;
 

            return View();
        }

       
    }
}
