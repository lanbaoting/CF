using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameVideoService : BaseService
    {
      
        /// <summary>
        ///   视频
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGameVideo> GetAzGameVideoList(int azGameid)
        {
            try
            {
                var list = Context.Jw_AzGameVideo.Where(w => w.AzGameId == azGameid && !string.IsNullOrEmpty(w.VideoAddress)).ToList();
               
                return list;//list.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_AzGameVideo>();
            }
            
           
        }
         


    }
}
