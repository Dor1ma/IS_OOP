namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;

public class UsersTableData
{
    public UsersTableData(long accountNumber, string userName, int pin, decimal amount)
    {
        AccountNumber = accountNumber;
        UserName = userName;
        Pin = pin;
        Amount = amount;
    }

    public long AccountNumber { get; }
    public string UserName { get; }
    public int Pin { get; }
    public decimal Amount { get; private set; }

    public void IncreaseAccountAmount(decimal value)
    {
        Amount += value;
    }

    public void DecreaseAccountAmount(decimal value)
    {
        Amount -= value;
    }
}