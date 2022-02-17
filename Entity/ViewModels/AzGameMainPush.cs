using System;


namespace Entity.ViewModels
{
    public class AzGameMainPush
    {
        public int Id { get; set; }     
        public string AzGameName { get; set; }
        public string CoverMap { get; set; }
        public string SeoDesc { get; set; }
        public int AzGameId { get; set; }        
        public int Sort { get; set; }
        public string Edition { get; set; }
        
        public bool IsEnable { get; set; }
   
    }
}
