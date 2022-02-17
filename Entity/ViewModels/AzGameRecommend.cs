namespace Entity.ViewModels
{
    public class AzGameRecommend
    {
        public int? Id { get; set; }     
        public int AzGameId { get; set; }    
        public int AzGameClassId { get; set; }   
        public int Sort { get; set; } 
        public string AzGameName { get; set; }         
        public string AzGameClassName { get; set; }

        public string GameSize { get; set; }

        public int Praise { get; set; }
        public int BadEvaluation { get; set; }
        public string Edition { get; set; }

        public string AzGameClassCode { get; set; }
        
        public string CoverMap { get; set; }
    }
}
