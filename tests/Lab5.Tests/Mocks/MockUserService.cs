using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Models.Users;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;

public class MockUserService
{
    private readonly IUsersRepository _repository;
    private readonly MockCurrentUserManager _currentUserManager;

    public MockUserService(
        IUsersRepository repository,
        MockCurrentUserManager currentUserManager)
    {
        _repository = repository;
        _currentUserManager = currentUserManager;
    }

    public MockResult LoginResult(string username, int pin)
    {
        User? user = _repository.GetUserAccount(username, pin);

        if (user is null)
        {
            return MockResult.NotFound;
        }

        _currentUserManager.User = user;
        return MockResult.Success;
    }

    public void CreateAccount(string username, int pin)
    {
        _repository.CreateUserAccount(username, pin);
    }

    public decimal? GetAccountValue()
    {
        if (_currentUserManager.User is null)
        {
            return null;
        }

        decimal? value = _repository.GetUserAccountAmountByPin(
            _currentUserManager.User.AccountNumber, _currentUserManager.User.Pin);

        return value;
    }

    public MockResult Withdrawal(decimal decreaseValue)
    {
        if (_currentUserManager.User is null)
        {
            return MockResult.InsufficientFunds;
        }

        _repository.DecreaseAccountAmountByPin(
            _currentUserManager.User.AccountNumber, _currentUserManager.User.Pin, decreaseValue);

        return MockResult.Success;
    }

    public MockResult Replenishment(decimal increaseValue)
    {
        if (_currentUserManager.User is null)
        {
            return MockResult.SomethingWentWrong;
        }

        _repository.IncreaseAccountAmountByPin(
            _currentUserManager.User.AccountNumber, _currentUserManager.User.Pin, increaseValue);

        return MockResult.Success;
    }
}