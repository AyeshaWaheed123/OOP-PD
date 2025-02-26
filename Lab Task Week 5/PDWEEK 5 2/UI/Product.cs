using System;

class ProductUI
{
    public static void AddProduct()
    {
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Category (Grocery, Fruit, Other): ");
        string category = Console.ReadLine();
        Console.Write("Enter Price: ");
        float price = float.Parse(Console.ReadLine());
        Console.Write("Enter Stock Quantity: ");
        int stock = int.Parse(Console.ReadLine());
        Console.Write("Enter Minimum Threshold: ");
        int threshold = int.Parse(Console.ReadLine());

        ProductBL product = new ProductBL(name, category, price, stock, threshold);
        ProductDL.AddProduct(product);
        Console.WriteLine("Product added successfully!");
    }

    public static void ViewAllProducts()
    {
        Console.WriteLine("Products List:");
        foreach (ProductBL p in ProductDL.products)
        {
            Console.WriteLine($"{p.name} - {p.category} - ${p.price} - Stock: {p.stock} - Threshold: {p.threshold}");
        }
    }
}
