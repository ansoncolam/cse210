public class Order {

    private List<Product> _product;
    private Customer _customer;

    public Order() {
        _customer = new Customer();
        _product = new List<Product>();
    }

    public List<Product> GetProductList() {
        return _product;
    }

    public string GetCustomerName() {
        return _customer.GetName();
    }

    public void SetCustomerName(string name) {
        _customer.SetName(name);
    }

    public void SetCustomerAddress(string street, string city, string state, string country) {
        _customer.SetAddress(street, city, state, country);
    }

    public void TotalPrice() {
        double totalPrice = 0;
        Console.WriteLine("----- Price of the Order -----");
        foreach(Product product in _product) {
            double price = product.IndividualPrice();
            totalPrice = totalPrice + price;
        }
        Console.WriteLine($"Price: ${totalPrice}");
        if (_customer.LivingInUSA() == true) {
            totalPrice = totalPrice + 5;
            Console.WriteLine("Shipping: $5");
        } else if (_customer.LivingInUSA() == false) {
            totalPrice = totalPrice + 35;
            Console.WriteLine("Shipping: $35");
        }
        Console.WriteLine($"Total Price: ${totalPrice}");
        Console.WriteLine("");
    }

    public void PackingLabel() {
        int i = 1;
        Console.WriteLine("----- Packing Label -----");
        foreach(Product product in _product) {
            Console.Write($"  {i}. ");
            Console.WriteLine($"{product.GetProductName()}({product.GetProductId()})");
            i = i + 1;
        }
        Console.WriteLine("");
    }

    public void ShippingLabel() {
        Console.WriteLine("----- Shipping Label -----");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().ReturnAddress());
        Console.WriteLine("");
    }

}