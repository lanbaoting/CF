using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
   public class  DjSectionCoreItemGame
    {
       
        public int DjGameId { get; set; }    
        public int DjSectionCoreItemId { get; set; }   
        public int Sort { get; set; } 
        public string Name { get; set; }
        public string LanguageName { get; set; }
        public string CoverMap { get; set; }
        public int Size { get; set; }

    }
}
