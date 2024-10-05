using System.Runtime;

public class Product
{
    // initialize member attributes
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    // creates constructor that takes arguments for the member attributes and populates those attributes.
    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // getter method to populate _name member attribute.
    public string GetProductName()
    {
        return _name;
    }

    // getter method to populate _productID member attribute.
    public int GetProductID()
    {
        return _productID;
    }

    // method multiplies the price by the quantitiy and then formats the result to appear in currency format as a string and prints the result to the screen.
    public string TotalCostFormatted()
    {
        double total = _price * _quantity;
        string formattedTotal = total.ToString("C2");
        return formattedTotal;
    }

    // method multiplies price by quantity and returns the resulting double total.
    public double TotalCost()
    {
        double total = _price * _quantity;
        return total;
    }
}