using Lab5Project.Application.Models.Admins;

namespace Lab5Project.Application.Abstractions.Repositories;

public interface IAdminsRepository
{
    Admin? GetAdminByNameAndPassword(string name, string password);
}