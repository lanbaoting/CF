using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameRotationService : BaseService
    {
      
        /// <summary>
        ///   轮播
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGameRotation> GetAzGameRotationList()
        {
            try
            {
                var list = Context.Jw_AzGameRotation.ToList();
               
                return list;//list.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_AzGameRotation>();
            }
            
           
        }

       

    }
}
