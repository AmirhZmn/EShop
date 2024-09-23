using EShop.Models.ProductModels.CategoryModel;


namespace EShop.Models.ProductModels.MainModel
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string PID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Count { get; set; }
        public int sellRate { get; set; }
        public DateTime CreatiponDate { get; set; }
        public bool InStock { get; set; }
        public bool IsRemoved { get; set; }

        public int CategoryId { get; set; }
        public ProductCategory CategoryName { get; set; }

        public int BrandId { get; set; }
        public BrandModel.BrandModel Brand { get; set; }

        public int SaleId { get; set; }
        public SaleModel.SaleModel SaleMethod { get; set; }

        public int TypeId { get; set; }
        public TypeModel.TypeModel Type { get; set; }

        public List<TagProductModel.TagProductModel> TagProducts { get; set; }

    }
}
