using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameMainPushService : BaseService
    {
      
        /// <summary>
        ///   主推游戏
        /// </summary>
        /// <returns></returns>
        public List<AzGameMainPush> GetAzGameMainPushList()
        {
            try
            {
                var azGameMainPushs = Context.Jw_AzGameMainPush;

                var azGames = Context.Jw_AzGame.Where(w => w.IsEnable);
                var azGameClassList = Context.Jw_AzGameClass.Where(w => w.IsEnable);

                var list = from azGameMainPush in azGameMainPushs
                           join azGame in azGames on azGameMainPush.AzGameId equals azGame.Id
                           join azGameClass in azGameClassList on azGame.AzGameClassId equals azGameClass.Id
                           select new AzGameMainPush
                           {
                               AzGameId = azGame.Id,
                               AzGameName = azGame.Name,                            
                               CoverMap = azGame.CoverMap,
                               Sort = azGameMainPush.Sort,
                               SeoDesc = azGame.SeoDesc
                           };
                return list.OrderBy(s => s.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<AzGameMainPush>();
            }
            
           
        }

       

    }
}
