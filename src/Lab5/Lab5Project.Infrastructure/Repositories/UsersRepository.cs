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

    public User? GetUserAccount(string username, int pin)
    {
        const string sql = """
                           select account_number, username, pin, amount
                           from users
                           where username = @user_name and pin = @pin;
                           """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("user_name", username);
        command.Parameters.AddWithValue("pin", pin);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            return null;
        }

        return new User(
            AccountNumber: reader.GetInt64(FirstIndex),
            Username: reader.GetString(SecondIndex),
            Pin: reader.GetInt16(ThirdIndex),
            Amount: reader.GetDecimal(FourthIndex));
    }

    public decimal? GetUserAccountAmountByPin(long accountNumber, int pin)
    {
        const string sql = """
                           select amount
                           from users
                           where account_number = @account_number and pin = @pin;
                           """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("account_number", accountNumber);
        command.Parameters.AddWithValue("pin", pin);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            return null;
        }

        return reader.GetDecimal(FirstIndex);
    }

    public void CreateUserAccount(string username, int pin)
    {
        const string sql = """
                           INSERT INTO users (username, pin, amount)
                           VALUES (@username, @pin, @amount);
                           """;
        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("username", username);
        command.Parameters.AddWithValue("pin", pin);
        command.Parameters.AddWithValue("amount", 0);
        command.ExecuteNonQuery();
    }

    public void DecreaseAccountAmountByPin(long accountNumber, int pin, decimal amount)
    {
        const string sql = """
                           UPDATE users
                           SET amount = amount - @amount
                           WHERE account_number = @accountNumber AND pin = @pin;
                           """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("@accountNumber", accountNumber);
        command.Parameters.AddWithValue("@pin", pin);
        command.Parameters.AddWithValue("@amount", amount);
        command.ExecuteNonQuery();
    }

    public void IncreaseAccountAmountByPin(long accountNumber, int pin, decimal amount)
    {
        const string sql = """
                           UPDATE users
                           SET amount = amount + @amount
                           WHERE account_number = @accountNumber AND pin = @pin;
                           """;

        using var connection = new NpgsqlConnection(new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 6432,
            Username = "postgres",
            Password = "postgres",
            SslMode = SslMode.Prefer,
        }.ConnectionString);
        connection.Open();

        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("@accountNumber", accountNumber);
        command.Parameters.AddWithValue("@pin", pin);
        command.Parameters.AddWithValue("@amount", amount);
        command.ExecuteNonQuery();
    }
}