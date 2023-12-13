using Lab5Project.Application.Contracts.Users;

namespace Lab5Project.Application.Abstractions.Repositories;

public interface IOperationsHistoryRepository
{
    IEnumerable<Operation> GetAllOperationsForUserByAccountNumber(long accountNumber);
}