// Core/Customer/Entities/Customer.cs
public class Customer
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }

    public Customer(Guid id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}
