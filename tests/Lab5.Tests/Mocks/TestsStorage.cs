using System.Collections.Generic;
using Lab5Project.Application.Models.Users;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;

public class TestsStorage : IStorage
{
    private const decimal InitAccountValue = 0;
    private readonly IList<UsersTableData> _data = new List<UsersTableData>();
    private long _accountIdCounter = 1;

    public void CreateUser(string username, int pin)
    {
        _data.Add(new UsersTableData(_accountIdCounter, username, pin, InitAccountValue));
        _accountIdCounter++;
    }

    public void IncreaseAmountValueByPin(long accountNumber, int pin, decimal value)
    {
        foreach (UsersTableData row in _data)
        {
            if (row.AccountNumber == accountNumber && row.Pin == pin)
            {
                row.IncreaseAccountAmount(value);
                return;
            }
        }
    }

    public void DecreaseAmountValueByPin(long accountNumber, int pin, decimal value)
    {
        foreach (UsersTableData row in _data)
        {
            if (row.AccountNumber == accountNumber && row.Pin == pin)
            {
                row.DecreaseAccountAmount(value);
                return;
            }
        }
    }

    public decimal? GetUserAccountAmountByPin(long accountNumber, int pin)
    {
        decimal? result;
        foreach (UsersTableData row in _data)
        {
            if (row.AccountNumber == accountNumber && row.Pin == pin)
            {
                result = row.Amount;
                return result;
            }
        }

        return null;
    }

    public User? GetUserAccount(string username, int pin)
    {
        foreach (UsersTableData row in _data)
        {
            if (row.UserName == username && row.Pin == pin)
            {
                return new User(row.AccountNumber, row.UserName, row.Pin, row.Amount);
            }
        }

        return null;
    }
}