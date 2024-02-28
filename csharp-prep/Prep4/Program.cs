using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 1;
        Console.WriteLine("Enter a list fo numerbs, type 0 when finished");
        while (newNumber!=0){
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber!=0){
                numbers.Add(newNumber);
            }
        }
        float sum = numbers.Sum();
        double average = numbers.Average();
        int largestNum = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The Largest Number is: {largestNum}");

        Console.WriteLine("The original list is: ");
        foreach (int number in numbers){
            Console.Write($"{number}, ");
        }
        numbers.Sort();
        Console.WriteLine("");
        Console.WriteLine("The sorted list is: ");
         foreach (int number in numbers){
            Console.Write($"{number}, ");
        }
        
    }
}