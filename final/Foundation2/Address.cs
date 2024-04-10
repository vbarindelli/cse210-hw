public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;


    public string getStreet()
    {
        return _street;
    }

    public string getCity()
    {
        return _city;
    }
    public string getStateProvince()
    {
        return _stateProvince;
    }
    public string getCountry()
    {
        return _country;
    }

    public void setStreet(string street)
    {
        _street = street;
    }

    public void setCity(string city)
    {
        _city = city;
    }
    public void setStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }
    public void setCountry(string country)
    {
        _country = country;
    }
    public string GetAddress()
    {
        return $"{_street}\n {_city} - {_stateProvince} \n {_country}";
    }

    public bool IsUsa()
    {
        return _country == "USA";
        
    }



}