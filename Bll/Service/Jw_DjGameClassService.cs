using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameClassService : BaseService
    {
      
        /// <summary>
        ///  获取全部单机游戏分类
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjGameClass> GetDjGameClassList()
        {
            try
            {
                var list = Context.Jw_DjGameClass.Where(w=>w.IsEnable).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_DjGameClass>();
            }
            
           
        }


        /// <summary>
        ///  获取单机游戏分类
        /// </summary>
        /// <returns></returns>
        public Jw_DjGameClass GetDjGameClassModelById(int id)
        {
            try
            {
                var model = Context.Jw_DjGameClass.FirstOrDefault(w => w.Id == id && w.IsEnable);
                return model;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        ///  获取单机游戏分类
        /// </summary>
        /// <returns></returns>
        public Jw_DjGameClass GetDjGameClassByCode(string code)
        {
            try
            {
                var model = Context.Jw_DjGameClass.FirstOrDefault(w => w.Code == code && w.IsEnable);
                return model;
            }
            catch (Exception e)
            {
                return null;
            }
        }




    }
}
