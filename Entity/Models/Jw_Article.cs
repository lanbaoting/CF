//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jw_Article
    {
        public int Id { get; set; }
        public bool IsEnable { get; set; }
        public string CoverMap { get; set; }
        public int ArticleTypeId { get; set; }
        public string ArticleTypeName { get; set; }
        public string ArticleTitle { get; set; }
        public string AuthorName { get; set; }
        public string CompileName { get; set; }
        public string CompileDisplay { get; set; }
        public string SourceName { get; set; }       
        public string SourceDisplay { get; set; }
        public string SourceAddress { get; set; }
        public int? Pageviews { get; set; }
        public int Sort { get; set; }
        public string SeoTile { get; set; }
        public string SeoKey { get; set; }
        public string SeoDesc { get; set; }
        public DateTime F_CreateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
        public string F_ModifyUserName { get; set; }
    }
}
