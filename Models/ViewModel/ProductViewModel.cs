using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductReviewApp.Models.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double AverageRating { get; set; }
        public string UserName { get; set; }
    }

    public class CreateProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product manufacturer is required")]
        [Display(Name = "User")]
        public User User { get; set; }
        public int UserId { get; set; }
       
    }

    public class UpdateProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Update Product Name")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Update Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public int UserId { get; set; }
    }
}