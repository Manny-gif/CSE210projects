using System.Collections.Generic;
using System.Text;

public class Order
{
    private const decimal USA_SHIPPING  =  5.00M;
    private const decimal INTL_SHIPPING = 35.00M;

    private List<Product> _products = new();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

 

    public decimal GetSubTotal()
    {
        decimal total = 0;
        foreach (Product p in _products)
        {
            total += p.GetExtendedPrice();
        }
        return total;
    }

    public decimal GetShippingCost()
    {
        return _customer.GetAddress().IsUSA() ? USA_SHIPPING : INTL_SHIPPING;
    }

    public decimal GetTotalCost() => GetSubTotal() + GetShippingCost();



    public string GetPackingLabel()
    {
        StringBuilder sb = new();
        sb.AppendLine("PACKING LABEL");
        foreach (Product p in _products)
            sb.AppendLine($"{p.GetName()} (#{p.GetProductId()}) x{p.GetQuantity()}");
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new();
        sb.AppendLine("SHIPPING LABEL");
        sb.AppendLine(_customer.GetName());
        sb.Append(_customer.GetAddress().ToString());
        return sb.ToString();
    }
}
