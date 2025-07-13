public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;   
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name      = name;
        _productId = productId;
        _price     = price;
        _quantity  = quantity;
    }

    public string  GetName()      => _name;
    public string  GetProductId() => _productId;
    public int     GetQuantity()  => _quantity;
    public decimal GetPrice()     => _price;

    public decimal GetExtendedPrice() => _price * _quantity;
}
