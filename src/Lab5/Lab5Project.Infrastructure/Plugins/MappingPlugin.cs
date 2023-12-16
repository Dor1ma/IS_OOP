using Itmo.Dev.Platform.Postgres.Plugins;
using Lab5Project.Application.Models;
using Npgsql;

namespace Lab5Project.Infrastructure.Plugins;

public class MappingPlugin : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder)
    {
        builder.MapEnum<OperationType>();
    }
}