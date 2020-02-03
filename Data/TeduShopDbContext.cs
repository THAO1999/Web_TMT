using Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Data
{// khai bao cac table
   public class TeduShopDbContext: DbContext // ke thua tu data.Entity
    {
       public TeduShopDbContext() : base("TeduShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<PostCategorie>PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Product> products { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        // chay khi khoi tao entity framework
        protected override void OnModelCreating(DbModelBuilder builder)
        {
        
        }
    }
}
