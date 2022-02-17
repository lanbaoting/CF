using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_AzGameArticleService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<AzGameArticle> GetAzGameArticleList(int azGameId, int articleTypeId, int top)
        {
            try
            {
                var djGameArticles = Context.Jw_AzGameArticle.Where(w=>w.AzGameId == azGameId);
                var articles = Context.Jw_Article.Where(w => w.IsEnable && w.ArticleTypeId == articleTypeId);
                var list = from djGameArticle in djGameArticles
                           join article in articles on djGameArticle.ArticleId equals article.Id
                           select new AzGameArticle
                           {
                               ArticleId= djGameArticle.ArticleId,
                               ArticleTitle = article.ArticleTitle,                               
                               F_CreateDate= article.F_CreateDate,
                               ArticleTypeName = article.ArticleTypeName,
                           };
                return list.OrderBy(o=>o.F_CreateDate).Take(top).ToList();
            }
            catch (Exception e)
            {
                return new List<AzGameArticle>();
            }                       
        }


        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<AzGameArticle> GetAzGameArticleList(int azGameId, int top)
        {
            try
            {
                var djGameArticles = Context.Jw_AzGameArticle.Where(w => w.AzGameId == azGameId);
                var articles = Context.Jw_Article.Where(w => w.IsEnable);
                var list = from djGameArticle in djGameArticles
                           join article in articles on djGameArticle.ArticleId equals article.Id
                           select new AzGameArticle
                           {
                               ArticleId = djGameArticle.ArticleId,
                               ArticleTitle = article.ArticleTitle,
                               F_CreateDate = article.F_CreateDate,
                               CoverMap = article.CoverMap
                           };
                return list.OrderBy(o => o.F_CreateDate).Take(top).ToList();
            }
            catch (Exception e)
            {
                return new List<AzGameArticle>();
            }
        }


        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public Jw_AzGameArticle GetAzGameArticleByArticleId(int articleId)
        {
            try
            {
                var djGameArticles = Context.Jw_AzGameArticle.FirstOrDefault(w => w.ArticleId == articleId);
                
                return djGameArticles;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<AzGroupArticleTypeArticle> GetAzGroupArticleTypeArticleList(int azGameId)
        {
            try
            {
                var azGameArticles = Context.Jw_AzGameArticle.Where(w => w.AzGameId == azGameId);
                var aticles = Context.Jw_Article.Where(w => w.IsEnable);
                var list = from azGameArticle in azGameArticles
                           join aticle in aticles on azGameArticle.ArticleId equals aticle.Id
                           select aticle;

 

                List<AzGroupArticleTypeArticle> data = list.AsEnumerable().GroupBy(g => g.ArticleTypeId).Select(
                    s => new AzGroupArticleTypeArticle
                    {
                        ArticleTypeId = s.Key,
                        ArticleList = s.Select(a => new Article {
                        ArticleId = a.Id,
                        ArticleTitle =a.ArticleTitle,
                        CoverMap= a.CoverMap,
                        CreateDate=a.CreateDate,
                        F_CreateDate=a.F_CreateDate                        
                        }).OrderByDescending(o=>o.CreateDate).Take(20).ToList()
                    }

                    ).ToList();

                var articleTypeIds = data.Select(s=>s.ArticleTypeId);

                var articleTypeList = Context.Jw_ArticleType.Where(w => w.IsEnable && articleTypeIds.Contains(w.Id));


                foreach (var m in data) {

                    var t = articleTypeList.FirstOrDefault(w => w.Id == m.ArticleTypeId);
                    if (t != null) 
                    {
                        m.ArticleTypeId = t.Id;
                        m.ArticleTypeName = t.Name;
                        m.ArticleCode = t.Code;
                    }

                }


                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }





    }
}
