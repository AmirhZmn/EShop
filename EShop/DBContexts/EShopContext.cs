using EShop.Mappings;
using EShop.Models.ProductModels.BrandModel;
using EShop.Models.ProductModels.CategoryModel;
using EShop.Models.ProductModels.MainModel;
using EShop.Models.ProductModels.SaleModel;
using EShop.Models.ProductModels.TagModel;
using EShop.Models.ProductModels.TagProductModel;
using EShop.Models.ProductModels.TypeModel;
using Microsoft.EntityFrameworkCore;

namespace EShop.DBContexts
{
    public class EShopContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<SaleModel> SaleMethod { get; set; }
        public DbSet<TagModel> Tags { get; set; }
        public DbSet<TagProductModel> TagProducts { get; set; }
        public DbSet<TypeModel> Types { get; set; }








        public EShopContext(DbContextOptions<EShopContext>options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var assembly = typeof(ProductMapping).Assembly;
            builder.ApplyConfigurationsFromAssembly(assembly);
        }
    }
}
