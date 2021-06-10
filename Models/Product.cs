using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewApp.Models
{
    public class Product : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
