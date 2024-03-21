public class ReflectingActivity : Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    
    public ReflectingActivity(string name, string description, int duration):base(name, description, duration){
        //Constructor initializes both lists with defaul values. Name, description and duration are handled by the
        //base class constructor and are set in the main program as specified.
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        //Initializing trhe values inside the question list with multiple questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }
    public void Run(){
        Console.Clear();
        DisplayStartingMesagge();
        Console.WriteLine("\nHow Long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        
        //Displaying Prompt
        DisplayPrompt();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        Console.Clear();
        while (DateTime.Now<endTime){
            DisplayQuestions();
        }

        Console.WriteLine("\n");
        DisplayEndingMesagge();
    }
    private string GetRandomPrompt(){
        Random rd = new Random();
        return _prompts[rd.Next(0,_prompts.Count)];
    }
    private void DisplayPrompt(){
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.WriteLine("When you have somehting in mind, press enter to continue. ");
        Console.ReadLine();
    }
    private string GetRandomQuestion(){
        Random rd = new Random();
        return _questions[rd.Next(0,_questions.Count)];
    }
    private void DisplayQuestions(){
        Console.Write($"\n-->{GetRandomQuestion()} ");
        ShowSpinner(9);
    }
}