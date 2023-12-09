using Lab5Project.Application.Models.Users;

namespace Lab5Project.Application.Abstractions.Repositories;

public interface IUsersRepository
{
    IEnumerable<User> GetAllUsers();
}