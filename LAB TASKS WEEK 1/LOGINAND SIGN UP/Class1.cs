using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
namespace LOGINAND_SIGN_UP
{
    class Account
    {


        public void readdata(string[] names, string[] passwords)
        {
            int i = 0;
            string path = "D:\\vs\\login.txt";
            if (File.Exists(path))
            {
                string record;
                StreamReader data = new StreamReader(path);
                while ((record = data.ReadLine()) != null)
                {
                    names[i] = founddata(record, 1);
                    passwords[i] = founddata(record, 2);
                    i++;
                    if (i >= 5)
                    {
                        break;
                    }

                }
                data.Close();
            }
            else
            {
                Console.WriteLine("not found");
            }
           
        }
        public string founddata(string record, int field)

        {

            int comma = 1;

            string item = "";

            for (int x = 0; x < record.Length; x++)

            {

                if (record[x] == ',')

                {

                    comma++;

                }

                else if (comma == field)

                {

                    item = item + record[x];

                }

            }

            return item;

        }
        public bool logIn(string n, string p, string[] names, string[] password)

        {

            bool flag = false;

            for (int x = 0; x < 5; x++)

            {
if (n == names[x] && p == password[x])

                {

                    Console.WriteLine("Valid User");

                    flag = true;

                }

            }

            if (flag == false)

            {

                Console.WriteLine("Invalid User");

            }

            Console.ReadKey();
            return flag;
        }
        public void signin(string username, string password)
        {
            string path = "D:\\vs\\login.txt";
            if (File.Exists(path))
            {
                StreamWriter n = new StreamWriter(path, true);
                n.WriteLine(username + "," + password);
                n.Flush();
                n.Close();


            }
        }

    }
}


