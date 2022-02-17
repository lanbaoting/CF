using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjSectionService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjSection> GetDjSectionList()
        {
            try
            {                
                var djSection = Context.Jw_DjSection.Where(w => w.IsEnable);                
                return djSection.OrderBy(o=>o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_DjSection>();
            }
            
           
        }


    }
}
