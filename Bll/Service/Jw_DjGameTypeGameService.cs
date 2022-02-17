using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameTypeGameService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<DjGameTypeGame> GetDjGameTypeGameList()
        {
            try
            {
                var djGameTypeGames = Context.Jw_DjGameTypeGame;
                var djGames = Context.Jw_DjGame.Where(w => w.IsEnable);
                var list = from djGameTypeGame in djGameTypeGames
                           join djGame in djGames on djGameTypeGame.DjGameId equals djGame.Id
                           select new DjGameTypeGame
                           {
                               DjGameId= djGame.Id,
                               Sort = djGameTypeGame.Sort,
                               Name = djGame.Name,
                               DjGameTypeId= djGameTypeGame.DjGameTypeId,
                           };

                return list.OrderBy(o=>o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<DjGameTypeGame>();
            }
            
           
        }


    }
}
