// Core/Customer/Handlers/LogCustomerHandler.cs
using MediatR;

public class LogCustomerHandler : INotificationHandler<CustomerCreatedEvent>
{
    public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"📝 Customer created: {notification.Customer.Name}");
        return Task.CompletedTask;
    }
}
