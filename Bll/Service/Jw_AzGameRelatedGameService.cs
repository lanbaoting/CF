using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameRelatedGameService : BaseService
    {
      
        /// <summary>
        ///   关联游戏
        /// </summary>
        /// <returns></returns>
        public List<AzGameRelatedGame> GetAzGameRelatedGameList(int azGameId)
        {
            try
            {
                var azGameRelatedGames = Context.Jw_AzGameRelatedGame.Where(w=>w.AzGameId == azGameId);

                var azGames = Context.Jw_AzGame.Where(w => w.IsEnable);
                var azGameClassList = Context.Jw_AzGameClass.Where(w => w.IsEnable);

                var list = from azGameRelatedGame in azGameRelatedGames
                           join azGame in azGames on azGameRelatedGame.RelatedAzGameId equals azGame.Id
                           join azGameClass in azGameClassList on azGame.AzGameClassId equals azGameClass.Id
                           select new AzGameRelatedGame
                           {
                               RelatedAzGameId = azGame.Id,
                               RelatedAzGameName = azGame.Name,                          
                               Edition = azGame.Edition,
                               F_CreateDate = azGame.F_CreateDate,
                               Sort = azGameRelatedGame.Sort.Value

                           };
                return list.OrderBy(s=>s.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<AzGameRelatedGame>();
            }
            
           
        }

       

    }
}
