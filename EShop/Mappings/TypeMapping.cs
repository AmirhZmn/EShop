using EShop.Models.ProductModels.BrandModel;
using EShop.Models.ProductModels.TypeModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EShop.Mappings
{
    public class TypeMapping : IEntityTypeConfiguration<TypeModel>
    {
        public void Configure(EntityTypeBuilder<TypeModel> builder)
        {
            builder.ToTable("Types");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.Property(x => x.IsRemoved).HasDefaultValue(false);
          



            builder.HasMany(x => x.Products).WithOne(x => x.Type).HasForeignKey(x => x.TypeId);
        }
    }
}
