using EShop.Models.ProductModels.MainModel;

namespace EShop.Models.ProductModels.TagProductModel
{
    public class TagProductModel
    {
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }

        public double TagId { get; set; }

        public TagModel.TagModel Tag { get; set; }
    }
}
