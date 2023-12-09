using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace Lab5Project.Infrastructure.Migrations;

[Migration(1, "Initial")]
public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
    """
    create table users
    (
        account_number bigint primary key ,
        user_name text not null ,
        pin bigint not null ,
        amount bigint not null
    );

    create table admins
    (
        admin_id bigint primary key generated always as identity ,
        admin_name text not null ,
        password text not null
    )
    """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
    """
    drop table users;
    drop table admins;
    """;
}