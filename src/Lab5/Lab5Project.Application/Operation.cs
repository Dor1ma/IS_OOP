using Lab5Project.Application.Models;

namespace Lab5Project.Application;

public record Operation(long AccountNumber, OperationType OperationType, decimal Value);