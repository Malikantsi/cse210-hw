using System;

class Program
{
    static void Main(string[] args)
    {
        Customer Mpho = new Customer("209 Orange str", "Joburg", "Gauteng", "SA", "Mpho");
        Product textbooks = new Product("Maths textbook", "MATH45", 250, 1);
        Product smartwatch = new Product("Redmi", "Xiaomi34", 500, 2);
        Product shoes = new Product("Adidas", "ADI578", 200, 2);

        List<Product> productForMpho = new List<Product> { textbooks, smartwatch, shoes };

        Customer Karabo = new Customer("5th str", "New York", "NY", "USA", "Karabo");
        Product laptop = new Product("Laptop", "P001", 1000, 1);
        Product mouse = new Product("Mouse", "P002", 20, 2);
        Product keyboard = new Product("Keyboard", "P003", 50, 1);

        List<Product> productsForKarabo = new List<Product> { laptop, mouse, keyboard };

        Order order1 = new Order(Mpho, productForMpho);
        Order order2 = new Order(Karabo, productsForKarabo);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total cost is :$ {order1.TotalCost():F2}");

        
        Console.WriteLine("<--------------------------------------------------------------------->");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total cost is :$ {order2.TotalCost():F2}");
    }

}