using System.Runtime.CompilerServices;
public class Entry{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _location;
    public string _emotionalState;
    public void Display(){
        Console.WriteLine("");
        Console.WriteLine($" - Date: {_date} Feeling {_emotionalState} - \n - Prompt: {_promptText} - \n - Response: {_entryText} - \n - Wrote from: {_location} - ");
        Console.WriteLine("");
    }
}
