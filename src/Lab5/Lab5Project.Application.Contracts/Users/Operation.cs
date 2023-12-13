using Lab5Project.Application.Models;

namespace Lab5Project.Application.Contracts.Users;

public record Operation(long AccountNumber, OperationType OperationType, decimal Value);