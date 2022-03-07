﻿using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace Bll.Service
{
    public class Cf_FactoryHouseService : BaseService
    {



      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public Cf_FactoryHouse GetFactoryHouse(int articleId)
        {
            try
            {
                var factoryHouse = Context.Cf_FactoryHouse.FirstOrDefault(w =>w.IsEnable && w.Id == articleId);
                factoryHouse = Context.Cf_FactoryHouse.FirstOrDefault(w => w.Id == articleId);
                return factoryHouse;
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
                  list = Context.Cf_FactoryHouse;
                list = list.OrderByDescending(w => w.F_CreateDate);


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
        public List<GroupFactoryHouseDictionaryHouse> GetFactoryHouseCategoryHouseList(List<int> ids, List<int> dictionaryIds ,int topCount)
        {
            try
            {
                
                var factoryHouses = Context.Cf_FactoryHouse.Where(w => w.IsEnable && !ids.Contains(w.Id));
               
                
                List<GroupFactoryHouseDictionaryHouse> data = new List<GroupFactoryHouseDictionaryHouse>();
                foreach (var id in dictionaryIds)
                {
                    var factoryHouseIds = Context.Cf_FactoryHouseCategory.Where(w => w.FactoryHouseDictionaryId == id && !ids.Contains(w.FactoryHouseId.Value)).Take(topCount).Select(s=>s.FactoryHouseId.Value).ToList();
                    var rows = factoryHouses.Where(w => factoryHouseIds.Contains(w.Id)).ToList();                   
                    data.Add(new GroupFactoryHouseDictionaryHouse
                    {
                        FactoryHouseDictionaryId = id,
                        FactoryHouseList = rows
                    });
                     ids.AddRange(factoryHouseIds);
                    factoryHouses = Context.Cf_FactoryHouse.Where(w => w.IsEnable && !ids.Contains(w.Id));
                }

                return data;


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
        public List<GroupFactoryHouseDictionaryHouse> GetFloorTypeFactoryHouseList(IEnumerable<int> ids, IEnumerable<int> dictionaryIds, int topCount)
        {
            try
            {

                var factoryHouses = Context.Cf_FactoryHouse.Where(w => w.IsEnable && !ids.Contains(w.Id));
            
 
                List<GroupFactoryHouseDictionaryHouse> data = new List<GroupFactoryHouseDictionaryHouse>();
                foreach (var id in dictionaryIds)
                {
                    var rows = factoryHouses.Where(w => w.FloorTypeId == id).Take(topCount).ToList();
                    data.Add(new GroupFactoryHouseDictionaryHouse
                    {
                        FactoryHouseDictionaryId = id,
                        FactoryHouseList = rows
                    });
                }


                return data;
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
        public List<Cf_FactoryHouse> GetFactoryHouseList(int topCount, int transactionModeId)
        {
            try
            {
                var list = Context.Cf_FactoryHouse.Where(w=>w.IsEnable ==true && w.TransactionModeId == transactionModeId).OrderByDescending(o=>o.ReleaseTime).Take(topCount);
               
                return list.ToList();
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
