namespace Lab5Project.Application.Abstractions.Repositories;

public interface IOperationsHistoryRepository
{
    IEnumerable<Operation> GetAllOperationsForUserByAccountNumber(long accountNumber);
}