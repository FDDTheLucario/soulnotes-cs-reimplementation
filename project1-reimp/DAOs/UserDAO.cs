using Dev.Richard.Models;

namespace Dev.Richard.DAOs;

public interface UserDAO
{
    User CreateUser(User user);
    
    User GetUserById(string id);
    User GetUserByUsername(string username);
    User GetUserByEmail(string email);
    
    List<User> GetAllUsers();

    void DeleteUserById(string id);
    User DeleteUserByEmail(string email);
}