using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Cf_FactoryHouseCategoryService : BaseService
    {
      
        /// <summary>
        /// 获取一级导航
        /// </summary>
        /// <returns></returns>
        public List<Cf_FactoryHouseCategory> GetFactoryHouseCategoryList(int factoryHouseId)
        {
            var list = Context.Cf_FactoryHouseCategory.Where(w => w.FactoryHouseId== factoryHouseId).ToList();
            return list;
        }

        

    }
}
