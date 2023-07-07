public class Customer {

    private string _name;
    private Address _address;

    public Customer() {
        _address = new Address();
    }

    public string GetName() {
        return _name;
    }

    public Address GetAddress() {
        return _address;
    }

    public void SetName(string name) {
        _name = name;
    }

    public void SetAddress(string street, string city, string state, string country) {
        _address.SetStreet(street);
        _address.SetCity(city);
        _address.SetState(state);
        _address.SetCountry(country);
    }

    public bool LivingInUSA() {
        return _address.LivingInUSA();
    }

}