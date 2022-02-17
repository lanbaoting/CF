 
namespace Entity.Models
{
    using System;
 
    
    public partial class Jw_MapControllerRoute
    {
        public int Id { get; set; }
        public string RouteDescription { get; set; }
        public string Name { get; set; }
        public string Pattern { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
       
    }
}
