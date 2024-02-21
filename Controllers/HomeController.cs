using Mango.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mango.Web.Service.IService;
using Newtonsoft.Json;


namespace Mango.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
          private readonly IProductService _productService;

          public HomeController(ILogger<HomeController> logger, IProductService productService)
          {
              _logger = logger;
              _productService = productService;
          }

          public async Task<IActionResult> Index()
        {
            List<ProductDto> list = new();
            ResponseDto? response = await _productService.GetAllProductsAsync();

            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(list);









            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
