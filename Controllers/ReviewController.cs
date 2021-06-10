using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using ProductReviewApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewApp.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        private readonly IUserService _userService;

        private readonly IProductService _productService;

        public ReviewController(IReviewService reviewService, IUserService userService, IProductService productService)
        {
            _reviewService = reviewService;
            _userService = userService;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<ProductIndexViewModel> productIndexVM = new List<ProductIndexViewModel>();

            var reviews = _reviewService.GetReviews();

            foreach (var review in reviews)
            {
                ProductIndexViewModel productIndex = new ProductIndexViewModel
                {
                    Id = review.Id,
                    Comment = review.Comment,
                    Ratings = review.Ratings,
                    UserName = _userService.FindById(review.UserId).Name,
                    ProductName = _productService.FindById(review.ProductId).Name,
                };

                productIndexVM.Add(productIndex);
            }

            return View(productIndexVM);
        }

        [HttpGet]
        public IActionResult SelectUser()
        {
            ViewBag.users = _userService.GetUserList();

            ViewBag.products = _productService.GetProductList();

            var model = new SelectUserViewModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult SelectUser(SelectUserViewModel model)
        {
            return RedirectToAction(nameof(Create), new { userId = model.UserId });
        }

        [HttpGet]
        public IActionResult Create(int userId)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Create(CreateReviewViewModel model)
        {
            var userId = model.UserId;

            User user = _userService.FindById(userId);

            if (user == null || userId == 0) return RedirectToAction(nameof(Index));

            ViewBag.products = _productService.GetReviewProducts(userId).Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }).ToList();

            ViewBag.UserId = user.Name;
            return View(model);
        }

        [HttpPost]
        public IActionResult SubmitReview(CreateReviewViewModel model)
        {
            Console.WriteLine("user Id is : " + model.UserId);
            Console.WriteLine("product Id is : " + model.ProductId);
            _reviewService.AddReview(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var review = _reviewService.FindById(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        public IActionResult Update(int id)
        {
            var review = _reviewService.FindById(id);
            if (review == null)
            {
                return NotFound();
            }

            var model = new UpdateReviewViewModel
            {
                ProductId = review.ProductId,
                UserId = review.UserId,
                Comment = review.Comment,
                Ratings = review.Ratings
            };

            return View(model);

        }
        [HttpPost]
        public IActionResult Update(UpdateReviewViewModel model)
        {
            _reviewService.UpdateReview(model);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var review = _reviewService.FindById(id);
            if (review == null)
            {
                return NotFound();
            }

            _reviewService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
