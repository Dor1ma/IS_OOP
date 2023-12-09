using Lab5Project.Application.Contracts.Users;
using Lab5Project.Application.Models.Users;

namespace Lab5Project.Application.Users;

internal class CurrentUserManager : ICurrentUserService
{
    public User? User { get; set; }
}