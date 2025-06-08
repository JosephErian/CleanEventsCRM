// Core/Customer/Handlers/SendWelcomeEmailHandler.cs
using MediatR;

public class SendWelcomeEmailHandler : INotificationHandler<CustomerCreatedEvent>
{
    public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"📧 Sending welcome email to {notification.Customer.Email}");
        return Task.CompletedTask;
    }
}
