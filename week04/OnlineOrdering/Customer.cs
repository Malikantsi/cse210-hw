public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string streetAddress, string city, string province, string country, string name)
    {
        _address = new Address(streetAddress, city, province, country);
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetFullAddress()
    {
        return _address.DisplayAddress();
    }

    public bool IsCustomerInUSA()
    {
        return _address.IsInUSA();
    }
}