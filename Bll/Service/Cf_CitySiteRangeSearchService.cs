using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Cf_CitySiteRangeSearchService : BaseService
    {
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="areaId">区域id</param>
        /// <param name="webTypeId">页面类型</param>
        /// <returns></returns>
        public List<Cf_CitySiteRangeSearch> GetCitySiteRangeSearchList(int areaId,int webTypeId)
        {
            var list = Context.Cf_CitySiteRangeSearch.Where(w => w.IsEnable && w.AreaId == areaId && w.WebTypeId == webTypeId).OrderBy(s => s.Sort).ToList();
            return list;
        }


 



        /// <summary>
        /// 
        /// </summary>
        /// <param name="areaId">区域id</param>
        /// <param name="webTypeId">页面类型</param>
        /// <returns></returns>
        public int  GetCitySiteRangeSearchCount(int areaId, int webTypeId,int parentId)
        {
            int count = Context.Cf_CitySiteRangeSearch.Where(w => w.IsEnable && w.AreaId == areaId && w.WebTypeId == webTypeId && w.ParentId == parentId).Count();
            return count;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="areaId">区域id</param>
        /// <param name="webTypeId">页面类型</param>
        /// <returns></returns>
        public List<Cf_CitySiteRangeSearch> GetCitySiteRangeSearchList(int areaId, int webTypeId, int parentId)
        {
            var list = Context.Cf_CitySiteRangeSearch.Where(w => w.IsEnable && w.AreaId == areaId && w.WebTypeId == webTypeId && w.ParentId == parentId).OrderBy(s => s.Sort).ToList();
            return list;
        }

    }
}
