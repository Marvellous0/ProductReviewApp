using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using ProductReviewApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IReviewService _reviewService;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IReviewService reviewService)
        {
            _logger = logger;
            _productService = productService;
            _reviewService = reviewService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var productList = _productService.GetProducts();

            return View(productList);
        }

        [HttpGet]
        public IActionResult Detail(ProductViewModel model)
        {
            var reviews = _reviewService.GetEachReview(model.Id);

            if(reviews == null)
            {
                return NotFound();
            }
           
            return View(reviews);
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
