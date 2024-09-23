using EShop.Models.ProductModels.BrandModel;
using EShop.Models.ProductModels.SaleModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EShop.Mappings
{
    public class SaleMapping : IEntityTypeConfiguration<SaleModel>
    {
        public void Configure(EntityTypeBuilder<SaleModel> builder)
        {
            builder.ToTable("SaleMethod");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(256);
          



            builder.HasMany(x => x.Products).WithOne(x => x.SaleMethod).HasForeignKey(x => x.SaleId);
        }
    }
}


