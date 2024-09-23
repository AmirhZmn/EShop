using EShop.Models.ProductModels.CategoryModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Mappings
{
    public class ProductCategoryMapping:IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
            builder.Property(x => x.IsRemoved).HasDefaultValue(false);
            builder.Property(x => x.IsActivated).HasDefaultValue(true);



            builder.HasMany(x => x.Products).WithOne(x => x.CategoryName).HasForeignKey(x => x.CategoryId);
        }
    }
}
