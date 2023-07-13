public class Order
{
    private List<Product> _products;
    private Customer _customer; 

    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.Price * product.Quantity;
        }

        if (_customer.Address.IsInUSA())
        {
            totalCost +=5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }
}