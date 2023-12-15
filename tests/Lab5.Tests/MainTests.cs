using Itmo.ObjectOrientedProgramming.Lab5.Tests.Mocks;
using Lab5Project.Application.Abstractions.Repositories;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class MainTests
{
    [Fact]
    public void AccountBalanceUpdateCheck()
    {
        IUsersRepository mockRepository = new MockUsersRepository();
        var userService = new MockUserService(mockRepository, new MockCurrentUserManager());
        string username = "239";
        int pin = 239;
        decimal replenishmentSum = 239;
        decimal? expected = null;

        userService.CreateAccount(username, pin);
        userService.Replenishment(replenishmentSum);
        decimal? result = userService.GetAccountValue();

        Assert.Equal(expected, result);
    }
}