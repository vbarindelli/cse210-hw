public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public string getName()
    {
        return _name;
    }

    public string getProductId()
    {
        return _productId;
    }
    public float getPrice()
    {
        return _price;
    }
    public float getQuantity()
    {
        return _quantity;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public void setProductId(string productId)
    {
        _productId = productId;
    }
    public void setPrice(float price)
    {
        _price = price;
    }
    public void setQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public float GetTotalCost()
    {
        return _price*_quantity;
    }




}