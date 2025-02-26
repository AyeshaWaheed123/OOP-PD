using System.Collections.Generic;
using System;
using System.IO;

class ProductDL
{
    public static List<ProductBL> products = new List<ProductBL>();

    public static void LoadProducts()
    {
        if (File.Exists("products.txt"))
        {
            string[] lines = File.ReadAllLines("products.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length >= 5)
                {
                    products.Add(new ProductBL(data[0], data[1], float.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));
                }
            }
        }
    }

    public static void SaveProducts()
    {
        List<string> lines = new List<string>();
        foreach (ProductBL p in products)
        {
            lines.Add($"{p.name},{p.category},{p.price},{p.stock},{p.threshold}");
        }
        File.WriteAllLines("products.txt", lines);
    }

    public static void AddProduct(ProductBL product)
    {
        products.Add(product);
        SaveProducts();
    }

    public static ProductBL GetMostExpensiveProduct()
    {
        ProductBL maxProduct = null;
        foreach (ProductBL p in products)
        {
            if (maxProduct == null || p.price > maxProduct.price)
            {
                maxProduct = p;
            }
        }
        return maxProduct;
    }

    public static List<ProductBL> GetLowStockProducts()
    {
        List<ProductBL> lowStock = new List<ProductBL>();
        foreach (ProductBL p in products)
        {
            if (p.stock < p.threshold)
            {
                lowStock.Add(p);
            }
        }
        return lowStock;
    }

    public static ProductBL GetProductByName(string productName)
    {
        foreach (ProductBL p in products)
        {
            if (p.name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                return p;
        }
        return null;
    }
}
