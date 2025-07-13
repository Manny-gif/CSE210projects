using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        Product pen   = new Product("Blue Ball-Point Pen",   "B-PEN-01", 1.25M, 10);
        Product mug   = new Product("Ceramic BYU-I Mug",     "MUG-BLU",  8.99M,  2);
        Product shirt = new Product("CSE-210 T-Shirt (M)",   "TS-MED",  14.50M,  1);
        Product book  = new Product("Clean Code Principles Book",   "BCP",  29.95M,  1);

        
        Address idahoAddr = new Address("123 Pioneer Rd", "Rexburg", "ID", "USA");
        Customer alice     = new Customer("Alice Johnson", idahoAddr);

        Address canadaAddr = new Address("987 Maple Ave", "Calgary", "AB", "Canada");
        Customer bob       = new Customer("Bob Chan", canadaAddr);

        Order order1 = new Order(alice);
        order1.AddProduct(pen);
        order1.AddProduct(mug);

        Order order2 = new Order(bob);
        order2.AddProduct(shirt);
        order2.AddProduct(book);

       
        List<Order> orders = new() { order1, order2 };

        foreach (Order o in orders)
        {
            Console.WriteLine("====================");
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"Order Total: ${o.GetTotalCost():0.00}");
            Console.WriteLine("=============\n");
        }
    }
}
