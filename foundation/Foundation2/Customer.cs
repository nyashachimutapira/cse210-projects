/// <summary>
/// Represents a customer with a name and address.
/// </summary>
public class Customer
{
    private string _name;
    private Address _address;

    public string Name => _name;
    public Address Address => _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    /// <summary>
    /// Determines if the customer lives in the USA.
    /// </summary>
    /// <returns>True if the customer is in the USA, otherwise false.</returns>
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}