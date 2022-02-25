using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public partial class Cf_Navigation
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public Nullable<int> ParentNavigationId { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string LinkAddress { get; set; }
        public int Sort { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKey { get; set; }
        public string SeoDesc { get; set; }
        public bool IsEnable { get; set; }
      
    }
}
