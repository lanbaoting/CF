using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameRankingService : BaseService
    {
      
        /// <summary>
        ///  通过单击游戏分类集合 
        ///  查询每个分类下的前14个游戏
        /// </summary>
        /// <returns></returns>
        public List<DjGame> Get_DjGameRankingListByClassId(int gameClassId)
        {
            try
            {
                var djGameRankingList = Context.Jw_DjGameRanking.Where(w => w.DjGameClassId == gameClassId);
                var djGameList = Context.Jw_DjGame.Where(w => w.DjGameClassId == gameClassId && w.IsEnable);
                var gameList = from djGameRanking in djGameRankingList
                               join djGame in djGameList
                               on djGameRanking.DjGameId equals djGame.Id
                               select new DjGame
                               {
                                   DjGameId = djGame.Id,
                                   CoverMap = djGame.CoverMap,
                                   LanguageName = djGame.LanguageName,
                                   Size = djGame.Size,
                                   Sort = djGameRanking.Sort,
                                   DjGameClassName = djGame.DjGameClassName
                               };
                return gameList.OrderBy(o=>o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<DjGame>();
            }
            
           
        }

        /// <summary>       
        ///  通过主键获取游戏Id
        /// </summary>
        /// <returns></returns>
        public Jw_DjGame GetDjGameById(int djGameId)
        {
            try
            {
                var game = Context.Jw_DjGame.FirstOrDefault(w => w.IsEnable && w.Id == djGameId);
                return game;
            }
            catch (Exception e)
            {
                return null;
            } 
        }

    }
}
