using Lab5Project.Application.Contracts.Admins;
using Lab5Project.Application.Models.Admins;

namespace Lab5Project.Application.Admins;

internal class CurrentAdminManager : ICurrentAdminService
{
    public Admin? Admin { get; set; }
}