using Itmo.Dev.Platform.Postgres.Connection;
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
    private readonly IPostgresConnectionProvider _connectionProvider;

    public OperationsHistoryRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public IEnumerable<Operation> GetAllOperationsForUserByAccountNumber(long accountNumber)
    {
        const string sql = """
                           select account_number, operation_type, value 
                           from operations_history
                           """;

        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false)).GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);

        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            yield return new Operation(
                AccountNumber: reader.GetInt64(FirstIndex),
                OperationType: reader.GetFieldValue<OperationType>(SecondIndex),
                Value: reader.GetInt64(ThirdIndex));
        }
    }
}