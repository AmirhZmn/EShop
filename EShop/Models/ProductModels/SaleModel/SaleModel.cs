using EShop.Models.ProductModels.MainModel;

namespace EShop.Models.ProductModels.SaleModel
{
    public class SaleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductModel> Products { get; set; }
    }
}
