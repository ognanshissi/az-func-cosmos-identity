using Core.Contracts;
using CosmosIdentity.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosIdentity.Api.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _productService.GetAllAsync());
        }


        [HttpPost]
        public async Task<IActionResult> Add(CreateProductRequest request)
        {
            return Ok(await _productService.CreateAsync(request.Name, request.Description, request.Rate));
        }
    }
}
