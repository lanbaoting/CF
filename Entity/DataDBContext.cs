using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Entity
{
    
    public class DataDBContext : DbContext
    {
        private readonly string _connectionString;

        public DataDBContext()
        {
            IConfiguration _configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            _connectionString = _configuration["ConnectionStrings:DbConnection"];
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Jw_Article> Jw_Article { get; set; }
        public virtual DbSet<Jw_ArticleType> Jw_ArticleType { get; set; }
        public virtual DbSet<Jw_ArtileDetails> Jw_ArtileDetails { get; set; }
        public virtual DbSet<Jw_DjGame> Jw_DjGame { get; set; }
        public virtual DbSet<Jw_DjGameArticle> Jw_DjGameArticle { get; set; }
        public virtual DbSet<Jw_DjGameClass> Jw_DjGameClass { get; set; }
        public virtual DbSet<Jw_DjGameDetails> Jw_DjGameDetails { get; set; }
        public virtual DbSet<Jw_DjGamePictures> Jw_DjGamePictures { get; set; }
        public virtual DbSet<Jw_DjGameQuickSearch> Jw_DjGameQuickSearch { get; set; }
        public virtual DbSet<Jw_DjGameRanking> Jw_DjGameRanking { get; set; }
        public virtual DbSet<Jw_DjGameRecommend> Jw_DjGameRecommend { get; set; }
        public virtual DbSet<Jw_DjGameType> Jw_DjGameType { get; set; }
        public virtual DbSet<Jw_DjGameTypeGame> Jw_DjGameTypeGame { get; set; }
        public virtual DbSet<Jw_DjGameVideo> Jw_DjGameVideo { get; set; }
        public virtual DbSet<Jw_DjSection> Jw_DjSection { get; set; }
        public virtual DbSet<Jw_DjSectionAside> Jw_DjSectionAside { get; set; }
        public virtual DbSet<Jw_DjSectionAsideGame> Jw_DjSectionAsideGame { get; set; }
        public virtual DbSet<Jw_DjSectionCore> Jw_DjSectionCore { get; set; }
        public virtual DbSet<Jw_DjSectionCoreItem> Jw_DjSectionCoreItem { get; set; }
        public virtual DbSet<Jw_DjSectionCoreItemGame> Jw_DjSectionCoreItemGame { get; set; }
        public virtual DbSet<Jw_GameLanguage> Jw_GameLanguage { get; set; }
        public virtual DbSet<Jw_Navigation1> Jw_Navigation1 { get; set; }
        public virtual DbSet<Jw_Navigation1Banner> Jw_Navigation1Banner { get; set; }
        public virtual DbSet<Jw_Navigation1Links> Jw_Navigation1Links { get; set; }
        public virtual DbSet<Jw_Navigation1Logo> Jw_Navigation1Log { get; set; }
        public virtual DbSet<Jw_Navigation2> Jw_Navigation2 { get; set; }
        public virtual DbSet<Jw_DjBoutiqueGame> Jw_DjBoutiqueGame { get; set; }
        public virtual DbSet<Jw_DjGameClassTab> Jw_DjGameClassTab { get; set; }
        public virtual DbSet<Jw_DjGameClassTabGame> Jw_DjGameClassTabGame { get; set; }
        public virtual DbSet<Jw_DjHotWork> Jw_DjHotWork { get; set; }
        public virtual DbSet<Jw_HotGraphics> Jw_HotGraphics { get; set; }
        public virtual DbSet<Jw_MapControllerRoute> Jw_MapControllerRoute { get; set; }
        public virtual DbSet<Jw_DjGameTopics> Jw_DjGameTopics { get; set; }
        public virtual DbSet<Jw_DjGameTopicsNavigation> Jw_DjGameTopicsNavigation { get; set; }
        public virtual DbSet<Jw_TopicType> Jw_TopicType { get; set; }
        public virtual DbSet<Jw_AzGameClass> Jw_AzGameClass { get; set; }
        public virtual DbSet<Jw_AzGameType> Jw_AzGameType { get; set; }
        public virtual DbSet<Jw_AzGameTypeGame> Jw_AzGameTypeGame { get; set; }
        public virtual DbSet<Jw_AzGame> Jw_AzGame { get; set; }
        public virtual DbSet<Jw_AzGameDetails> Jw_AzGameDetails { get; set; }
        public virtual DbSet<Jw_AzGamePictures> Jw_AzGamePictures { get; set; }
        public virtual DbSet<Jw_AzGameVideo> Jw_AzGameVideo { get; set; }
        public virtual DbSet<Jw_AzGameArticle> Jw_AzGameArticle { get; set; }
        public virtual DbSet<Jw_AzGameClassLinks> Jw_AzGameClassLinks { get; set; }
        public virtual DbSet<Jw_AzGameRanking> Jw_AzGameRanking { get; set; }
        public virtual DbSet<Jw_AzGameRecommend> Jw_AzGameRecommend { get; set; }
        public virtual DbSet<Jw_AzGameRotation> Jw_AzGameRotation { get; set; }
        public virtual DbSet<Jw_AzGameRotationRight> Jw_AzGameRotationRight { get; set; }
        public virtual DbSet<Jw_AzGameMainPush> Jw_AzGameMainPush { get; set; }
        public virtual DbSet<Jw_AzGameRelatedGame> Jw_AzGameRelatedGame { get; set; }


        public virtual DbSet<Cf_Navigation> Cf_Navigation { get; set; }
        public virtual DbSet<Cf_FactoryHouse> Cf_FactoryHouse { get; set; }
        public virtual DbSet<Cf_CitySiteRangeSearch> Cf_CitySiteRangeSearch { get; set; }
        public virtual DbSet<Cf_Area> Cf_Area { get; set; }
        public virtual DbSet<Cf_FactoryHouseDictionary> Cf_FactoryHouseDictionary { get; set; }
        public virtual DbSet<Cf_FactoryHouseDetials> Cf_FactoryHouseDetials { get; set; }
        public virtual DbSet<Cf_FactoryHouseFeature> Cf_FactoryHouseFeature { get; set; }
        public virtual DbSet<Cf_FactoryHousePictures> Cf_FactoryHousePictures { get; set; }
        public virtual DbSet<Cf_FactoryHouseCategory> Cf_FactoryHouseCategory { get; set; }
        public virtual DbSet<Cf_FactoryHouseIndustry> Cf_FactoryHouseIndustry { get; set; }

        public virtual DbSet<Cf_StorageHouse> Cf_StorageHouse { get; set; }
        public virtual DbSet<Cf_StorageHouseDetails> Cf_StorageHouseDetails { get; set; }
    }
}
