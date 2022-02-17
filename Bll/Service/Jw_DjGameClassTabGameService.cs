using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameClassTabGameService : BaseService
    {
      
        /// <summary>
        ///  通过分类标签获取游戏  
        /// </summary>
        /// <returns></returns>
        public List<DjGameClassTabGame> GetDjGameClassTabGameList()
        {
            try
            {
 
                var gameList = Context.Jw_DjGame.Where(w => w.IsEnable);
                var gameClassTabGameList = Context.Jw_DjGameClassTabGame;
                var list = from gameClassTabGame in gameClassTabGameList
                           join game in gameList on gameClassTabGame.DjGameId equals game.Id
                           select new DjGameClassTabGame
                           {
                               DjGameId = gameClassTabGame.Id,
                               DjGameClassTabId = gameClassTabGame.DjGameClassTabId,
                               Name = game.Name,
                               LanguageName = game.LanguageName,
                               Size = game.Size,
                               Sort = gameClassTabGame.Sort,
                           };
                return list.OrderBy(o=>o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<DjGameClassTabGame>();
            }
            
           
        }

        

    }
}
