using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_Navigation2Service : BaseService
    {
      
        /// <summary>
        /// 通过一级导航获取二级导航
        /// </summary>
        /// <returns></returns>
        public List<Jw_Navigation2> GetNavigation2ByNavigation1IdList(int navigation1Id)
        {
            try
            {
                var list = Context.Jw_Navigation2.Where(w=>w.Navigation1Id == navigation1Id).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_Navigation2>();
            }
            
           
        }


    }
}
