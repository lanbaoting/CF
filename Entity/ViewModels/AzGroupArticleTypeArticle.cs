using System;
using System.Collections.Generic;

namespace Entity.ViewModels
{
   public class AzGroupArticleTypeArticle
    {

        public int ArticleTypeId { get; set; }
        public string ArticleTypeName { get; set; }
        public string ArticleCode { get; set; }
        public List<Article> ArticleList { get; set; }

    }
}
