using System;

class Program
{
    static void Main(string[] args)
    {
        Admin josueAdmin = new Admin();
        Console.WriteLine("Insert User Name: ");
        string username = Console.ReadLine();
        Console.WriteLine("Insert Password: ");
        string password = Console.ReadLine();
        josueAdmin.Start(username,password);
        
    }
}