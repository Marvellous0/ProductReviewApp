using ProductReviewApp.Models;
using System.Collections.Generic;

namespace ProductReviewApp.Repositories
{
    public interface IProductRepository
    {
        public Product AddProduct(Product product);

        public Product FindById(int id);

        public Product UpdateProduct(Product product);

        public void Delete(int id);

        public List<Product> GetProducts();
        public List<Product> GetReviewProducts(int userId);
        public List<Review> GetEachReview(int productId);
    }
}
