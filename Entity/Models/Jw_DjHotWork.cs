﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public partial class Jw_DjHotWork
    {
        public int Id { get; set; }
        public int DjGameId { get; set; }
        public int Sort { get; set; }
        public Nullable<System.DateTime> F_CreateDate { get; set; }
        public string F_CreateUserId { get; set; }
        public string F_CreateUserName { get; set; }
        public Nullable<System.DateTime> F_ModifyDate { get; set; }
        public string F_ModifyUserId { get; set; }
        public string F_ModifyUserName { get; set; }
    }
}
