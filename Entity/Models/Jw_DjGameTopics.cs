using System;
using System.Collections.Generic;

namespace Entity.Models
{
 
    
    public partial class Jw_DjGameTopics
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsEnable { get; set; }
        public string Code { get; set; }
        public string CoverMap { get; set; }
        public int DjGameId { get; set; }
        public int TopicTypeId { get; set; }
        public string SeoTile { get; set; }
        public string SeoKey { get; set; }
        public string SeoDesc { get; set; }
        public DateTime F_CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
    }
}
