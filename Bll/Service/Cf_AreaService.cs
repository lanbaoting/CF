using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Cf_AreaService : BaseService
    {
      
        /// <summary>
        /// 获取一级导航
        /// </summary>
        /// <returns></returns>
        public List<Cf_Area> GetAreaList(int parentId)
        {
            var list = Context.Cf_Area.Where(w => w.IsEnable && w.ParentId == parentId).OrderBy(s => s.SortCode).ToList();
            return list;
        }

        /// <summary>
        /// 获取实体
        /// </summary>
        /// <returns></returns>
        public Cf_Area GetArea(int id)
        {
            var area = Context.Cf_Area.FirstOrDefault(w => w.IsEnable && w.Id == id);
            return area;
        }

    }
}
