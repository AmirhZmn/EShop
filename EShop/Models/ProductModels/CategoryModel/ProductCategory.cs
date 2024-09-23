using EShop.Models.ProductModels.MainModel;

namespace EShop.Models.ProductModels.CategoryModel
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsRemoved { get; set; }

        public bool IsActivated { get; set; }
        public List<ProductModel> Products { get; set; }
    }
}
