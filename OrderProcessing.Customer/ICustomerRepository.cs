﻿namespace OrderProcessing.Customer;

public interface ICustomerRepository
{
    public Task<List<Customer>> GetAllCustomers();
}

public class CustomerRepository : ICustomerRepository
{
    private readonly List<Customer> customers = new List<Customer>();
    public CustomerRepository()
    {
        customers.Add(new Customer()
        {
            Id = Guid.NewGuid(),
            FirstName = "Joydip",
            LastName = "Kanjilal",
            EmailAddress = "joydipkanjilal@yahoo.com"
        });

        customers.Add(new Customer()
        {
            Id = Guid.NewGuid(),
            FirstName = "Steve",
            LastName = "Smith",
            EmailAddress = "stevesmith@yahoo.com"
        });
    }
    public Task<List<Customer>> GetAllCustomers()
    {
        return Task.FromResult(customers);
    }
}