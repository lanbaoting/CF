using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjSectionCoreItemGameService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<DjSectionCoreItemGame> GetDjSectionCoreItemGameList()
        {
            try
            {
                var djSectionCoreItemGames = Context.Jw_DjSectionCoreItemGame;
                var djGames = Context.Jw_DjGame.Where(w => w.IsEnable);
                var list = from djSectionCoreItemGame in djSectionCoreItemGames
                           join djGame in djGames on djSectionCoreItemGame.DjGameId equals djGame.Id
                           select new DjSectionCoreItemGame
                           {
                               DjGameId= djGame.Id,
                               Sort = djSectionCoreItemGame.Sort,
                               Name = djGame.Name,
                               DjSectionCoreItemId= djSectionCoreItemGame.DjSectionCoreItemId,
                               LanguageName = djGame.LanguageName,
                               CoverMap = djGame.CoverMap,
                               Size = djGame.Size
                           };

                return list.OrderBy(o=>o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<DjSectionCoreItemGame>();
            }
            
           
        }


    }
}
