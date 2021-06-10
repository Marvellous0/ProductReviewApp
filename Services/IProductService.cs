using Microsoft.AspNetCore.Mvc.Rendering;
using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using System.Collections.Generic;

namespace ProductReviewApp.Services
{
    public interface IProductService
    {
        public Product AddProduct(CreateProductViewModel model);
        public void Delete(int id);

        public Product FindById(int id);

        public Product UpdateProduct(UpdateProductViewModel model);

        public double AverageRating(int productId);

        public List<ProductViewModel> GetProducts();
        public List<Product> GetReviewProducts(int userId);
        public List<Review> GetEachReview(int productId);
        public IEnumerable<SelectListItem> GetProductList();
    }
}
