using System.Reflection.Metadata;
using System.Runtime.InteropServices;

public class SpiritualActivity : Activity {
    private List<Scripture> _scriptures = new List<Scripture>();
    private List<string> _questions = new List<string>();
    public SpiritualActivity(string name, string description, int duration):base(name, description, duration){
        _scriptures.Add(new Scripture("John 3:16", "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life."));
        _scriptures.Add(new Scripture("Joshua 1:9", "Have I not commanded you? Be strong and courageous. Do not be frightened, and do not be dismayed, for the LORD your God is with you wherever you go."));
        _scriptures.Add(new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge Him, and He will make straight your paths."));
        _scriptures.Add(new Scripture("Isaiah 41:13", "For I, the LORD your God, hold your right hand; it is I who say to you, 'Fear not, I am the one who helps you."));
        _scriptures.Add(new Scripture("Moroni 7:33", "And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me."));
        _scriptures.Add(new Scripture("John 14:27", "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid."));
        _scriptures.Add(new Scripture("1 Nephi 20:10", "For, behold, I have refined thee, I have chosen thee in the furnace of affliction."));
        _scriptures.Add(new Scripture("2 Nephi 2:25", "Adam fell that men migh be; and men are, that they might have joy."));
        _scriptures.Add(new Scripture("James 1:3", "Knowig this, that the trying of your faith worketh patience."));
        _scriptures.Add(new Scripture("1 Timothy 4:12", "Let no man depsise thy youth; but be thou an example of the believers, in word, in conversation, in charity, in spirit, in faith, in purity."));

        _questions.Add("--How is my relationship with the Savior JesusChrist? --");
        _questions.Add("--What could I do to come unto Christ?--");
        _questions.Add("--What could you do to help someone else come unto Christ?--");
        _questions.Add("--What could you do if you had more faith?--");
        _questions.Add("--If the Savior stood beside you, what would you tell Him?--");
        _questions.Add("--Have you prayed today?--");
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

        Scripture scripture1 = GetRandomScripture();
        Console.WriteLine($"Think about the following scripture in {scripture1.GetReference()}");
        Console.WriteLine($">>{scripture1.GetText()}>>\nPress Enter when you are ready!");
        Console.ReadLine();
        Console.Write("\nLet's begin in: ");
        ShowCountDown(5);
        Console.WriteLine("\nAs you meditate in this scripture...");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now<endTime){
            DisplayQuestions();
        }
        Console.WriteLine($"\n--What do you feel motivated to do now?--");
        ShowSpinner(5);
        DisplayEndingMesagge();
    }
    private Scripture GetRandomScripture(){
        Random rd = new Random();
        int counter = rd.Next(0, _scriptures.Count);
        return _scriptures[counter];
    }
    private string GetRandomQuestion(){
        Random rd = new Random();
        return _questions[rd.Next(0,_questions.Count)];
    }
    private void DisplayQuestions(){
        Console.Write($"\n{GetRandomQuestion()} ");
        ShowSpinner(10);
    }
}