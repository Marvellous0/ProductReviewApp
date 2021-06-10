using ProductReviewApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewApp.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ProductDbContext _dbContext;
       
        public ReviewRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Review AddReview(Review review)
        {
            _dbContext.Reviews.Add(review);
            _dbContext.SaveChanges();
            return review;
        }

        public Review FindById(int id)
        {
            return _dbContext.Reviews.Find(id);
        }

        public List<Review> FindByProductId(int ProductId)
        {
            return _dbContext.Reviews.Where(review => review.ProductId == ProductId).ToList();
        }

        public Review UpdateReview(Review review)
        {

            _dbContext.Reviews.Update(review);
            _dbContext.SaveChanges();
            return review;

        }

        public void Delete(int id)
        {
            var user = FindById(id);
            {
                if (user != null)
                {
                    _dbContext.Reviews.Remove(user);
                    _dbContext.SaveChanges();
                }
            }
        }

        public List<Review> GetReview()
        {
            return _dbContext.Reviews.ToList();
        }

        public List<Review> GetEachReview(int productId)
        {
            return _dbContext.Reviews.Where(review => review.ProductId == productId).ToList();
        }
    }
}
