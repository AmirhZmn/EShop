using EShop.Models.ProductModels.MainModel;

namespace EShop.Models.ProductModels.BrandModel
{
    public class BrandVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BrandVM(string name)
        {
            Name = name;
        }
    }


}
