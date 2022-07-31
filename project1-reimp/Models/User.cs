
namespace Dev.Richard.Models;

public class User
{
    public User(string firstName, string lastName, string username, string email, Password password)
    {
        UserId = Guid.NewGuid().ToString();
        FirstName = firstName;
        LastName = lastName;
        Username = username;
        Email = email;
        Password = password;
    }

    public User()
    {
        
    }

    public string UserId { get; set; } 
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public string Username { get; set; } 
    public string Email { get; set; }
    public Roles Role { get; set; }
    public Password Password { get; set; }
 
    
}