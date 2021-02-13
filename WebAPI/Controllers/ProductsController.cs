using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //loosely coupled->gevşek bağımlılık
        //naming convention
        //IoC Container--inversion of control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            //return "Merhaba";-----
            //return new List<Product>
            //{
            //    new Product{ProductId=1,ProductName="Elma"},
            //    new Product{ProductId=2,ProductName="Armut"},
            //};-----
            //IProductService productService = new ProductManager(new EfProductDal());
            var result=  _productService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);//200
            }
           return BadRequest(result.Message);

        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
