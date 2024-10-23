using System;

/// <summary>
/// Represents an address with street, city, state/province, and country.
/// </summary>
public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    /// <summary>
    /// Determines if the address is in the USA.
    /// </summary>
    /// <returns>True if the address is in the USA, otherwise false.</returns>
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Returns the full address as a string.
    /// </summary>
    /// <returns>Full address formatted as a string.</returns>
    public override string ToString()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}