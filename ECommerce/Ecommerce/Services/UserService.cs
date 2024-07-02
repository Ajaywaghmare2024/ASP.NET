using Ecommerce.Models;

namespace Ecommerce.Services
{
    public class UserService : IUserService
    {
        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public bool insert(User user)
        {
            return true;
        }

        public bool update(User user)
        {
            return false;   
        }
    }
}
