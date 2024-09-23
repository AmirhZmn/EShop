using System.ComponentModel.DataAnnotations;

namespace EShop.Models.ProductModels.CategoryModel
{
    public class CategoryVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public CategoryVM(string name)
        {
            Name = name;
        }
    }
}
