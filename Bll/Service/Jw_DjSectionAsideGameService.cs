using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjSectionAsideGameService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<DjSectionAsideGame> GetDjSectionAsideGameList()
        {
            try
            {
                var djSectionAsideGames = Context.Jw_DjSectionAsideGame;
                var djGames = Context.Jw_DjGame.Where(w => w.IsEnable);
                var list = from djSectionAsideGame in djSectionAsideGames
                           join djGame in djGames on djSectionAsideGame.DjGameId equals djGame.Id
                           select new DjSectionAsideGame
                           {
                               DjGameId= djGame.Id,
                               Sort = djSectionAsideGame.Sort,
                               Name = djGame.Name,
                               DjSectionAsideId= djSectionAsideGame.DjSectionAsideId,
                               F_CreateDate = djGame.F_CreateDate
                           };

                return list.OrderBy(o=>o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<DjSectionAsideGame>();
            }
            
           
        }


    }
}
