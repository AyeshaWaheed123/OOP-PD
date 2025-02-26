using PDWEEK_5_1.BL;
using System;

class Program
{
    static void Main()
    {
        // Load data from files
        ProductDL.LoadProducts();
        CustomerDL.LoadCustomers();
        AdminDL.LoadAdmin();

        // If no admin exists, create a default admin
        if (AdminDL.admin == null)
        {
            AdminDL.admin = new AdminBL("admin", "adminpass");
            AdminDL.SaveAdmin();
        }

        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to Departmental Store Management System!");
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
                SignIn();
            else if (option == 2)
                SignUp();
        } while (option != 3);
    }

    static void SignIn()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        // Check Admin credentials first
        if (AdminDL.admin != null && AdminDL.admin.username.Equals(username, StringComparison.OrdinalIgnoreCase) && AdminDL.admin.password == password)
        {
            Console.WriteLine("Admin login successful!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            AdminUI.AdminMenu();
        }
        else
        {
            CustomerBL customer = CustomerDL.ValidateCustomer(username, password);
            if (customer != null)
            {
                Console.WriteLine("Customer login successful!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                CustomerUI.CustomerMenu(customer);
            }
            else
            {
                Console.WriteLine("Invalid credentials! Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static void SignUp()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();
        Console.Write("Enter Address: ");
        string address = Console.ReadLine();
        Console.Write("Enter Contact Number: ");
        string contact = Console.ReadLine();

        CustomerBL newCustomer = new CustomerBL(username, password, email, address, contact);
        CustomerDL.AddCustomer(newCustomer);
        Console.WriteLine("Signup successful! Press any key to continue...");
        Console.ReadKey();
    }
}
