using System.IO; 
public class GoalManager {
    
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){

    }
    public void Start(){
        int ans = 1;
        do {
            //Console.Clear();
            Console.Write($"You have ");
            DisplayPlayerInfo();
            Console.Write(" points!\n\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit:)");
            Console.WriteLine("Chose from the menu option: ");
            int action = int.Parse(Console.ReadLine());
            switch(action){
                case 1:
                    CreateGoal();
                break;
                case 2:
                    ListGoalDetails();
                break;
                case 3:
                    SaveGoals();
                break;
                case 4:
                    LoadGoals();
                break;
                case 5:
                    RecordEvent();
                break;
                case 6:
                    ans = 0;
                break;
            }
        } while (ans > 0);
        
    }
    public void DisplayPlayerInfo(){
        Console.Write(_score);
    }
    public void ListGoalNames(){
        foreach(Goal goal in _goals){
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails(){
        Console.Clear();
        int counter = 0;
        foreach (Goal goal in _goals){
            counter++;
            Console.WriteLine($" {counter}. {goal.GetDetailsString()}");
        }
        Console.WriteLine("-----------------------------------------------------------------------");
    }
    public void CreateGoal(){
        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. checklist Goal");
        Console.WriteLine("Wich type of goal do you want to create?");
        int ans = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();
        switch (ans){
            case 1:
                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(newSimpleGoal);
            break;
            case 2:
                EternalGoal newEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(newEternalGoal);
            break;
            case 3:
                Console.WriteLine("How many times to accomplish this goal?");
                int targetGoal = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for completing this goal?");
                int bonusGoal = int.Parse(Console.ReadLine());
                ChecklistGoal newListGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, targetGoal, bonusGoal);
                _goals.Add(newListGoal);
            break;
            default:
                Start();
            break;
        }
    }
    public void RecordEvent(){
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.WriteLine("Wich goal did you accomplish? ");
        int goalAccomplished = int.Parse(Console.ReadLine());
        int addPoints = _goals[goalAccomplished-1].RecordEvent();
        Console.WriteLine($"\nCongratulations! You have earned {addPoints} points!:D");
        _score += addPoints;
    }
    public void SaveGoals(){
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($@"C:\Users\nahom\OneDrive\Escritorio\journals\{fileName}")){
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals){
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals(){
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($@"C:\Users\nahom\OneDrive\Escritorio\journals\{fileName}");

        _score = int.Parse(lines[0]);
        for (int index = 1; index < lines.Length; index++){

            string[] parts = lines[index].Split(",");
            string goalType = parts[0];
            if(goalType=="SimpleGoal"){
                SimpleGoal newSimpleGoal = new SimpleGoal(parts[1],parts[2],parts[3],parts[4]);
                _goals.Add(newSimpleGoal);
            }else if(goalType == "EternalGoal"){
                EternalGoal newEternalGoal = new EternalGoal(parts[1],parts[2],parts[3]);
                _goals.Add(newEternalGoal);
            }else if(goalType == "ChecklistGoal"){
                ChecklistGoal newlistGoal = new ChecklistGoal(parts[1],parts[2],parts[3],int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]));
                _goals.Add(newlistGoal);
            }
        }
    }
}