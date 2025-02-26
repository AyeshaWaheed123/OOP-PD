using System;
using PDWEEK_5_1.BL;
class CustomerUI
{
    public static void CustomerMenu(CustomerBL customer)
    {
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Customer Menu");
            Console.WriteLine($"Welcome, {customer.username}");
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Buy Product");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4. View Profile");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                ProductUI.ViewAllProducts();
            }
            else if (choice == 2)
            {
                BuyProduct(customer);
            }
            else if (choice == 3)
            {
                GenerateInvoice(customer);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Customer Profile:");
                Console.WriteLine($"Username: {customer.username}");
                Console.WriteLine($"Email: {customer.email}");
                Console.WriteLine($"Address: {customer.address}");
                Console.WriteLine($"Contact: {customer.contact}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } while (choice != 5);
    }

    static void BuyProduct(CustomerBL customer)
    {
        Console.Write("Enter Product Name to Buy: ");
        string productName = Console.ReadLine();
        ProductBL product = ProductDL.GetProductByName(productName);
        if (product != null)
        {
            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            if (quantity <= product.stock)
            {
                float salesTax = product.CalculateSalesTax();
                float totalCost = (product.price + salesTax) * quantity;
                product.stock -= quantity;
                ProductDL.SaveProducts();
                OrderDL.AddOrder(customer.username, product.name, quantity, totalCost);
                Console.WriteLine($"Order placed successfully! Total Cost: ${totalCost}");
            }
            else
            {
                Console.WriteLine("Insufficient stock!");
            }
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    static void GenerateInvoice(CustomerBL customer)
    {
        Console.WriteLine("Invoice:");
        OrderDL.ViewCustomerOrders(customer.username);
    }
}
