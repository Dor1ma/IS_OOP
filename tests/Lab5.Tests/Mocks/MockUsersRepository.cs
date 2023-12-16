using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Models.Users;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;

public class MockUsersRepository : IUsersRepository
{
    private IStorage _storage = new TestsStorage();

    public User? GetUserAccount(string username, int pin)
    {
        return _storage.GetUserAccount(username, pin);
    }

    public decimal? GetUserAccountAmountByPin(long accountNumber, int pin)
    {
        return _storage.GetUserAccountAmountByPin(accountNumber, pin);
    }

    public void CreateUserAccount(string username, int pin)
    {
        _storage.CreateUser(username, pin);
    }

    public void DecreaseAccountAmountByPin(long accountNumber, int pin, decimal amount)
    {
        _storage.DecreaseAmountValueByPin(accountNumber, pin, amount);
    }

    public void IncreaseAccountAmountByPin(long accountNumber, int pin, decimal amount)
    {
        _storage.IncreaseAmountValueByPin(accountNumber, pin, amount);
    }
}