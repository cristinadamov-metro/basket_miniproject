using Microsoft.EntityFrameworkCore;
using Basket.ArticleDomain;
using Basket.BasketDomain;
using System.Reflection.Metadata;
using Basket.CustomerDomain;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Emit;

namespace Basket
{
    public class BasketContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Basket.BasketDomain.Basket> Baskets { get; set; }
        public DbSet<ArticleLine> ArticleLines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=metro;Username=metro;Password=Metro2018;Port=5434");
    }
}
