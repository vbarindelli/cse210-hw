public class Customer
{
    private string _name;
    private Address _address;
    
    public string getName()
    {
        return _name;
    }

    public void setName(string name)
    {
        _name = name;
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool livesInUsa()
    {
        return _address.IsUsa();
        
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
}