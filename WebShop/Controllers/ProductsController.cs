using Core.Abstractions.Services;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Models.ViewModels;

namespace WebShop.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("products")]
        public List<Proizvod> GetAllProducts()
        {
            List<Proizvod> proizvodi = _productService.GetAllProducts();
            return proizvodi;
        }

        [HttpPost("products")]
        public IActionResult Insert([FromBody] ProizvodViewModel productModel)
        {
            var p = new Proizvod
            {
                Cena = productModel.Cena,
                Ime = productModel.Ime,
                Kategorija = productModel.Kategorija,
                Opis = productModel.Opis
            };

            _productService.Insert(p);

            return Ok();
        }
        [HttpGet("products/Search/{keyword}")]
        public List<Proizvod> SearchByKeyword(string keyword)
        {
            return _productService.SearchByKeyword(keyword);
        }
        [HttpGet("products/{productId}")]
        public Proizvod? GetById(int productId)
        {
            return _productService.GetById(productId);
        }
        [HttpDelete("products/{productId}")]
        public bool DeleteById(int productId)
        {
            return _productService.Delete(productId);
        }

        [HttpPut("products")]
        public bool UpdateProduts(int productId, ProizvodViewModel product)
        {
            var p = new Proizvod()
            {
                Id = productId,
                Ime = product.Ime,
                Cena = product.Cena,
                Kategorija = product.Kategorija,
                Opis = product.Opis
            };
            return _productService.Update(productId, p);
        }
    }
}