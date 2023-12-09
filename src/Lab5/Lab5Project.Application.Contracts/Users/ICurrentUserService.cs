using Lab5Project.Application.Models.Users;

namespace Lab5Project.Application.Contracts.Users;

public interface ICurrentUserService
{
    User? User { get; }
}