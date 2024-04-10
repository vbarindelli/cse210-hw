public class Order
{
     public List<Product> _products = new List<Product>();
     public Customer _customer;

     public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

     public float getTotalCost()
     {
        float totalCost = 0;
        float shippingCost = 0;
        if (_customer.livesInUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        foreach(Product product in _products)
        {
            totalCost = totalCost + product.GetTotalCost() + shippingCost;
        }
        return totalCost;
     }

     public void PackingLabel()
     {
        Console.WriteLine("Packing Label:");
        foreach(Product product in _products)
        Console.WriteLine($"Name: {product.getName()} - Product ID: {product.getProductId()}");
     }

     public void ShippingLabel()
     {
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"{_customer.getName()}");
        Console.WriteLine($"{_customer.GetAddress()}");
     } 
}