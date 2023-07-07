public class Product {

    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity) {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName() {
        return _productName;
    }

    public string GetProductId() {
        return _productId;
    }

    public double GetProductPrice() {
        return _price;
    }

    public int GetProductQuantity() {
        return _quantity;
    }

    public double IndividualPrice() {
        double total = _price * _quantity;
        return total;
    }

}