using System;


namespace Entity.ViewModels
{
    public class AzGameRelatedGame
    {
        public int Id { get; set; }     
        public int RelatedAzGameId { get; set; }
        public DateTime F_CreateDate { get; set; }
        public string RelatedAzGameName { get; set; }
        public string Edition { get; set; }        
        public int Sort { get; set; }
        public bool IsEnable { get; set; }
   
    }
}
