using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Contracts.Users;
using Lab5Project.Application.Models.Users;

namespace Lab5Project.Application.Users;

internal class UserService : IUserService
{
    private readonly IUsersRepository _repository;
    private readonly IOperationsHistoryRepository _operationsHistoryRepository;
    private readonly CurrentUserManager _currentUserManager;

    public UserService(
        IUsersRepository repository,
        IOperationsHistoryRepository operationsHistoryRepository,
        CurrentUserManager currentUserManager)
    {
        _repository = repository;
        _currentUserManager = currentUserManager;
        _operationsHistoryRepository = operationsHistoryRepository;
    }

    public LoginResult LoginResult(string username, int pin)
    {
        User? user = _repository.GetUserAccount(username, pin);

        if (user is null)
        {
            return Contracts.Users.LoginResult.NotFound;
        }

        _currentUserManager.User = user;
        return Contracts.Users.LoginResult.Success;
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

    public void Withdrawal(decimal decreaseValue)
    {
        if (_currentUserManager.User is null)
        {
            return;
        }

        _repository.DecreaseAccountAmountByPin(
            _currentUserManager.User.AccountNumber, _currentUserManager.User.Pin, decreaseValue);
        _operationsHistoryRepository.AddNewDecreaseOperationData(
            _currentUserManager.User.AccountNumber, decreaseValue);
    }

    public void Replenishment(decimal increaseValue)
    {
        if (_currentUserManager.User is null)
        {
            return;
        }

        _repository.IncreaseAccountAmountByPin(
            _currentUserManager.User.AccountNumber, _currentUserManager.User.Pin, increaseValue);
        _operationsHistoryRepository.AddNewIncreaseOperationData(
            _currentUserManager.User.AccountNumber, increaseValue);
    }

    public IEnumerable<Operation>? GetOperationsHistory()
    {
        if (_currentUserManager.User is null)
        {
            return null;
        }

        return _operationsHistoryRepository.GetAllOperationsForUserByAccountNumber(
            _currentUserManager.User.AccountNumber);
    }
}