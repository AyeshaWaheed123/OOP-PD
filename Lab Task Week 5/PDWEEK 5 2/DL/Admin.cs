using System.IO;           // <-- Make sure you have this for File I/O
using PDWEEK_5_1.BL;      // <-- Namespace where AdminBL is defined

class AdminDL
{
    public static AdminBL admin;

    public static void LoadAdmin()
    {
        if (File.Exists("admin.txt"))
        {
            string content = File.ReadAllText("admin.txt");
            string[] data = content.Split(',');
            if (data.Length >= 2)
            {
                // Create a new AdminBL object from the file data
                admin = new AdminBL(data[0], data[1]);
            }
        }
    }

    public static void SaveAdmin()
    {
        if (admin != null)
        {
            // Save admin credentials to admin.txt
            File.WriteAllText("admin.txt", $"{admin.username},{admin.password}");
        }
    }
}
