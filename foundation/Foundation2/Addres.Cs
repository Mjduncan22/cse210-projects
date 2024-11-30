public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;


    public void SetAddressValues(List<string> list)
    {
        _streetAddress = list[1];
        _city = list[2];
        _stateProvince = list[3];
        _country = list[4];
    }
    public bool IsInUSA()
    {
        return _country == "USA";
    }
    public string CompileFullAddres()
    {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
}