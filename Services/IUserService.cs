using Microsoft.AspNetCore.Mvc.Rendering;
using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using System.Collections.Generic;

namespace ProductReviewApp.Services
{
    public interface IUserService
    {
        public User AddUser(CreateUserViewModel model);
        public User FindById(int id);
        public void Delete(int id);

        public User FindUserByUserName(string userName);
        public List<UserViewModel> GetUsers();
        public IEnumerable<SelectListItem> GetUserList();
    }
}
