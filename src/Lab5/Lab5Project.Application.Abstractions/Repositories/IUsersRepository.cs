using Lab5Project.Application.Models.Users;

namespace Lab5Project.Application.Abstractions.Repositories;

public interface IUsersRepository
{
    User? GetUserAccount(string username, int pin);
    decimal? GetUserAccountAmountByPin(long accountNumber, int pin);
    void CreateUserAccount(string username, int pin);
    void DecreaseAccountAmountByPin(long accountNumber, int pin, decimal amount);
    void IncreaseAccountAmountByPin(long accountNumber, int pin, decimal amount);
}