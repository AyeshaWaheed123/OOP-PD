using System;
using System.Collections.Generic;

namespace LOGINAND_SIGN_UP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdminMenu admin = new AdminMenu();
            string[] names = new string[5];
            string[] passwords = new string[5];
  while (true)
            {
                int option = menu();
                register(option, names, passwords);
                Console.WriteLine("\n--- Main Menu ---");
                        Console.WriteLine("1. Admin");
                        Console.WriteLine("2. User");
                        Console.WriteLine("3. Logout");
                        Console.Write("Choose an option: ");

                        string choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            admin.ShowAdminMenu();
                        }
                        else if (choice == "2")
                        {
                            UserMenu userMenu = new UserMenu(admin.customers);
                            userMenu.ShowUserMenu();
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("Logging out...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Try again.");
                        }
                    }
                }
            
           
        static int menu()
        {
            Console.WriteLine("\n    MENU");
            Console.WriteLine("1. LOGIN");
            Console.WriteLine("2. SIGN UP");
            Console.Write("Choose an option: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || (option != 1 && option != 2))
            {
                Console.WriteLine("Invalid input! Enter 1 for LOGIN or 2 for SIGN UP.");
            }
            return option;
        }

        static bool register(int option, string[] names, string[] passwords)
        {
            Account user = new Account();

            if (option == 1) { 
                Console.WriteLine("Enter the username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                string password = Console.ReadLine();
                user.readdata(names, passwords);

                if (user.logIn(username, password, names, passwords))
                {
                    Console.WriteLine("Login successful!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Login failed! Incorrect credentials.");
                    return false;
                }
            }
            else if (option == 2)  
            {
                Console.WriteLine("Enter the username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                string password = Console.ReadLine();
                user.signin(username, password);
                Console.WriteLine("Sign-up successful! Please log in now.");
                return false;
            }

            return false;
        }
    }
}
