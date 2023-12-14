using Itmo.Dev.Platform.Postgres.Connection;
using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Models.Admins;
using Npgsql;

namespace Lab5Project.Infrastructure.Repositories;

public class AdminsRepository : IAdminsRepository
{
    private const int FirstIndex = 0;
    private const int SecondIndex = 1;
    private readonly IPostgresConnectionProvider _connectionProvider;

    public AdminsRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public Admin? GetAdminByNameAndPassword(string name, string password)
    {
        const string sql = """
                           select admin_name, password
                           from admins
                           where admin_name = @name and password = @password;
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
        command.Parameters.AddWithValue("name", name);
        command.Parameters.AddWithValue("password", password);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
        {
            return null;
        }

        return new Admin(
            Name: reader.GetString(FirstIndex),
            Password: reader.GetString(SecondIndex));
    }
}