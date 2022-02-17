using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bll.Service
{
    public class Jw_HotGraphicsService : BaseService
    {

        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public List<HotGraphics> GeHotGraphicsList()
        {
            try
            {
                var hotGraphics = Context.Jw_HotGraphics;
                var articles = Context.Jw_Article.Where(w => w.IsEnable);
                var list = from hotGraphic in hotGraphics
                           join article in articles on hotGraphic.ArticleId equals article.Id
                           select new HotGraphics
                           {
                               ArticleId = article.Id,
                               Sort = hotGraphic.Sort,
                               ArticleTitle = article.ArticleTitle,
                               CoverMap = article.CoverMap,
                               F_CreateDate = article.F_CreateDate,
                               SeoDesc = article.SeoDesc
                           };

                return list.OrderBy(o => o.Sort).ToList();
            }
            catch (Exception e)
            {
                return new List<HotGraphics>();
            }


        }

    }
}
