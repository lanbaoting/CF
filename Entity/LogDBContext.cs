using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
 

namespace Entity
{

    public class LogDBContext : DbContext
    {


        private readonly string _connectionString;

        public LogDBContext()
        {

        IConfiguration _configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        _connectionString = _configuration["ConnectionStrings:LogDbConnection"];
        }


 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Lg_UserVisitLog> Lg_UserVisitLog { get; set; }
    }
}
