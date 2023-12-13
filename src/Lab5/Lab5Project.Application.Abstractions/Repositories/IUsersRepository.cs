using Lab5Project.Application.Models.Users;

namespace Lab5Project.Application.Abstractions.Repositories;

public interface IUsersRepository
{
    User? GetUserAccountAmountByPin(string userName, int pin);
    void CreateUserAccount(User user);
    void DecreaseAccountAmountByPin(long accountNumber, int pin, decimal amount);
    void IncreaseAccountAmountByPin(long accountNumber, int pin, decimal amount);
}