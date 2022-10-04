using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RabbitMqProductAPI.Models;

namespace RabbitMqProductAPI.Context
{
    public class DbContextProduct: DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextProduct(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet <Product> Products { get; set; }

    }
}

