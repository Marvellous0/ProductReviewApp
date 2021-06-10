using ProductReviewApp.Models;
using System.Collections.Generic;

namespace ProductReviewApp.Repositories
{
    public interface IUserRepository
    {   
        public User AddUser(User user);

        public User FindById(int id);
        
        public User UpdateUser(User user);

        public User FindUserByUseName(string userName);

        public void Delete(int id);

        public List<User> GetUsers();
       
    }
}
