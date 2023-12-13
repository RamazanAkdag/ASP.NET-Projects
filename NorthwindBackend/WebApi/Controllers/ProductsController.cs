using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        [Authorize(Roles = "Product.List")]
        public IActionResult GetAll() { 
            var result = _productService.GetList();

            if(result.Success) {
            
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getlistbycategory")]
        public IActionResult GetListBycategory(int categoryId)
        {
            var result = _productService.GetListByCategory(categoryId);

            if (result.Success)
            {

                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int categoryId)
        {
            var result = _productService.GetById(categoryId);

            if (result.Success)
            {

                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult add(Product product)
        {

            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("update")]
        public IActionResult update(Product product)
        {

            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

        }

        [HttpPost("delete")]
        public IActionResult delete(Product product)
        {

            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);

        }


    }
}
