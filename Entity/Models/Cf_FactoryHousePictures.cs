using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public partial class Cf_FactoryHousePictures
    {
 
        
        public int? Id { get; set; }
       
        public string Title { get; set; }
        
        public int? FactoryHouseId { get; set; }
       
        public string ImgSrc { get; set; }
        
        public string PictureSource { get; set; }
        
        public int? Sort { get; set; }
        
    }
}
