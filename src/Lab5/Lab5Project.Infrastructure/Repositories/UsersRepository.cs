using Itmo.Dev.Platform.Postgres.Connection;
using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Models.Users;
using Npgsql;

namespace Lab5Project.Infrastructure.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;

    public UsersRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public IEnumerable<User> GetAllUsers()
    {
        const string sql = """
                           select account_number, user_name, pin, amount
                           from users
                           """;

        using NpgsqlConnection connection = Task
            .Run(async () =>
                await _connectionProvider.GetConnectionAsync(default).ConfigureAwait(false)).GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(sql, connection);

        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            yield return new User(
                reader.GetInt64(0),
                reader.GetString(1),
                reader.GetInt64(2),
                reader.GetInt64(3));
        }
    }
}