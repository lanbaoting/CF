using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Cf_NavigationService : BaseService
    {
      
        /// <summary>
        /// 获取一级导航
        /// </summary>
        /// <returns></returns>
        public List<Cf_Navigation> GetNavigationList(int areaId)
        {
            var list = Context.Cf_Navigation.Where(w => w.IsEnable && w.AreaId == areaId).ToList();
            return list;
        }


    }
}
