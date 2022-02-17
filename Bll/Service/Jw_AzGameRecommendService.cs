using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameRecommendService : BaseService
    {
      
        /// <summary>
        ///   安卓游戏分类推荐
        /// </summary>
        /// <returns></returns>
        public List<AzGameRecommend> GetAzGameRecommendList(int? azGameClassId,int topCout)
        {
            try
            {

                var azGameRecommends = Context.Jw_AzGameRecommend.Where(w => w.AzGameClassId == azGameClassId);

                var azGames = Context.Jw_AzGame.Where(w => w.IsEnable);
                var azGameClassList = Context.Jw_AzGameClass.Where(w => w.IsEnable);
                var list = from azGameRecommend in azGameRecommends
                           join azGame in azGames on azGameRecommend.AzGameId equals azGame.Id
                            
                join azGameClass in azGameClassList on azGame.AzGameClassId equals azGameClass.Id
                          select new AzGameRecommend
                          {
                              AzGameId = azGame.Id,
                              AzGameName = azGame.Name,
                              AzGameClassName = azGame.AzGameClassName,
                              AzGameClassCode = azGameClass.Code,
                              CoverMap = azGame.CoverMap,
                              Sort = azGameRecommend.Sort,
                              GameSize = azGame.GameSize,
                              Edition =azGame.Edition,
                              Praise = azGame.Praise,
                              BadEvaluation = azGame.BadEvaluation

                          };




                return list.Take(topCout).ToList();
            }
            catch (Exception e)
            {
                return new List<AzGameRecommend>();
            }
            
           
        }

       

    }
}
