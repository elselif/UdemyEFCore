using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEFCore.DatabaseFirst.DAL
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; }


        public AppDbContext()
        {

        }

        //parametre alınan bir constructorda yukardaki defaul constructor da tanımlanmalı

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        
    }
}
