using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;

namespace Lab5Project.Infrastructure.Migrations;

[Migration(1, "Initial")]
public class Initial : SqlMigration
{
    protected override string GetUpSql(IServiceProvider serviceProvider) =>
    """
    create type operation_type as enum
    (
        'Increase',
        'Decrease'
    );
    
    create table users
    (
        account_number bigint primary key generated always as identity ,
        username text not null ,
        pin bigint not null ,
        amount numeric not null
    );

    create table admins
    (
        admin_id bigint primary key generated always as identity ,
        admin_name text not null ,
        password text not null
    );

    create table operations_history
    (
        operation_number bigint primary key generated always as identity ,
        account_number bigint not null ,
        operation_type operation_type not null ,
        value numeric not null
    );
    """;

    protected override string GetDownSql(IServiceProvider serviceProvider) =>
    """
    drop table users;
    drop table admins;
    drop table operations_history;
    """;
}