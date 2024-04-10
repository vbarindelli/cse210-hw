using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address();
        address1.setStreet("233 North");
        address1.setCity("Florence");
        address1.setStateProvince("NJ");
        address1.setCountry("USA");
        
        Customer customer1 = new Customer("Sergio Barindelli", address1);
        
        Product product1 = new Product();
        product1.setName("White Blue Goggles");
        product1.setProductId("SkiiGoggles");
        product1.setQuantity(3);
        product1.setPrice(29.99F);
        Product product2 = new Product();
        product2.setName("Dark Red Gloves");
        product2.setProductId("SkiiGloves");
        product2.setQuantity(2);
        product2.setPrice(15.99F);
        Product product3 = new Product();
        product3.setName("Stealth Jacket");
        product3.setProductId("Jacket");
        product3.setQuantity(4);
        product3.setPrice(79.99F);


        Address address2 = new Address();
        address2.setStreet("2355 East");
        address2.setCity("Malaga");
        address2.setStateProvince("Malaga");
        address2.setCountry("Spain");
        
        Customer customer2 = new Customer("Virginia Haedo", address2);
        
        Product product4 = new Product();
        product4.setName("White Blue Mittens");
        product4.setProductId("SkiiMittens");
        product4.setQuantity(3);
        product4.setPrice(19.99F);
        Product product5 = new Product();
        product5.setName("Dark Red Beanie");
        product5.setProductId("SkiiBeanie");
        product5.setQuantity(2);
        product5.setPrice(5.99F);
        Product product6 = new Product();
        product6.setName("Stealth thermal crewneck");
        product6.setProductId("Crewneck");
        product6.setQuantity(2);
        product6.setPrice(9.99F);

        List<Product> products1 = new List<Product>
        {
            product1,
            product2,
            product3
        };
        Order order1 = new Order(customer1, products1);
        List<Product> products2 = new List<Product>
        {
            product4,
            product5,
            product6
        };
        Order order2 = new Order(customer2, products2);

        Console.WriteLine();
        order1.PackingLabel();
        Console.WriteLine();
        order1.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.getTotalCost()}");
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.WriteLine();
        order2.PackingLabel();
        Console.WriteLine();
        order2.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.getTotalCost()}");
      
        
    }
}