using System.ComponentModel.DataAnnotations;

namespace ProductReviewApp.Models.ViewModel
{
    public class UserViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

            public string Gender { get; set; }
        }

    public class CreateUserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "User name is required")]
        [Display(Name = "User Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Display(Name = "Gender")]

        public string Gender { get; set; }
        public int UserId { get; set; }
    }
}

