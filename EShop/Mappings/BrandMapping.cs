using EShop.Models.ProductModels.BrandModel;
using EShop.Models.ProductModels.CategoryModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Mappings
{
    public class BrandMapping:IEntityTypeConfiguration<BrandModel>
    {
        public void Configure(EntityTypeBuilder<BrandModel> builder)
        {
            builder.ToTable("Brands");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.Property(x => x.IsRemoved).HasDefaultValue(false);
            builder.Property(x => x.IsActivated).HasDefaultValue(true);



            builder.HasMany(x => x.Products).WithOne(x => x.Brand).HasForeignKey(x => x.BrandId);
        }
    }
}
