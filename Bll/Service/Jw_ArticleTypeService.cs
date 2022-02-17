using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_ArticleTypeService : BaseService
    {
      
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<Jw_ArticleType> GetArticleTypeList()
        {
            try
            {
                var list = Context.Jw_ArticleType.Where(w=>w.IsEnable).ToList();
                return list;
            }
            catch (Exception e)
            {
                return new List<Jw_ArticleType>();
            }
            
           
        }

        /// <summary>       
        ///  通过主键获取文章类别
        /// </summary>
        /// <returns></returns>
        public Jw_ArticleType GetArticleTypeById(int id)
        {
            try
            {
                var articleType = Context.Jw_ArticleType.FirstOrDefault(w => w.IsEnable && w.Id == id);
                return articleType;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>       
        ///  通过编号获取文章类别
        /// </summary>
        /// <returns></returns>
        public Jw_ArticleType GetArticleTypeByCode(string code)
        {
            try
            {
                var articleType = Context.Jw_ArticleType.FirstOrDefault(w => w.IsEnable && w.Code == code);
                return articleType;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
