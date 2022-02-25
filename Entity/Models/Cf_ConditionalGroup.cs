using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public partial class Cf_ConditionalGroup
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Sort { get; set; }
        public bool IsEnable { get; set; }
        public Nullable<System.DateTime> F_CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
        public string F_ModifyUserName { get; set; }
    }
}
