using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Secret magic number has been selected from 1 to 100");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int tries = 1;
        
        Console.WriteLine("What is your guess");
        int guess = int.Parse(Console.ReadLine());

        while (guess!=number){
            if (number>guess){
                Console.WriteLine("Higher");
            }else if (number<guess){
                Console.WriteLine("Lower");
            }
            Console.WriteLine("What is your guess");
            guess = int.Parse(Console.ReadLine());
            tries ++;
        }

        Console.WriteLine($"Perfect you guessed it in {tries} tries!");



    }
}