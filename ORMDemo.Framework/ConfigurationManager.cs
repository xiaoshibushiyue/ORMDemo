using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ORMDemo.Framework
{
    public class ConfigurationManager
    {
        static ConfigurationManager()
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            IConfigurationRoot configuration = builder.Build();
            _SqlConnectstringCustom = configuration["ConnectionStrings:Customers"];   
        }
        private static string _SqlConnectstringCustom = null;
        public static string SqlConnectionSreingCustom
        {
            get
            {
                return _SqlConnectstringCustom;
            }
        }
    }
}
