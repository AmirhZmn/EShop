using System.ComponentModel.DataAnnotations;

namespace EShop.Models.ProductModels.SaleModel
{
    public class SaleVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        public SaleVM(string name)
        {
            Name = name;
        }
    }
}
