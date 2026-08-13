// W04 Assignment: Online Ordering Program - CSE210hw2026
// This program simulates an online ordering system where customers can place orders for products.
// It calculates the total cost of the order, including shipping costs based on the customer's location (USA or international).
//I have included comments for my markings and guide. I apologize for sending my assignment late due to my preparation and after happenings of our wedding. Thank you.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1: Ichigo Kurosaki (USA)
        Address addr1 = new Address("123 Karakura Town", "Karakura", "NY", "USA");
        Customer cust1 = new Customer("Ichigo Kurosaki", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Zanpakuto Sword", "Z123", 500, 1));
        order1.AddProduct(new Product("Soul Badge", "S456", 50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");
        Console.WriteLine();

        // Customer 2: Rukia Kuchiki (International)
        Address addr2 = new Address("456 Seireitei District", "Soul Society", "West Rukongai", "Japan");
        Customer cust2 = new Customer("Rukia Kuchiki", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Kido Spellbook", "K789", 120, 1));
        order2.AddProduct(new Product("Gigai Suit", "G321", 300, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}

