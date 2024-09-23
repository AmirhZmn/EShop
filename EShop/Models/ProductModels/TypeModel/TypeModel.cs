using EShop.Models.ProductModels.MainModel;

namespace EShop.Models.ProductModels.TypeModel
{
    public class TypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsRemoved { get; set; } = false;

        public List<ProductModel> Products { get; set; }
    }
}
