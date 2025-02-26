using System.Collections.Generic;
using System;
using System.IO;
class CustomerDL
{
    public static List<CustomerBL> customers = new List<CustomerBL>();

    public static void LoadCustomers()
    {
        if (File.Exists("customers.txt"))
        {
            string[] lines = File.ReadAllLines("customers.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length >= 5)
                {
                    customers.Add(new CustomerBL(data[0], data[1], data[2], data[3], data[4]));
                }
            }
        }
    }

    public static void SaveCustomers()
    {
        List<string> lines = new List<string>();
        foreach (CustomerBL c in customers)
        {
            lines.Add($"{c.username},{c.password},{c.email},{c.address},{c.contact}");
        }
        File.WriteAllLines("customers.txt", lines);
    }

    public static void AddCustomer(CustomerBL customer)
    {
        customers.Add(customer);
        SaveCustomers();
    }

    public static CustomerBL ValidateCustomer(string username, string password)
    {
        foreach (CustomerBL c in customers)
        {
            if (c.username.Equals(username, StringComparison.OrdinalIgnoreCase) && c.password == password)
                return c;
        }
        return null;
    }
}
