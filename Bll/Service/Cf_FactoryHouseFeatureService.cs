using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace Bll.Service
{
    public class Cf_FactoryHouseFeatureService : BaseService
    {



        /// <summary>       
        ///  通过主键获取文章
        /// </summary>
        /// <returns></returns>
        public List<Cf_FactoryHouseFeature> GetFactoryHouseFeatureList(int factoryHouseId)
        {
            try
            {
                var list = Context.Cf_FactoryHouseFeature.Where(w => w.FactoryHouseId == factoryHouseId).ToList();
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        /// <summary>       
        ///  获取全部文章的分页列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<Jw_Article> GetPageArticleList()
        {
            try
            {
                var list = Context.Jw_Article.Where(w => w.IsEnable);
               
               list = list.OrderByDescending(w => w.F_CreateDate);
               
                
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>       
        ///  获取全部文章的分页列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<Cf_FactoryHouse> GetPageFactoryHouse(string queryString)
        {
            try
            {
                var list = Context.Cf_FactoryHouse.Where(w => w.IsEnable);

                list = list.OrderByDescending(w => w.ReleaseTime);


                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        /// <summary>
        /// 前几条
        /// </summary>
        /// <param name="topCount"></param>
        /// <returns></returns>
        public List<Cf_FactoryHouse> GetFactoryHouseList( int topCount,int transactionModeId)
        {
            try
            {
                var list = Context.Cf_FactoryHouse.Where(w => w.IsEnable && w.TransactionModeId == transactionModeId ).OrderByDescending(s => s.F_CreateDate).Take(topCount).ToList();
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        /// <summary>
        /// 前几条
        /// </summary>
        /// <param name="topCount"></param>
        /// <returns></returns>
        public List<Article> GetArticleByAticleTypeList(int articleTypeId, int topCount)
        {
            try
            {
                var list = Context.Jw_Article.Where(w => w.IsEnable && w.ArticleTypeId == articleTypeId).OrderByDescending(s => s.F_CreateDate).Select(s=> new Article { 
                    ArticleId=s.Id,
                    ArticleTitle = s.ArticleTitle,
                    CoverMap = s.CoverMap,
                    F_CreateDate = s.F_CreateDate,
                    CreateDate = s.CreateDate

                }).Take(topCount).ToList();
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 前几条
        /// </summary>
        /// <param name="topCount"></param>
        /// <returns></returns>
        public List<Jw_Article> GetArticleList(int topCount)
        {
            try
            {
                var list = Context.Jw_Article.Where(w => w.IsEnable).OrderByDescending(o => o.Sort).ThenByDescending(s => s.F_CreateDate).Take(topCount).ToList();
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        /// <summary>       
        ///  下一篇
        /// </summary>
        /// <returns></returns>
        public Jw_Article GetLastArticleById(int articleId)
        {
            try
            {
                var article = Context.Jw_Article.Where(w => w.Id > articleId && w.IsEnable ==true).OrderBy(s=>s.Id).FirstOrDefault();
                return article;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>       
        ///  上一篇
        /// </summary>
        /// <returns></returns>
        public Jw_Article GetNextArticleById(int articleId)
        {
            try
            {
                var article = Context.Jw_Article.Where(w => w.Id < articleId && w.IsEnable == true).OrderByDescending(s => s.Id).FirstOrDefault();
                return article;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
