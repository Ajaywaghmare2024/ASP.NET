using Ecommerce.Models; 

namespace Ecommerce.Services

{
    public interface IUserService
    {
        List<User> GetUsers();

        User GetUser(int id);

        bool insert(User user); 
        bool update(User user);
        bool delete(int id);

    }
}
