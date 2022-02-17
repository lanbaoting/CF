using System;
using System.Collections.Generic;

namespace Entity.ViewModels
{
   public class DjGameClassGame
    {      
        public int DjGameId { get; set; }    
        public int DjGameClassId { get; set; }
        public DateTime F_CreateDate { get; set; }
        public string Name { get; set; }
        public List<DjGame> DjGameGameList { get; set; }


    }
}
