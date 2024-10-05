public class Address
{
    // initializes member attributes of _streetAddress, _city, _stateOrProvince, and _country.
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Setter method that assigns values to all the address member attributes
    public void SetAddress(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Method that determines if an address is located in the USA or not and returns a boolean value.
    public bool InUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Method that returns a string of a formatted address.
    public string Display()
    {
        string address = $"{_streetAddress}\r\n{_city}, {_stateOrProvince}\r\n{_country}";
        return address;
    }
}