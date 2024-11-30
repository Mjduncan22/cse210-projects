public class Customer
{
    private string _name;
     private Address _address = new Address();
    

    public void SetAddressClass(List<string> addressList)
    {
        _address.SetAddressValues(addressList);
        _name = addressList[0];
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.CompileFullAddres();
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}