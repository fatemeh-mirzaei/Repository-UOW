using Microsoft.AspNetCore.Mvc;

namespace Basket.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        public ProductController(IProductService productService, IOrderService orderService)
        {
            _productService = productService;
            _orderService = orderService;
        }


        [HttpGet("[action]")]
        public ActionResult Products()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpPost("[action]")]
        public ActionResult CreateProduct(CreateProductDto product)
        {
            _productService.CreateProduct(product);
            return Ok();
        }

        [HttpPost("[action]")]
        public IActionResult AddOrder(CreateOrderDto order)
        {
            _orderService.CreateOrder(order);
            return Ok();
        }
    }
}
