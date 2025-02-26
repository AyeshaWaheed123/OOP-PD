using System;
using System.IO;
using System.Collections.Generic;

class OrderDL
{
    public static void AddOrder(string username, string product, int quantity, float totalCost)
    {
        // Append the order information to orders.txt
        string line = $"{username},{product},{quantity},{totalCost}";
        File.AppendAllText("orders.txt", line + Environment.NewLine);
    }

    public static void ViewCustomerOrders(string username)
    {
        if (File.Exists("orders.txt"))
        {
            string[] orders = File.ReadAllLines("orders.txt");
            Console.WriteLine($"Orders for {username}:");
            foreach (string order in orders)
            {
                string[] data = order.Split(',');
                if (data.Length >= 4 && data[0].Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Product: {data[1]}, Quantity: {data[2]}, Total Price: {data[3]}");
                }
            }
        }
        else
        {
            Console.WriteLine("No orders found!");
        }
    }
}
