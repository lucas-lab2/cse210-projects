using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        // Normalize country input for comparison (e.g., "usa", "USA", "United States")
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase) ||
               _country.Equals("United States", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}