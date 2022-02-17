using System;
 

namespace Entity.ViewModels
{
   public class AzGameArticle
    {            
        public int ArticleId { get; set; }
        public int Sort { get; set; }     
        public string ArticleTitle { get; set; }
        public string CoverMap { get; set; }
        public string ArticleTypeName { get; set; }
        public DateTime F_CreateDate { get; set; }

    }
}
