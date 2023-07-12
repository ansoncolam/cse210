using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order order1 = new Order();
        order1.SetCustomerName("Peter Chan");
        order1.SetCustomerAddress("123 Apple Street", "Tower Town", "HI", "USA");
        Product product1 = new Product("Cup", "00001", 5, 2);
        Product product2 = new Product("Lamp", "00002", 10, 1);
        Product product3 = new Product("Pen", "00003", 2, 5);

        orders.Add(order1);
        order1.GetProductList().Add(product1);
        order1.GetProductList().Add(product2);
        order1.GetProductList().Add(product3);

        Order order2 = new Order();
        order2.SetCustomerName("Diana Andrews");
        order2.SetCustomerAddress("444 Round Circle", "Eastwood", "NSW", "Australia");
        Product product4 = new Product("Book", "00004", 20, 2);
        Product product5 = new Product("DVD Player", "00005", 30, 1);

        orders.Add(order2);
        order2.GetProductList().Add(product4);
        order2.GetProductList().Add(product5);

        foreach(Order order in orders) {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Customer Name: {order.GetCustomerName()}");
            Console.WriteLine("");
            order.PackingLabel();
            order.ShippingLabel();
            order.TotalPrice();
        }

    }
}