using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameTopicsService : BaseService
    {

        /// <summary>       
        ///  获取全部单机游戏专题的分页列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<Jw_DjGameTopics> GetDjGameTopicsList()
        {
            try
            {
                var list = Context.Jw_DjGameTopics.Where(w => w.IsEnable);

                list = list.OrderByDescending(w => w.F_CreateDate);


                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }

       
    }
}
