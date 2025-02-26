class ProductBL
{
    public string name;
    public string category;
    public float price;
    public int stock;
    public int threshold;

    public ProductBL(string name, string category, float price, int stock, int threshold)
    {
        this.name = name;
        this.category = category;
        this.price = price;
        this.stock = stock;
        this.threshold = threshold;
    }

    public float CalculateSalesTax()
    {
        if (category == "Grocery")
            return price * 0.10f;
        else if (category == "Fruit")
            return price * 0.05f;
        else
            return price * 0.15f;
    }
}
