using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameClassLinksService : BaseService
    {
      
        /// <summary>
        ///   友情链接
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGameClassLinks> GetAzGameClassLinksList()
        {
            try
            {
                var list = Context.Jw_AzGameClassLinks.ToList();
               
                return list;//list.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_AzGameClassLinks>();
            }
            
           
        }

       

    }
}
