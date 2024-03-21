//Extra credit done creating a new activity and adding an extra class to represent a scripture object. Similar to last week assignment.
//Extra activity is a spiritual activity to relfect on the Savior Jesus Christ. Prompts a small scripture and selects random
//questions to present to the user for him to reflect.
using System;

class Program
{
    static void Main(string[] args)
    {
        //Initializing Default variables that will later be changed
        string activityName;
        string activityDescription;
        int activityDuration = 10;

        int choice = 1;
        while (choice!=0){
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Connect with the Savior");
            Console.WriteLine("  5. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    Console.Clear();
                    activityName="Breathing";
                    activityDescription="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity breathingAct = new BreathingActivity(activityName, activityDescription, activityDuration);
                    breathingAct.Run();
                break;

                case 2:
                    Console.Clear();
                    activityName="Reflecting";
                    activityDescription="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity reflectingAct = new ReflectingActivity(activityName, activityDescription, activityDuration);
                    reflectingAct.Run();
                break;

                case 3:
                 Console.Clear();
                    activityName="Listing";
                    activityDescription="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    ListingActivity listingAct = new ListingActivity(activityName, activityDescription, activityDuration);
                    listingAct.Run();
                break;

                case 4: 
                    Console.Clear();
                    activityName="Connecting with the Savior";
                    activityDescription="This activity will help you reflect on your current relationship with God and Jesuschrist while you meditate in a scripture.";
                    SpiritualActivity spiritualActivity = new SpiritualActivity(activityName, activityDescription, activityDuration);
                    spiritualActivity.Run();
                break;
                case 5:
                    choice = 0;
                break;
            }
        }
    }
}