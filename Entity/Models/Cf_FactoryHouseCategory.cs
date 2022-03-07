using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Cf_FactoryHouseCategory
    {
        #region 实体成员
     
        public int? Id { get; set; }
    
        public int? FactoryHouseId { get; set; }
        
        public int FactoryHouseDictionaryId { get; set; }
     
        public int? Sort { get; set; }
     
        public DateTime? F_CreateDate { get; set; }
    
        #endregion
    }
}
