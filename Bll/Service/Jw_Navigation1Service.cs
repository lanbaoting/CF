using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_Navigation1Service : BaseService
    {
      
        /// <summary>
        /// 获取一级导航
        /// </summary>
        /// <returns></returns>
        public List<Jw_Navigation1> GetNavigation1List()
        {
            var list = Context.Jw_Navigation1.Where(w => w.IsEnable).ToList();
            return list;
        }


    }
}
