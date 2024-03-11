using System;

class Program
{
    static void Main(string[] args)
    {
        Fracction fracction = new Fracction();
        Console.WriteLine(fracction.GetFraccionString());
        Console.WriteLine(fracction.GetDecimalValue());

        Fracction fraccionTwo = new Fracction(5);
        Console.WriteLine(fraccionTwo.GetFraccionString());
        Console.WriteLine(fraccionTwo.GetDecimalValue());

        Fracction fraccionThree = new Fracction(3, 4);
        Console.WriteLine(fraccionThree.GetFraccionString());
        Console.WriteLine(fraccionThree.GetDecimalValue());

        Fracction fraccionFour = new Fracction(1,3);
        Console.WriteLine(fraccionFour.GetFraccionString());
        Console.WriteLine(fraccionFour.GetDecimalValue());


    }
}