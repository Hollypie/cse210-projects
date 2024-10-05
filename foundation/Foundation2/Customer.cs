public class Customer
{
    // initializes member attributes for _name and _address object
    private string _name;
    private Address _address = new Address();

    // Setter method that assigns argument name to _name attribute.
    public void SetCustomerName(string name)
    {
        _name = name;
    }

    // Setter method that assigns Address object to _address attribute.
    public void SetCustomerAddress(Address address)
    {
        _address = address;
    }

    // Getter method that returns _name attribute.
    public string GetCustomerName()
    {
        return _name;
    }

    // Getter method that returns address as a string.
    public string GetCustomerAddress()
    {
        return _address.Display();
    }

    // method that creates boolean that returns whether the address of customer is located on the USA or not.
    public bool InUSA()
    {
        return _address.InUSA();
    }
}