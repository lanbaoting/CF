using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_MapControllerRouteService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_MapControllerRoute> GetMapControllerRouteList()
        {
            try
            {
                var list = Context.Jw_MapControllerRoute.ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_MapControllerRoute>();
            }
            
           
        }

        

    }
}
