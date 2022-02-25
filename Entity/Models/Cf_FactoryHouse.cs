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
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<double> HousingRent { get; set; }
        public Nullable<double> HousingArea { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> TransactionModeId { get; set; }
       
        public Nullable<int> StreetId { get; set; }
        public bool IsEnable { get; set; }
        public string HousingtypeId { get; set; }
        public string FloorTypeId { get; set; }
        public string ContactsTypeId { get; set; }
        public string FullAddress { get; set; }
        public string ContactsName { get; set; }
        public string ContactNumber { get; set; }
        public string SourceName { get; set; }
        public string SourceNumber { get; set; }
        public string SourceAddress { get; set; }
        public int Sort { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKey { get; set; }
        public string SeoDesc { get; set; }
        public DateTime F_CreateDate { get; set; }

    }
}
