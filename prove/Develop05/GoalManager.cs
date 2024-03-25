public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){

    }
    public void Start(){
        int ans = 1;
        do {
            Console.Clear();
            Console.WriteLine($"You have {_score} points\n");
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

    }
    public void ListGoalNames(){

    }
    public void ListGoalDetails(){

    }
    public void CreateGoal(){
        
    }
    public void RecordEvent(){

    }
    public void SaveGoals(){

    }
    public void LoadGoals(){

    }
}