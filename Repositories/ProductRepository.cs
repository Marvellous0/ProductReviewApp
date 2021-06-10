using ProductReviewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public Product FindById(int id)
        {
            return _dbContext.Products.Find(id);
        }

        public Product UpdateProduct(Product product)
        {

            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            return product;

        }

        public void Delete(int id)
        {
            var product = FindById(id);
            {
                if (product != null)
                {
                    _dbContext.Products.Remove(product);
                    _dbContext.SaveChanges();
                }
            }
        }

        public List<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public List<Product> GetReviewProducts(int userId) 
        {
            return _dbContext.Products.Where(product => product.UserId != userId).ToList();
        }

        public List<Review> GetEachReview(int productId) 
        {
            return _dbContext.Reviews.Where(review => review.ProductId == productId).ToList();
        }
    }
}
