using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjSectionCoreService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjSectionCore> GetDjSectionCoreList()
        {
            try
            {               
                var djSectionCores = Context.Jw_DjSectionCore.Where(w => w.IsEnable);                
                return djSectionCores.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_DjSectionCore>();
            }
            
           
        }


    }
}
