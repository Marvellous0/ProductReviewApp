using Microsoft.AspNetCore.Mvc.Rendering;
using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using ProductReviewApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUserRepository _userRepository;
        private readonly IReviewRepository _reviewRepository;

        public ProductService(IProductRepository productRepository, IUserRepository userRepository, IReviewRepository reviewRepository)
        {
            _productRepository = productRepository;
            _userRepository = userRepository;
            _reviewRepository = reviewRepository;
        }
        public Product AddProduct(CreateProductViewModel model)
        {

            var product = new Product
            {
                Id = model.Id,
                CreatedAt = DateTime.Now,
                Name = model.Name,
                Description = model.Description,
                UserId = model.UserId
            };
            return _productRepository.AddProduct(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public Product FindById(int id)
        {
            return _productRepository.FindById(id);
        }

        public double AverageRating(int productId)
        {
            
            var reviews = _reviewRepository.FindByProductId(productId);
            double sum = 0;

            if (reviews.Count == 0) return 0;
            foreach (var review in reviews)
            {
                sum += review.Ratings;
            }
            double totalaverage = sum / reviews.Count;
            return totalaverage;
            
        }

  
        public List<Product> GetReviewProducts(int userId)
        {
            var products = _productRepository.GetReviewProducts(userId);
            return products;
        }

        public List<Review> GetEachReview(int productId) 
        {
            var review = _productRepository.GetEachReview(productId);
            return review;
        }

        public List<ProductViewModel> GetProducts()
        {
            var products = _productRepository.GetProducts().Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                UserName = _userRepository.FindById(p.UserId).Name,
                AverageRating = AverageRating(p.Id)
            }).ToList();
            return products;
        }

        public Product UpdateProduct(UpdateProductViewModel model)
        {
            var product = FindById(model.Id);

            product.Name = model.Name;

            product.Description = model.Description;

            product.UserId = model.UserId;

            return _productRepository.UpdateProduct(product);
        }

        public IEnumerable<SelectListItem> GetProductList()
        {
            return GetProducts().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }).ToList();
        }
    }
}
