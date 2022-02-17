using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjSectionCoreItemService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjSectionCoreItem> GetDjSectionCoreItemList()
        {
            try
            {
                var djSectionCoreItems = Context.Jw_DjSectionCoreItem.Where(w=>w.IsEnable).OrderBy(o=>o.Sort);               
                return djSectionCoreItems.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_DjSectionCoreItem>();
            }
            
           
        }


    }
}
