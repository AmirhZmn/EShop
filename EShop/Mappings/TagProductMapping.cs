using EShop.Models.ProductModels.TagProductModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Mappings
{
    public class TagProductMapping : IEntityTypeConfiguration<TagProductModel>
    {
        public void Configure(EntityTypeBuilder<TagProductModel> builder)
        {
            builder.ToTable("TagProducts");
            builder.HasKey(x => new { x.ProductId, x.TagId });

            builder.HasOne(x => x.Product).WithMany(x => x.TagProducts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Tag).WithMany(x => x.TagProducts).HasForeignKey(x => x.TagId);

        }
    }
}
