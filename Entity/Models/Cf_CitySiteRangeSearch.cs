using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public partial class Cf_CitySiteRangeSearch
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int FactoryHouseDictionaryId { get; set; }
        public int ParentId { get; set; }
        public int WebTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Sort { get; set; }
        public bool IsEnable { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKey { get; set; }
        public string SeoDesc { get; set; }
        public Nullable<System.DateTime> F_CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
        public string F_ModifyUserName { get; set; }
    }
}
