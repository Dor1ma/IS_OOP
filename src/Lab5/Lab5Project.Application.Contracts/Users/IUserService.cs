namespace Lab5Project.Application.Contracts.Users;

public interface IUserService
{
    LoginResult LoginResult(string username, int pin);
    void CreateAccount(string username, int pin);
    decimal? GetAccountValue();
    void Withdrawal(decimal decreaseValue);
    void Replenishment(decimal increaseValue);
    IEnumerable<Operation>? GetOperationsHistory();
}