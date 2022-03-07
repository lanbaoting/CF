using Entity.Models;
using System;
using System.Collections.Generic;
 

namespace Entity.ViewModels
{
 


    public partial class FactoryHouseDictionary
    {
        
        public int? FactoryHouseDictionaryId { get; set; }
        public int? FactoryHouseDictionarySort { get; set; }
        public string FactoryHouseDictionaryName { get; set; }  
 


    }

    public partial class FactoryHouseDictionaryHouse : FactoryHouseDictionary
    {
 

        public Cf_FactoryHouse FactoryHouse { get; set; }
    }

    public partial class GroupDictionaryHouse : FactoryHouseDictionary
    {


        public List<Cf_FactoryHouse> FactoryHouseList { get; set; }


    }

    public partial class GroupFactoryHouseDictionaryHouse : FactoryHouseDictionary
    {


        public List<Cf_FactoryHouse> FactoryHouseList { get; set; }


    }

 

}
