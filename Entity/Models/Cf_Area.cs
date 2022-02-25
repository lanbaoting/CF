using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public partial class Cf_Area
    {
        public int Id { get; set; }
        public string AreaId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string QuickQuery { get; set; }
        public string FullPinYin { get; set; }
        public string SimpleSpelling { get; set; }
        public Nullable<int> Layer { get; set; }
        public int SortCode { get; set; }
        public bool IsEnable { get; set; }
        public Nullable<System.DateTime> F_CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
        public string F_ModifyUserName { get; set; }
    }
}
