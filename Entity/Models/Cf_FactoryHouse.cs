using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public partial class Cf_FactoryHouse
    {

        public int Id { get; set; }
        public string CoverMap { get; set; }
 
        public string HousingName { get; set; }
      
        public string EnterpriseName { get; set; }
     
        public double? UnitPrice { get; set; }

        public int? Pageviews { get; set; }
        
        public double? HousingRent { get; set; }
 
        public double? HousingArea { get; set; }
   
        public int? ProvinceId { get; set; }
     
        public int? CityId { get; set; }

        public string CityName { get; set; }
    
        public int? DistrictId { get; set; }

        public string DistrictName { get; set; }
     
        public int? StreetId { get; set; }

        public string StreetName { get; set; }
    
        public string FullAddress { get; set; }
  
        public string ContactsName { get; set; }
   
        public string ContactNumber { get; set; }
 
        public int? ContactsTypeId { get; set; }

    
        public int? HousingtypeId { get; set; }


        public string HousingtypeName { get; set; }

        public string HousingStructureName { get; set; }

        public string FloorTypeName { get; set; }

        public string ContactsTypeName { get; set; }
        public int? HousingStructureId { get; set; }


        public string CategoryList { get; set; }

        public string FeatureList { get; set; }
        public string IndustryList { get; set; }
        public int? FloorTypeId { get; set; }       
        public string SourceName { get; set; }
 
        public bool IsEnable { get; set; }
 
        public string SourceNumber { get; set; }
    
        public string SourceAddress { get; set; }
  
        public int? Sort { get; set; }
 
        public string SeoTitle { get; set; }
  
        public string SeoKey { get; set; }
 
        public string SeoDesc { get; set; }
 
        public string SdPageId { get; set; }
       
        public int? TransactionModeId { get; set; }
    
        public DateTime? ReleaseTime { get; set; }
        public DateTime? F_CreateDate { get; set; }

    }
}
