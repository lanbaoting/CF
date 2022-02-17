using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace Bll.Service
{
    public class Jw_ArticleDetailsService : BaseService
    {
      
 
        /// <summary>       
        ///  通过主键获取文章明细
        /// </summary>
        /// <returns></returns>
        public Jw_ArtileDetails GetDjArticleById(int articleId)
        {
            try
            {
                var articleDtails = Context.Jw_ArtileDetails.FirstOrDefault(w => w.ArticleId == articleId);
                return articleDtails;
            }
            catch (Exception e)
            {
                return null;
            } 
        }




     

    }
}
