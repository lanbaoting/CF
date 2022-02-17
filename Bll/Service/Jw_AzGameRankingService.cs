using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameRankingService : BaseService
    {
      
        /// <summary>
        ///   安卓游戏分类排行
        /// </summary>
        /// <returns></returns>
        public List<AzGameRanking> GetAzGameRankingList(int? azGameClassId, int topCout)
        {
            try
            {
                var azGameRankings = Context.Jw_AzGameRanking.Where(w => w.AzGameClassId == azGameClassId);

                var azGames = Context.Jw_AzGame.Where(w => w.IsEnable);
                var azGameClassList = Context.Jw_AzGameClass.Where(w => w.IsEnable);

                var list = from azGameRanking in azGameRankings
                           join azGame in azGames on azGameRanking.AzGameId equals azGame.Id
                           join azGameClass in azGameClassList on azGame.AzGameClassId equals azGameClass.Id
                           select new AzGameRanking
                           {
                               AzGameId = azGame.Id,
                               AzGameName = azGame.Name,
                               AzGameClassName = azGame.AzGameClassName,
                               AzGameClassCode = azGameClass.Code,
                               CoverMap = azGame.CoverMap,
                               Sort = azGameRanking.Sort,
                               Praise = azGame.Praise,
                               BadEvaluation = azGame.BadEvaluation
                           };
 
                return list.Take(topCout).ToList();
            }
            catch (Exception e)
            {
                return new List<AzGameRanking>();
            }
            
           
        }

       

    }
}
