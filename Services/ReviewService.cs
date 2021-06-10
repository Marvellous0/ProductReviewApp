using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using ProductReviewApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewApp.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;

        public ReviewService(IReviewRepository reviewRepository, IUserRepository userRepository, IProductRepository productRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
            _productRepository = productRepository;
        }
        public Review AddReview(CreateReviewViewModel model)
        {
            var review = new Review
            {
                CreatedAt = DateTime.Now,
                UserId = model.UserId,
                ProductId = model.ProductId,
                Comment = model.Comment,
                Ratings = model.Ratings
            };
            return _reviewRepository.AddReview(review);
        }

        public void Delete(int id)
        {
            _reviewRepository.Delete(id);
        }

        public Review FindById(int id)
        {
            return _reviewRepository.FindById(id);
        }

        public List<Review> FindByProductId(int productId)
        {
            return _reviewRepository.FindByProductId(productId);
          
        }

        public List<ReviewViewModel> GetReviews()
        {
            var reviews = _reviewRepository.GetReview().Select(r => new ReviewViewModel
            {
                Id = r.Id,
                UserId = r.UserId,
                ProductId = r.ProductId,
                Comment = r.Comment,
                Ratings = r.Ratings
            }).ToList();
            return reviews;
        }

        public List<ProductIndexViewModel> GetEachReview(int productId)
        {
            var reviews = _reviewRepository.GetEachReview(productId).Select(r => new ProductIndexViewModel
            {
                Id = r.Id,
                Comment = r.Comment,
                Ratings = r.Ratings,
                UserId = r.UserId,
                ProductId = r.ProductId,
                UserName = _userRepository.FindById(r.UserId).Name,
                ProductName = _productRepository.FindById(r.ProductId).Name,
            }).ToList();
            return reviews;
        }

        public Review UpdateReview(UpdateReviewViewModel model)
        {
            var review = new Review
            {
                Comment = model.Comment,
                Ratings = model.Ratings
            };
            return _reviewRepository.UpdateReview(review);
        }
    }
}
