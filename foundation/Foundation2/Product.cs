public class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;


    public void SetProductInfo(string productName, string productID, double productPrice, int productQuantity)
    {
    _productName = productName;
    _productID = productID;
    _productPrice = productPrice;
    _productQuantity = productQuantity;
    }

    public string GetProductLabel()
    {
        return $"{_productName}:{_productID}";
    }

    public double TotalPrice()
    {
        return _productPrice * _productQuantity;
    }

}