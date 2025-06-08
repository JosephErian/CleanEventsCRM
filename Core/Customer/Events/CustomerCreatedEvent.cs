// Core/Customer/Events/CustomerCreatedEvent.cs
using MediatR;

public record CustomerCreatedEvent(Customer Customer) : INotification;
