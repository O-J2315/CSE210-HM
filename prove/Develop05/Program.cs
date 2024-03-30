//Added for extra credit: 
//Animations done in past assignments. (The spinner).
//Added leveling up behavior to the goal manager class. Everytime you record an event or load your goals it gets updated.
//When the user levels up a message appears and new level name is given. Better accomodation of elements and spacing when displaying the information.
//Added a way to handle exceptions and mistakes when no goals have been created or selected to ensure the program still runs even in those scenarios.

using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager josue = new GoalManager();
        josue.Start();
    }
}