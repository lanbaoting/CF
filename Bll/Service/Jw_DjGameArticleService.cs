using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_DjGameArticleService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<DjGameArticle> GetDjGameArticleList(int djGameId,int articleTypeId, int top)
        {
            try
            {
                var djGameArticles = Context.Jw_DjGameArticle.Where(w=>w.DjGameId ==djGameId);
                var articles = Context.Jw_Article.Where(w => w.IsEnable && w.ArticleTypeId == articleTypeId);
                var list = from djGameArticle in djGameArticles
                           join article in articles on djGameArticle.ArticleId equals article.Id
                           select new DjGameArticle
                           {
                               ArticleId= djGameArticle.ArticleId,
                               ArticleTitle = article.ArticleTitle,                               
                               F_CreateDate= article.F_CreateDate
                           };
                return list.OrderBy(o=>o.F_CreateDate).Take(top).ToList();
            }
            catch (Exception e)
            {
                return new List<DjGameArticle>();
            }
            
           
        }

        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public Jw_DjGameArticle GetDjGameArticleByArticleId(int articleId)
        {
            try
            {
                var djGameArticles = Context.Jw_DjGameArticle.FirstOrDefault(w => w.ArticleId == articleId);
                
                return djGameArticles;
            }
            catch (Exception e)
            {
                return null;
            }


        }
    }
}
