using EShop.DBContexts;
using EShop.Models.ProductModels.BrandModel;
using EShop.Models.ProductModels.CategoryModel;
using EShop.Models.ProductModels.MainModel;
using EShop.Models.ProductModels.SaleModel;
using EShop.Models.ProductModels.TypeModel;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminPanelController : ControllerBase
    {
        private readonly EShopContext _dbContext;
        private readonly IWebHostEnvironment _environment;


        public AdminPanelController(EShopContext dbContext, IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        [HttpGet("CreateProduc")]
        public async Task<IActionResult> EssentialInfo()
        {

            var brands = _dbContext.Brands.Where(x => (x.IsActivated == true && x.IsRemoved == false))
                .Select(x => new { x.Id, x.Name }).ToList();

            var categories = _dbContext.ProductCategory.Where(x => (x.IsActivated == true && x.IsRemoved == false))
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                }).ToList();
            var saleMethods = _dbContext.SaleMethod.Select(x => new { x.Name, x.Id }).ToList();
            var types = _dbContext.Types.Where(x => x.IsRemoved == false).Select(x => new { x.Id, x.Name }).ToList();
            var tags = _dbContext.Tags.Where(x => x.IsRemoved == false).Select(x => new { x.Id, x.description })
                .ToList();
            return Ok(new { brands, categories, saleMethods, types, tags });
        }

        [HttpPost("CreateProduct")]
        [Consumes("multipart/form-data")]
       
        public async Task<IActionResult> CreateProduct([FromForm] ProductVM model  )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

          //  var existProduct = _dbContext.Products.FirstOrDefault(x => x.Id == model.Id);
         //   if (existProduct != null)
          //  {
          //      return BadRequest("This Id Is Exist");
          //  }


            else
            {
                
            }
            if (model.Image.FileName == null || model.Image.FileName.Length ==0)
            {
                return Content("File not selected");
            }

            var path = Path.Combine(_environment.WebRootPath, "Images/", model.Image.FileName);

            await using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await model.Image.CopyToAsync(stream);
                stream.Close();
            }


            //Insert In User Profile table



          
          



            var Product1 = new ProductModel()
            {
              
              PID = model.PID,
              Price = model.Price,
                Name = model.Name,
                Description = model.Description,
                ShortDescription = model.ShortDescription,
                Count = model.Count,
                Image = path,
                CreatiponDate = DateTime.Now,
                BrandId = model.BrandId,
                CategoryId = model.CategoryId,
                TypeId = model.TypeId,
                SaleId = model.SaleId
            };

            await _dbContext.Products.AddAsync(Product1);
            await _dbContext.SaveChangesAsync();
            return Ok(model);

        }
    }

}
