using Lab5Project.Application.Models.Admins;

namespace Lab5Project.Application.Contracts.Admins;

public interface ICurrentAdminService
{
    Admin? Admin { get; }
}