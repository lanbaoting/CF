using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameRotationRightService : BaseService
    {
      
        /// <summary>
        ///   视频右边
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGameRotationRight> GetAzGameRotationRightList()
        {
            try
            {
                var list = Context.Jw_AzGameRotationRight.ToList();               
                return list;//list.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_AzGameRotationRight>();
            }
            
           
        }

       

    }
}
