public class Order
{
    // initializes member attributes of customer object and list of product objects.
    private Customer _customer = new Customer();
    private List<Product> _products = new List<Product>();
    
    // Constructor that passes an argument for the customer object and assigns it to the member attribute _customer.
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Setter method to set object customer to _customer attribute.
    public void SetCustomer(Customer customer)
    {
        Customer _customer = customer;
    }

    // Setter method that adds product object to _products list.
    public void StoreProduct(Product product)
        {
            _products.Add(product);
        }

    // Method that calculates the total cost of the order and returns a formatted string. Formatted to appear as currency. 
    public string TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        double shipping;

        bool inUSA = _customer.InUSA();
        if (inUSA == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        
        total += shipping;
        string formattedTotal = total.ToString("C2");
        return formattedTotal;
    }

    // Method to generate a packing label for the order.
    public string GetPackingLabel()
    {
       string label = "";
       foreach (Product product in _products)
       {
            label += $"Product: {product.GetProductName()}\r\nProduct ID: {product.GetProductID()}\r\n";
       }

        return label;

    }

    // Method to generate a shipping label for the order.
    public string GetShippingLabel()
    {
        string label = $"Customer: {_customer.GetCustomerName()}\r\nAddress: \r\n{_customer.GetCustomerAddress()}";

        return label;
    }
}