using Lab5Project.Application.Contracts.Users;

namespace Lab5Project.Application.Contracts.Admins;

public interface IAdminService
{
    LoginResult LoginResult(string username, string password);
}