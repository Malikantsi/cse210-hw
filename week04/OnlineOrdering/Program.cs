using System;

class Program
{
    static void Main(string[] args)
    {
        Customer Mpho = new Customer("209 Orange str", "Joburg", "Gauteng", "SA", "Mpho");
        Product Textbooks = new Product("Math for all", "MATH45", 250, 1);
        Product Smartwatch = new Product("Redmi", "Xiaomi34", 1500, 2);
        Product shoes = new Product("Adidas", "ADI578", 2000, 2);

        List<Product> productForMpho = new List<Product> { Textbooks, Smartwatch, shoes };

        Order order1 = new Order(Mpho, productForMpho);

        Mpho.GetFullAddress();
    }
}