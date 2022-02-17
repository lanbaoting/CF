using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameTypeGameService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<AzGameTypeGame> GetAzGameTypeGameList()
        {
            try
            {
                var azGameTypeGames = Context.Jw_AzGameTypeGame;
                var azGames = Context.Jw_AzGame.Where(w => w.IsEnable);
                var list = from azGameTypeGame in azGameTypeGames
                           join azGame in azGames on azGameTypeGame.AzGameId equals azGame.Id
                           select new AzGameTypeGame
                           {
                               AzGameId = azGame.Id,
                               Sort = azGameTypeGame.Sort,
                               AzGameName = azGame.Name,
                               AzGameTypeId = azGameTypeGame.AzGameTypeId,
                               CoverMap = azGame.CoverMap
                           };

                return list.OrderBy(o=>o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<AzGameTypeGame>();
            }
            
           
        }


    }
}
