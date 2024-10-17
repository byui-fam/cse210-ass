public class Product
{
    private string productName;
    private string productID;
    private float price;
    private int quantity;

    public Product(string productName, string productID, float price, int quantity)
    {
        this.productName = productName;
        this.productID = productID;
        this.price = price;
        this.quantity = quantity;
    }

    public float GetTotalCost()
    {
        return price * quantity;
    }

    public string GetProductInfo()
    {
        return $"{productName} (ID: {productID}) - Price: ${price}, Quantity: {quantity}";
    }
}
