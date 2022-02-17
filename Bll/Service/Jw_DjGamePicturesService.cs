using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGamePicturesService : BaseService
    {
      
        /// <summary>
        ///   游戏截图
        /// </summary>
        /// <returns></returns>
        public List<Jw_DjGamePictures> GetDjGamePictureList(int djGameid)
        {
            try
            {
                var list = Context.Jw_DjGamePictures.Where(w => w.DjGameId == djGameid).ToList();
               
                return list;//list.ToList();
            }
            catch (Exception e)
            {
                return new List<Jw_DjGamePictures>();
            }
            
           
        }

       

    }
}
