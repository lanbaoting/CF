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
    
    public partial class Jw_DjSectionCore
    {
        public int Id { get; set; }
        public int DjSectionId { get; set; }
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
