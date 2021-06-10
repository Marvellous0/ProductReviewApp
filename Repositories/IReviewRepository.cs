using ProductReviewApp.Models;
using System.Collections.Generic;

namespace ProductReviewApp.Repositories
{
    public interface IReviewRepository
    {
        public Review AddReview(Review review);

        public Review FindById(int id);

        public List<Review> FindByProductId(int ProductId);

        public Review UpdateReview(Review review);

        public void Delete(int id);

        public List<Review> GetReview();
        public List<Review> GetEachReview(int productId);
    }
}
