using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGamePicturesService : BaseService
    {
      
        /// <summary>
        ///   游戏截图
        /// </summary>
        /// <returns></returns>
        public List<Jw_AzGamePictures> GetAzGamePictureList(int azGameid)
        {
            try
            {
                var list = Context.Jw_AzGamePictures.Where(w => w.AzGameId == azGameid).ToList();
               
                return list;//list.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_AzGamePictures>();
            }
            
           
        }

       

    }
}
