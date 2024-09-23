using EShop.Models.ProductModels.MainModel;

namespace EShop.Models.ProductModels.TagModel
{
    public class TagModel
    {
        public double Id { get; set; }
        public string description { get; set; }
        public bool IsRemoved { get; set; }
        public List<TagProductModel.TagProductModel> TagProducts { get; set; }

    }
}
