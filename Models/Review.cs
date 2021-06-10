using System.ComponentModel.DataAnnotations;

namespace ProductReviewApp.Models
{
    public class Review : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Required, MaxLength(50)]
        public string Comment { get; set; }
        [Range(1,5)]
        public double Ratings { get; set; }
    }
}
