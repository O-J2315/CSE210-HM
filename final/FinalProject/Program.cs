using System;
class Program
{
    static void Main(string[] args)
    {
        Admin josueAdmin = new Admin();
        //Just to have some protection in the information I added a simple username and password login.  
        Console.WriteLine("Insert User Name: ");
        string username = Console.ReadLine();
        Console.WriteLine("Insert Password: ");
        string password = Console.ReadLine();
        josueAdmin.Start(username,password);
    }
}