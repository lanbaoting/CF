using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjHotWorkService : BaseService
    {

        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<DjHotWork> GeDjHotWorkList()
        {
            try
            {
                var djHotWorks = Context.Jw_DjHotWork;
                var djGames = Context.Jw_DjGame.Where(w => w.IsEnable);
                var list = from djHotWork in djHotWorks
                           join djGame in djGames on djHotWork.DjGameId equals djGame.Id
                           select new DjHotWork
                           {
                               DjGameId = djGame.Id,
                               Sort = djHotWork.Sort,
                               Name = djGame.Name,
                               CoverMap = djGame.CoverMap,
                               SeoDesc = djGame.SeoDesc,
                               F_CreateDate = djGame.F_CreateDate,
                           };

                return list.OrderBy(o => o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<DjHotWork>();
            }


        }



    }
}
