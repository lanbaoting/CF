using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameClassService : BaseService
    {
      
        /// <summary>
        ///  获取安卓全部游戏分类
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGameClass> GetAzGameClassList(int topCout)
        {
            try
            {
                var list = Context.Jw_AzGameClass.Where(w=>w.IsEnable).OrderBy(s => s.Sort).Take(topCout).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_AzGameClass>();
            }
            
           
        }
        /// <summary>
        ///  获取安卓全部游戏分类
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGameClass> GetAzGameClassList()
        {
            try
            {
                var list = Context.Jw_AzGameClass.Where(w => w.IsEnable).OrderBy(s=>s.Sort).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_AzGameClass>();
            }


        }


        /// <summary>
        ///  获取安卓游戏分类
        /// </summary>
        /// <returns></returns>
        public Jw_AzGameClass GetAzGameClassModelById(int id)
        {
            try
            {
                var model = Context.Jw_AzGameClass.FirstOrDefault(w => w.Id == id && w.IsEnable);
                return model;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        ///  获取安卓游戏分类
        /// </summary>
        /// <returns></returns>
        public Jw_AzGameClass GetAzGameClassByCode(string code)
        {
            try
            {
                var model = Context.Jw_AzGameClass.FirstOrDefault(w => w.Code == code && w.IsEnable);
                return model;
            }
            catch (Exception e)
            {
                return null;
            }
        }




    }
}
