using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.CodeFirst
{
    public class Initializer
    {
        public static IConfigurationRoot Configuration; // wep projelerinde bu configuration hazır gelir ama bu proje console projesi olduğu için biz oluşturduk



        public static void Build() // bu metod ile app json dosyasını okuancak hale getirdik
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();    
        }


    }
}
