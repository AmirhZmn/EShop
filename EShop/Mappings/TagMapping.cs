using EShop.Models.ProductModels.BrandModel;
using EShop.Models.ProductModels.TagModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EShop.Mappings
{
    public class TagMapping : IEntityTypeConfiguration<TagModel>
    {
        public void Configure(EntityTypeBuilder<TagModel> builder)
        {
            builder.ToTable("Tags");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.description).HasMaxLength(256);
            builder.Property(x => x.IsRemoved).HasDefaultValue(false);

        }
    }
}
