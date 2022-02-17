using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
   public class  DjSectionAsideGame
    {
        public int? Id { get; set; }     
        public int DjGameId { get; set; }    
        public int DjSectionAsideId { get; set; }   
        public int Sort { get; set; } 
        public string Name { get; set; }
        public DateTime F_CreateDate { get; set; }

    }
}
