using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameTypeService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGameType> GetAzGameTypeList()
        {
            try
            {
                var list = Context.Jw_AzGameType.Where(w=>w.IsEnable).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_AzGameType>();
            }
            
           
        }


    }
}
