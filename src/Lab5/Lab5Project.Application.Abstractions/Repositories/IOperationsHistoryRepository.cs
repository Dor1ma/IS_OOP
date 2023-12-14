using Lab5Project.Application.Contracts.Users;

namespace Lab5Project.Application.Abstractions.Repositories;

public interface IOperationsHistoryRepository
{
    void AddNewIncreaseOperationData(long accountNumber, decimal value);
    void AddNewDecreaseOperationData(long accountNumber, decimal value);
    IEnumerable<Operation> GetAllOperationsForUserByAccountNumber(long accountNumber);
}