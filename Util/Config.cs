using Microsoft.Extensions.Configuration;
using System.IO;
namespace Util
{
    /// <summary>
    /// 配置文件
    /// </summary>
    public class Config
    {
        #region 根据Key取Value值
        /// <summary>
        /// 根据Key取Value值
        /// </summary>
        /// <param name="key"></param>
        public static string GetValue(string key)
        {
            var configJson = GetJsonConfig();
            return configJson[key];
        }
        #endregion

        #region json配置文件读取
        /// <summary>
        /// json配置文件读取
        /// </summary>
        /// <param name="configFileName"></param>
        /// <param name="basePath"></param>
        /// <returns></returns>
        public static IConfigurationRoot GetJsonConfig(string configFileName = "appsettings.json", string basePath = "")
        {
            basePath = string.IsNullOrWhiteSpace(basePath) ? Directory.GetCurrentDirectory() : basePath;
            var builder = new ConfigurationBuilder().SetBasePath(basePath).AddJsonFile(configFileName);
            return builder.Build();
        }

      
        #endregion
    }
}
