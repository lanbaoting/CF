using System;
 
 

namespace Entity.Models
{


    public partial class Jw_DjGameClassTab
    {
        public int Id { get; set; }
        public int DjGameClassId { get; set; }
        public string Title { get; set; }
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
