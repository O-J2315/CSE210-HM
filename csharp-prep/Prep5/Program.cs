using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName(){
            Console.WriteLine("Enter your username: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromtUserNumber(){
            Console.WriteLine("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number){
            int SquareNumber = number*number;
            return SquareNumber; 
        }
        static void DisplayResult(){
            DisplayWelcome();
            Console.WriteLine($"Brother {PromptUserName()}, the square of your number is {SquareNumber(PromtUserNumber())}");
        }

        DisplayResult();

    }
}