using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
 
    public partial class Lg_UserVisitLog
    {
        [Key]
        public string Id { get; set; }
        public string Ip { get; set; }
        public Nullable<bool> HasFormContentType { get; set; }
        public string Host { get; set; }
        public string Method { get; set; }
        public string Path { get; set; }
        public string Protocol { get; set; }
        public string Scheme { get; set; }
        public string QueryString { get; set; }
        public string Accept { get; set; }
        public string AcceptEncoding { get; set; }
        public string AcceptLanguage { get; set; }
        public string Connection { get; set; }
        public string Cookie { get; set; }
        public string UserAgent { get; set; }
        public string UpgradeInsecureRequests { get; set; }
        public Nullable<System.DateTime> ExcuteEndTime { get; set; }
        public Nullable<System.DateTime> ExcuteStartTime { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public string Website { get; set; }
        
    }
}
