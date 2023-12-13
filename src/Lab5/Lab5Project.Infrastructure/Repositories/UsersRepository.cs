using Itmo.Dev.Platform.Postgres.Connection;
using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Models.Users;
using Npgsql;

namespace Lab5Project.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    private const int FirstIndex = 0;
    private const int SecondIndex = 1;
    private const int ThirdIndex = 2;
    private const int FourthIndex = 3;
    private readonly IPostgresConnectionProvider _connectionProvider;

    public UsersRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public User? GetUserAccountAmountByPin(string userName, int pin)
    {
        const string sql = """
                           select account_number, username, pin, amount
                           from users
                           where username = :userName and pin = :pin;
                           """;

        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false)).GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("username", userName);
        command.Parameters.AddWithValue("pin", pin);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            return null;
        }

        return new User(
            AccountNumber: reader.GetInt64(FirstIndex),
            Username: reader.GetString(SecondIndex),
            Pin: reader.GetInt64(ThirdIndex),
            Amount: reader.GetDecimal(FourthIndex));
    }

    public void CreateUserAccount(User user)
    {
        const string sql = """
                           INSERT INTO users (username, pin, amount)
                           VALUES (:username, :pin, :amount);
                           """;
        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false)).GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("username", user.Username);
        command.Parameters.AddWithValue("pin", user.Pin);
        command.Parameters.AddWithValue("amount", user.Amount);
        command.ExecuteReader();
    }

    public void DecreaseAccountAmountByPin(long accountNumber, int pin, decimal amount)
    {
        const string sql = """
                           UPDATE users
                           SET amount = amount - :amount
                           WHERE account_number = :accountNumber AND pin = :pin;
                           """;
        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false)).GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("account_number", accountNumber);
        command.Parameters.AddWithValue("pin", pin);
        command.Parameters.AddWithValue("amount", amount);
        command.ExecuteReader();
    }

    public void IncreaseAccountAmountByPin(long accountNumber, int pin, decimal amount)
    {
        const string sql = """
                           UPDATE users
                           SET amount = amount + :amount
                           WHERE account_number = :accountNumber AND pin = :pin;
                           """;
        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false)).GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("account_number", accountNumber);
        command.Parameters.AddWithValue("pin", pin);
        command.Parameters.AddWithValue("amount", amount);
        command.ExecuteReader();
    }
}