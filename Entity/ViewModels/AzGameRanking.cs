namespace Entity.ViewModels
{
    public class AzGameRanking
    {
        public int? Id { get; set; }     
        public int AzGameId { get; set; }            
        public string AzGameClassCode { get; set; }
        public int Sort { get; set; }

        public int Praise { get; set; }
        public int BadEvaluation { get; set; }

        public string AzGameName { get; set; }
        public string AzGameClassName { get; set; }
        public string CoverMap { get; set; }
      
   
    }
}
