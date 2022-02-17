using System;

namespace Entity.Models
{
 
    public partial class Jw_DjGameClassTabGame
    {
        public int Id { get; set; }
        public int DjGameId { get; set; }
        public int DjGameClassTabId { get; set; }
        public int Sort { get; set; }
        public Nullable<System.DateTime> F_CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
        public string F_ModifyUserName { get; set; }
    }
}
