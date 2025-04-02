public class Product
{
    private string _productName;
    private string _productId;
    private int _price;
    private int _quantityPerItem;


    public Product(string productName, string productId, int Price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = Price;
        _quantityPerItem = quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }
    public string GetProductID()
    {
        return _productId;
    }

    public float TotalPrice()
    {
        return _price * _quantityPerItem;
    }
}