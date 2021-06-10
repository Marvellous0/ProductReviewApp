using Microsoft.AspNetCore.Mvc;
using ProductReviewApp.Models.ViewModel;
using ProductReviewApp.Services;

namespace ProductReviewApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var userList = _userService.GetUsers();

            return View(userList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreateUserViewModel model)
        {
            _userService.AddUser(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var user = _userService.FindById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        public IActionResult Delete(int id)
        {
            var user = _userService.FindById(id);
            if (user == null)
            {
                return NotFound();
            }

            _userService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
