using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameTypeService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjGameType> GetDjGameTypeList()
        {
            try
            {
                var list = Context.Jw_DjGameType.Where(w=>w.IsEnable).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_DjGameType>();
            }
            
           
        }


    }
}
