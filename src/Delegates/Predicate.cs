namespace Delegates.Predicate;

/// <summary>
/// A Predicate is a delegate that accepts one or more generic parameters and returns a boolean value. Predicate delegates are typically used to perform search operations based on a set of criteria.
/// </summary>
internal class Predicate
{
    void Act()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                FirstName = "Joydip",
                LastName = "Kanjilal",
                State = "Telengana",
                City = "Hyderabad",
                Address = "Begumpet",
                Country = "India"
            },
            new Customer
            {
                Id = 2,
                FirstName = "Steve",
                LastName = "Jones",
                State = "OA",
                City = "New York",
                Address = "Lake Avenue",
                Country = "US"
            }
        };

        Predicate<Customer> hydCustomers = x => x.Id == 1;
        Customer customer = customers.Find(hydCustomers);
    }
}

class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}
