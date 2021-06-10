using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewApp.Services
{
    public interface IReviewService
    {
        public Review AddReview(CreateReviewViewModel model);
        public void Delete(int id);
        public Review FindById(int id);
        public List<Review> FindByProductId(int productId);
        public List<ReviewViewModel> GetReviews();
        public Review UpdateReview(UpdateReviewViewModel model);

        public List<ProductIndexViewModel> GetEachReview(int productId);
    }
}
