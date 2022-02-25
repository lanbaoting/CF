using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Cf_ConditionalGroupService : BaseService
    {
      
        /// <summary>
        /// 获取一级导航
        /// </summary>
        /// <returns></returns>
        public List<Cf_ConditionalGroup> GetConditionalGroupList(int areaId)
        {
            var list = Context.Cf_ConditionalGroup.Where(w => w.IsEnable && w.AreaId == areaId).OrderBy(s=>s.Sort).ToList();
            return list;
        }


    }
}
