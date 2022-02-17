using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameDetailsService : BaseService
    {
      
        

        /// <summary>       
        ///  通过主键获取游戏详情
        /// </summary>
        /// <returns></returns>
        public Jw_AzGameDetails GetAzGameDetailsById(int azGameId)
        {
            try
            {
                var azGameDetails = Context.Jw_AzGameDetails.FirstOrDefault(w =>w.AzGameId == azGameId);
                return azGameDetails;
            }
            catch (Exception e)
            {
                return null;
            } 
        }

    }
}
