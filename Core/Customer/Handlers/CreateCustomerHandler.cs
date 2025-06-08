// Core/Customer/Handlers/CreateCustomerHandler.cs
using MediatR;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Guid>
{
    private readonly IMediator _mediator;

    public CreateCustomerHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer(Guid.NewGuid(), request.Name, request.Email);

        // Here you’d save to DB (mocked for now)

        // Raise event
        await _mediator.Publish(new CustomerCreatedEvent(customer), cancellationToken);

        return customer.Id;
    }
}
