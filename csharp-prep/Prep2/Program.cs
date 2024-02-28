using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradetext = Console.ReadLine();
        int gradeNumber = int.Parse(gradetext);
        string grade = "A";

        if (gradeNumber>= 90){
            grade = "A";
        }else if (gradeNumber>= 80){
            grade = "B";
        }else if (gradeNumber>=70){
            grade = "C";
        }else if (gradeNumber>=60){
            grade = "D";
        }else if (gradeNumber<60){
            grade = "F";
        }

        if (gradeNumber<70){
            Console.WriteLine($"{gradetext}% is assigned to {grade}. You did not pass the class. We encourage you to try best for next semester.");
        }else {
            Console.WriteLine($"{gradetext}% is assigned to {grade}. Congratulations! You passed the class. Great Job!");
        }



    }
}