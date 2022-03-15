
using Project.Entities.Models;
using Project.Map.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext:DbContext
    {

        public MyContext():base("MyConnection")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new GameProfileMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new GoodsMap());
            modelBuilder.Configurations.Add(new GoodsStockMarketMap());
            modelBuilder.Configurations.Add(new ShareStockMarketMap());

        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<GameProfile> GameProfiles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<GoodsStockMarket> GoodsStockMarkets { get; set; }
        public DbSet<ShareStockMarket> ShareStockMarkets { get; set; }
    }
}
