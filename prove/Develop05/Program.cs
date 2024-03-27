//Added for extra credit animations done in past assignments
//Added leveling up behavior to the goal manager class.
//Added a way to handle exceptions and mistakes when no goals have been created or selected.
//When the user levels up a message appears and new level name is given.
using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager josue = new GoalManager();
        josue.Start();
    }
}