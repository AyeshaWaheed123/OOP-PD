using System.Collections.Generic;
using System;

class AdminUI
{
    public static void AdminMenu()
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Admin Menu");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered (Low Stock)");
            Console.WriteLine("6. View Profile");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                ProductUI.AddProduct();
            else if (choice == 2)
                ProductUI.ViewAllProducts();
            else if (choice == 3)
            {
                ProductBL maxProduct = ProductDL.GetMostExpensiveProduct();
                if (maxProduct != null)
                    Console.WriteLine($"Most Expensive Product: {maxProduct.name} - ${maxProduct.price}");
                else
                    Console.WriteLine("No products available.");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Sales Tax of Products:");
                foreach (ProductBL p in ProductDL.products)
                {
                    Console.WriteLine($"{p.name}: ${p.CalculateSalesTax()}");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Low Stock Products:");
                List<ProductBL> lowStock = ProductDL.GetLowStockProducts();
                if (lowStock.Count > 0)
                {
                    foreach (ProductBL p in lowStock)
                    {
                        Console.WriteLine($"{p.name} - Stock: {p.stock} (Threshold: {p.threshold})");
                    }
                }
                else
                {
                    Console.WriteLine("No low stock products.");
                }
            }
            else if (choice == 6)
            {
                Console.WriteLine("Admin Profile:");
                Console.WriteLine($"Username: {AdminDL.admin.username}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } while (choice != 7);
    }
}
