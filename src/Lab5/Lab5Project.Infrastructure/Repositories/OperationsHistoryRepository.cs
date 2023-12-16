using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Contracts.Users;
using Lab5Project.Application.Models;
using Npgsql;

namespace Lab5Project.Infrastructure.Repositories;

public class OperationsHistoryRepository : IOperationsHistoryRepository
{
    private const int FirstIndex = 0;
    private const int SecondIndex = 1;
    private const int ThirdIndex = 2;
    private decimal _value = 1;

    public void AddNewIncreaseOperationData(long accountNumber, decimal value)
    {
        const string sql = """
                           INSERT INTO operations_history (account_number, operation_type, value)
                           VALUES (@accountNumber, @operationType, @value);
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

        _value = value;
        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("accountNumber", accountNumber);
        command.Parameters.AddWithValue("operationType", OperationType.Increase.ToString());
        command.Parameters.AddWithValue("value", _value);
        command.ExecuteNonQuery();
    }

    public void AddNewDecreaseOperationData(long accountNumber, decimal value)
    {
        const string sql = """
                           INSERT INTO operations_history (account_number, operation_type, value)
                           VALUES (@accountNumber, @operationType, @value);
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

        _value = value;
        using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddWithValue("accountNumber", accountNumber);
        command.Parameters.AddWithValue("operationType", OperationType.Decrease.ToString());
        command.Parameters.AddWithValue("value", _value);
        command.ExecuteNonQuery();
    }

    public IEnumerable<Operation> GetAllOperationsForUserByAccountNumber(long accountNumber)
    {
        const string sql = """
                           select account_number, operation_type, value 
                           from operations_history
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

        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            yield return new Operation(
                AccountNumber: reader.GetInt64(FirstIndex),
                OperationType: reader.GetString(SecondIndex),
                Value: reader.GetInt64(ThirdIndex));
        }
    }
}