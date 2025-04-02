public class Order
{
    private List<Product> _products;
    private Customer _customer;


    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = new List<Product>(products);
    }
    public Order(Customer customer)
    {
        _customer = customer;

        _products = new List<Product>();
    }


    public float TotalCost()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalPrice();
        }

        if (_customer.IsCustomerInUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;

    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetProductName} \nID:{product.GetProductID}";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName} {_customer.GetFullAddress()}";
    }
}