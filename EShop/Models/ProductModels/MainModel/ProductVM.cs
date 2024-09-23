using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Models.ProductModels.MainModel
{
    public class ProductVM
    {
        [Required]
        public int Id { get; set; }
        [Required] public string? PID { get; set; }

        [Required]
        [MaxLength(256, ErrorMessage = "Invalid Number Of Characters")]
        public string? Name { get; set; }

        [Required] public double Price { get; set; }

        [Required]
        [MaxLength(256, ErrorMessage = "Invalid Number Of Characters")]
        public string? ShortDescription { get; set; }


        [Required] public string? Description { get; set; }
        [Required] public IFormFile? Image { get; set; }
        [Required] public int Count { get; set; }

        [Required] public bool InStock { get; set; }

        [Required] public int BrandId { get; set; }

        [Required] public int CategoryId { get; set; }

        [Required] public int SaleId { get; set; }

        [Required] public int TypeId { get; set; }
    }
}