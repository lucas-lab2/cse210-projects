using System;

public class Customer
{
    private string _name;
    private Address _address; // Customer HAS-A Address

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address; // Return the Address object itself
    }

    public bool IsInUSA()
    {
        // Delegate the check to the Address object
        return _address.IsInUSA();
    }
}