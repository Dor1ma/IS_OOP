using Lab5Project.Application.Abstractions.Repositories;
using Lab5Project.Application.Contracts.Admins;
using Lab5Project.Application.Contracts.Users;
using Lab5Project.Application.Models.Admins;

namespace Lab5Project.Application.Admins;

internal class AdminService : IAdminService
{
    private readonly IAdminsRepository _repository;
    private readonly CurrentAdminManager _currentAdminManager;

    public AdminService(
        IAdminsRepository repository,
        CurrentAdminManager currentAdminManager)
    {
        _repository = repository;
        _currentAdminManager = currentAdminManager;
    }

    public LoginResult LoginResult(string username, string pin)
    {
        Admin? admin = _repository.GetAdminByNameAndPassword(username, pin);

        if (admin is null)
        {
            return Contracts.Users.LoginResult.NotFound;
        }

        _currentAdminManager.Admin = admin;
        return Contracts.Users.LoginResult.Success;
    }
}