public class Order
{
    List<Product> _products = new List<Product>();
    Customer _customer;

    public double ComputeOrderCost()
    {
        double orderCost = 0;
        double shippingCost;
        foreach (Product item in _products)
        {
            orderCost = item.TotalPrice() + orderCost;

        }
        if (_customer.IsInUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return orderCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabelList = "";
        foreach (Product item in _products)
        {
            string newPackingLabel = item.GetProductLabel();
            packingLabelList = newPackingLabel + ", " + packingLabelList;
        }
        return packingLabelList;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}, {_customer.GetAddress()}";
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

}