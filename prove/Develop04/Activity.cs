public class Activity {
    private string _name;
    private string _description;
    private int _duration;
    public Activity() {
        _name = "Breathing";
        _description = "This is an activity to controll your breathing";
        _duration = 40;
    }
    public Activity(string name, string description, int duration){
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMesagge(){
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}");
    }
    public void DisplayEndingMesagge(){
        Console.WriteLine($"Well Done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds){

        List<string> animationStrings = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime){
            String s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i>= animationStrings.Count){
                i=0;
            }
        } 
    }
    public void ShowCountDown(int seconds){
        for (int i = seconds; i>0; i--){
             Console.Write(i);
             Thread.Sleep(1000);
             Console.Write("\b \b");
        }
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
    public int GetDuration(){
        return _duration;
    }
}