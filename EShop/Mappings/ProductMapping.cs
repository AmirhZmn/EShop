using EShop.Models.ProductModels.MainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<ProductModel>
    {
        public void Configure(EntityTypeBuilder<ProductModel> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x=>x.Name).HasMaxLength(256).IsRequired();
            builder.Property(x => x.ShortDescription).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Count).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.sellRate).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.IsRemoved).HasDefaultValue(false).IsRequired();
            builder.Property(x => x.InStock).HasDefaultValue(true).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.PID).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(X => X.CreatiponDate).IsRequired();


            builder.HasOne(x => x.CategoryName).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Brand).WithMany(x => x.Products).HasForeignKey(x => x.BrandId);




        }
    }
}
