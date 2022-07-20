using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst.DAL
{

    public class DbContextInitializer
    {
        public static IConfigurationRoot Configuration; //dosyayı okumak için
        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder; // veritabanı ile ilgili onsionları oluşturacağım yer

        //bu dinamik bir yapı

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); //okunacak dosya yolu belirleme

            Configuration = builder.Build();
            OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
        }
    }
}
