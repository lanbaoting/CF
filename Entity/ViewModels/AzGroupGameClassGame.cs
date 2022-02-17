using System;
using System.Collections.Generic;

namespace Entity.ViewModels
{
   public class AzGroupGameClassGame
    {

        public int AzGameClassId { get; set; }
        public string AzGameClassName { get; set; }
        public string AzGameClassCode { get; set; }
        public List<AzGame> AzGameList { get; set; }

    }
}
