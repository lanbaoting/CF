using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjSectionAsideService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjSectionAside> GetDjSectionAsideList()
        {
            try
            {
                var djSectionAsides= Context.Jw_DjSectionAside.Where(w=>w.IsEnable);               
                return djSectionAsides.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_DjSectionAside>();
            }
            
           
        }


    }
}
