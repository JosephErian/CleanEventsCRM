// Core/Customer/Commands/CreateCustomerCommand.cs
using MediatR;

public record CreateCustomerCommand(string Name, string Email) : IRequest<Guid>;
