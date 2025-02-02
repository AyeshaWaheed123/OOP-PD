using System.Collections.Generic;
using System;
namespace LOGINAND_SIGN_UP
{
    public class AdminMenu
    {
        public List<Customer> customers = new List<Customer>();

        public void ShowAdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Admin Menu ---");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. View Customers");
                Console.WriteLine("3. Delete Customer");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                if (choice == "1") AddCustomer();
                else if (choice == "2") ViewCustomers();
                else if (choice == "3") DeleteCustomer();
                else if (choice == "4") break;
                else Console.WriteLine("Invalid option. Try again.");
            }
        }

        public void AddCustomer()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();
            customers.Add(new Customer(name));
            Console.WriteLine("Customer added successfully!");
        }

        public void ViewCustomers()
        {
            Console.WriteLine("\n--- Customer List ---");
            if (customers.Count == 0) Console.WriteLine("No customers found.");
            else
            {
                foreach (var customer in customers)
                {
                    Console.WriteLine($"- {customer.Name}");
                }
            }
        }

        public void DeleteCustomer()
        {
            Console.Write("Enter customer name to delete: ");
            string name = Console.ReadLine();
            var customer = customers.Find(c => c.Name == name);
            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine("Customer deleted successfully!");
            }
            else Console.WriteLine("Customer not found.");
        }
    }

    // ✅ User Menu for Viewing Customers
    public class UserMenu
    {
        private List<Customer> customers;

        public UserMenu(List<Customer> customers)
        {
            this.customers = customers;
        }

        public void ShowUserMenu()
        {
            Console.WriteLine("\n--- User Menu ---");
            Console.WriteLine("Viewing all customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"- {customer.Name}");
            }
        }
    }
}