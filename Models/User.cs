using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductReviewApp.Models
{
    public class User : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string Gender { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Product> Products { get; set; } = new List<Product>();
       
    }
}
