using EShop.DBContexts;
using Microsoft.AspNetCore.Mvc;


namespace EShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeProductsController : ControllerBase
    {
        private readonly EShopContext _context;

        public HomeProductsController(EShopContext context)
        {
            _context = context;
        }

        [HttpGet("ReSales")]
        public async Task<IActionResult> GetKhordeh()
        {
           
                var products = _context.Products
                    .Where(x => x.SaleId == 3)
                    
                    .Select(p => new{p.Id,p.Name,p.Price,p.ShortDescription,p.CreatiponDate})
                    .OrderBy(x=>x.CreatiponDate)
                    .Take(8)
                    .ToList();

                return Ok(products);
            

        }
        [HttpGet("ReSales/pic/{id}/")]
        public async Task<IActionResult> GetKhordehpic(double id)
        {

            var data = _context.Products.Where(x => x.Id == id).Select(x=>x.Image).ToList();

            if (data.FirstOrDefault() != null)
            {
                Byte[] b = System.IO.File.ReadAllBytes(@data.FirstOrDefault());   // You can use your own method over here.         
                return File(b, "image/jpeg");
               
            }
            return NotFound("Image Not Found");
        }

        [HttpGet("WhSales")]
        public async Task<IActionResult> GetOmdeh()
        {

            var products = _context.Products
                .Where(x => x.SaleId == 1)

                .Select(p => new { p.Id, p.Name, p.Price, p.ShortDescription, p.CreatiponDate })
                .OrderBy(x => x.CreatiponDate)
                .Take(8)
                .ToList();

            return Ok(products);


        }
        [HttpGet("WhSales/pic/{id}/")]
        public async Task<IActionResult> GetOmdehpic(double id)
        {

            var data = _context.Products.Where(x => x.Id == id).Select(x => x.Image).ToList();

            if (data.FirstOrDefault() != null)
            {
                Byte[] b = System.IO.File.ReadAllBytes(@data.FirstOrDefault());   // You can use your own method over here.         
                return File(b, "image/jpeg");

            }
            return NotFound("Image Not Found");
        }
    }
}
