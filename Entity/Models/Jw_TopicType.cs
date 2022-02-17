using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Jw_TopicType
    {
        public int Id { get; set; }
        public bool IsEnable { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Sort { get; set; }
        public string SeoTile { get; set; }
        public string SeoKey { get; set; }
        public string SeoDesc { get; set; }
        public Nullable<System.DateTime> F_CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
    }
}
