using Microsoft.AspNetCore.Mvc.Rendering;
using ProductReviewApp.Models;
using ProductReviewApp.Models.ViewModel;
using ProductReviewApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User AddUser(CreateUserViewModel model)
        {

            var user = new User
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Gender = model.Gender,
                CreatedAt = DateTime.Now
            };
            return _userRepository.AddUser(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public User FindById(int id)
        {
            return _userRepository.FindById(id);
        }

        public List<UserViewModel> GetUsers()
        {
            var users = _userRepository.GetUsers().Select(u => new UserViewModel
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                Gender = u.Gender
            }).ToList();
            return users;
        }
  
        public IEnumerable<SelectListItem> GetUserList()
        {
            return GetUsers().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            }).ToList();
        }

        public User FindUserByUserName(string userName)
        {
            return _userRepository.FindUserByUseName(userName);
        }
    }
}
