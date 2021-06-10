using Microsoft.AspNetCore.Mvc;
using ProductReviewApp.Models.ViewModel;
using ProductReviewApp.Services;

namespace ProductReviewApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;

        public ProductController(IProductService productService, IUserService userService)
        {
            _productService = productService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var productList = _productService.GetProducts();

            return View(productList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.users = _userService.GetUserList();

            var model = new CreateProductViewModel();

            return View(model);
        }

        [HttpPost]

        public IActionResult Create(CreateProductViewModel model)
        {
            _productService.AddProduct(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var product = _productService.FindById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult Update(int id)
        {
            var product = _productService.FindById(id);
            if (product == null)
            {
                return NotFound();
            }

            var model = new UpdateProductViewModel();
        
            ViewBag.users = _userService.GetUserList();

            return View(model);

        }
        [HttpPost]
        public IActionResult Update(UpdateProductViewModel model)
        {
            _productService.UpdateProduct(model);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = _productService.FindById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
