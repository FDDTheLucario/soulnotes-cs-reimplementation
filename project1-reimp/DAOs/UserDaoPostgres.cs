using Dev.Richard.Models;
using Dev.Richard.Utils;
using Npgsql;

namespace Dev.Richard.DAOs;

public class UserDaoPostgres : UserDAO
{
    public User CreateUser(User user)
    {
        using var c = ConnectionUtil.Instance.Connection;
        c.Open();
        Console.WriteLine();
        using var command =
            new NpgsqlCommand("insert into soulnotes.users values ($1, $2, $3, $4, $5, $6, $7, $8)", c)
            {
                Parameters =
                {
                    new() { Value = user.UserId },
                    new() { Value = user.FirstName },
                    new() { Value = user.LastName },
                    new() { Value = user.Email },
                    new() { Value = user.Username },
                    new() { Value = user.Password.Hash },
                    new() { Value = user.Password.Salt },
                    new() { Value = (int)user.Role }
                }
            };

        command.ExecuteNonQuery();
        c.Close();
        return user;
    }

    public User GetUserById(string id)
    {
        throw new NotImplementedException();
    }

    public User GetUserByUsername(string username)
    {
        throw new NotImplementedException();
    }

    public User GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public void DeleteUserById(string id)
    {
        throw new NotImplementedException();
    }

    public User DeleteUserByEmail(string email)
    {
        throw new NotImplementedException();
    }
}