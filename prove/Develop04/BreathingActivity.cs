public class BreathingActivity : Activity {
    public BreathingActivity(string name, string description, int duration):base(name, description, duration){
        //This constructor is empty because base constructor in the parent class is taking care of assigning the memeber variables values.
    }
    public void Run(){
        Console.Clear();
        DisplayStartingMesagge();
        Console.WriteLine("\nHow Long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now<endTime){
            Console.Write("Breathe In...");
            ShowCountDown(4);

            Console.Write("\nNow breath out...");
            ShowCountDown(4);
            Console.WriteLine("\n");
        }
        DisplayEndingMesagge();
    }
}