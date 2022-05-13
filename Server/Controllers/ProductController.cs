using Application.Contracts;
using Application.Helpers;
using BlazorApp1.Shared;
using Domain.Entities;
using Infrastructure.Data.DatabaseContext;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    //[Authorize]
    [ApiController]
    //[ApiVersion("1.0")]
    [Route("api/product")]
    public class ProductController : Controller
    {
        private readonly IServiceManager _services;

        public ProductController(IServiceManager services)
        {
            _services = services;
        }

        /// <summary>
        /// Endpoint to get all activities
        /// </summary>
        /// <returns></returns>
        //[AllowAnonymous]
        [HttpGet(Name = nameof(GetProducts))]
        [ProducesResponseType(typeof(SuccessResponse<List<ProductDto>>), 200)]
        public async Task<IActionResult> GetProducts()
        {
            var response = await _services.ProductService.GetProductsAsync();

            return Ok(response);
        }
    }
}
