using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameClassTabService : BaseService
    {
      
        /// <summary>
        ///  获取游戏分类的标签
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjGameClassTab> GetDjGameClassTabListByClassId(int gameClassId)
        {
            try
            {
                var djSectionAsides= Context.Jw_DjGameClassTab.Where(w=>w.DjGameClassId == gameClassId && w.IsEnable);               
                return djSectionAsides.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_DjGameClassTab>();
            }
            
           
        }


    }
}
