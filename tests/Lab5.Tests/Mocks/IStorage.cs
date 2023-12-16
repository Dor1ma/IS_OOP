using Lab5Project.Application.Models.Users;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;

public interface IStorage
{
    void CreateUser(string username, int pin);
    public void DecreaseAmountValueByPin(long accountNumber, int pin, decimal value);
    public void IncreaseAmountValueByPin(long accountNumber, int pin, decimal value);
    public decimal? GetUserAccountAmountByPin(long accountNumber, int pin);
    public User? GetUserAccount(string username, int pin);
}