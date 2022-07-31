using System.Text;
using Dev.Richard.DAOs;
using Dev.Richard.Models;
using Dev.Richard.Utils;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");


var userDAO = new UserDaoPostgres();
var password = Generation.GeneratePassword("Testing123!");
var user = new User
{
    UserId = Guid.NewGuid().ToString(),
    Password = password,
    FirstName = "Richard",
    Role = Roles.Basic,
    Email = "fddthelucario@gmail.com",
    Username = "fddthelucario",
    LastName = "Moch"
};
userDAO.CreateUser(user);





