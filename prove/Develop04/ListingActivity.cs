using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts = new List<string>();
    
    public ListingActivity(string name, string description, int duration):base(name, description, duration){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Run(){
        Console.Clear();
        DisplayStartingMesagge();
        Console.WriteLine("\nHow Long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        List<string> userList = GetListFromUser();
        foreach(string item in userList){
            _count++;
        }
        Console.WriteLine($"You entered {_count} items!");

        Console.WriteLine($"\n");
        DisplayEndingMesagge();
    }
    private string GetRandomPrompt(){
        Random rd = new Random();
        return _prompts[rd.Next(0,_prompts.Count)];
    }
    private void DisplayPrompt(){
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"--{GetRandomPrompt()}--");
    }
    private List<string> GetListFromUser(){
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now;
        DateTime finalTime = endTime.AddSeconds(GetDuration());
        
        Console.WriteLine();
        while (DateTime.Now < finalTime){
            Console.Write(">");
            string item = Console.ReadLine();
            userList.Add(item);
        }
        return userList;
    }
}