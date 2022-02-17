using System;
 

namespace Entity.ViewModels
{
   public class AzGame
    {      
        public int AzGameId { get; set; }        
        public string AzGameName { get; set; }
        public string AzGameClassName { get; set; }
        public string AzGameClassCode { get; set; }
        public int Size { get; set; }
        public string GameSize { get; set; }
        public string LanguageName { get; set; }
        public string CoverMap { get; set; }
        public int Sort { get; set; }
        public DateTime F_CreateDate { get; set; }

    }
}
