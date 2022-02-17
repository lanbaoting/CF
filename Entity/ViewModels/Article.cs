using System;
 

namespace Entity.ViewModels
{
   public class Article
    {            
        public int ArticleId { get; set; }
        public int Sort { get; set; }     
        public string ArticleTitle { get; set; }
        public string CoverMap { get; set; }
        public DateTime F_CreateDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
