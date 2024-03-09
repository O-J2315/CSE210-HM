//Added to my program a way to handle when a file already exists to not override it but instead to be able to append the 
//new entries to the file that already exists.
//Added more information to store in each entri. Location and Emotional state. As if the entry was a social media post. That way
//the youger people would feel more enthusiat about wrtiting to a journal. A special format for each display was also arranged by me.
 

using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {   
        bool endProgram = false;
        Journal myJournal = new Journal();
        PromptGenerator aPrompt = new PromptGenerator();
        aPrompt._prompts.Add("Who was the most interesting person I interacted with today?");
        aPrompt._prompts.Add("What was the best part of my day?");
        aPrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        aPrompt._prompts.Add("What was the strongest emotion I felt today?");
        aPrompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        aPrompt._prompts.Add("What are you thinking and why are you thinking about that?");

        Console.WriteLine("WELCOME TO THE JOURNAL\n");
        while (!endProgram){
            Console.WriteLine("Please select one of the following choices: \n");
            Console.WriteLine("1. Write an entry to your journal");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Load the Journal");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Exit");
            int answer = int.Parse(Console.ReadLine());
            switch(answer){
                case 1:
                    Entry anEntry = new Entry();
                    anEntry._promptText = aPrompt.GetRandomPrompt();
                    Console.WriteLine(anEntry._promptText);
                    anEntry._entryText = Console.ReadLine();
                    Console.WriteLine("Location right now: ");
                    anEntry._location = Console.ReadLine();
                    Console.WriteLine("Emotional state: ");
                    anEntry._emotionalState = Console.ReadLine();
                    DateTime thisDay = DateTime.Now;
                    anEntry._date = thisDay.ToString("f");
                    myJournal.AddEntry(anEntry);
                break;

                case 2:
                    myJournal.DisplayAll();
                break;

                case 3:
                    Console.WriteLine("Enter the name of the file: ");
                    myJournal.LoadFromFile(Console.ReadLine().ToLower());
                break;

                case 4:
                    Console.WriteLine("Enter the name of the file: ");
                    myJournal.SaveToFile(Console.ReadLine().ToLower());
                break;

                case 5:
                    endProgram = true;
                break;
            }
        }


    }
}