using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameDetailsService : BaseService
    {
      
        

        /// <summary>       
        ///  通过主键获取游戏详情
        /// </summary>
        /// <returns></returns>
        public Jw_DjGameDetails GetDjGameDetailsById(int djGameId)
        {
            try
            {
                var djGameDetails = Context.Jw_DjGameDetails.FirstOrDefault(w =>w.DjGameId == djGameId);
                return djGameDetails;
            }
            catch (Exception e)
            {
                return null;
            } 
        }

    }
}
