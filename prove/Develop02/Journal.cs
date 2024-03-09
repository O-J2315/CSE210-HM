using System.IO;
using System.IO.Enumeration;
public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry){
        this._entries.Add(entry);
    }

    public void DisplayAll(){
        foreach(Entry entry in _entries){
            entry.Display();
        }
    }

    public void SaveToFile(string file){

        
        string fileName = $@"C:\Users\nahom\OneDrive\Escritorio\journals\{file}.txt";
        
        if (!File.Exists(fileName)){
            using (StreamWriter streamWriter = File.CreateText(fileName)){
                streamWriter.WriteLine("WELCOME TO THE JOURNAL - HERE ARE YOUR ENTRIES:");
                foreach(Entry entry in _entries){
                    streamWriter.WriteLine($" - Date: {entry._date} Feeling {entry._emotionalState} - \n - Prompt: {entry._promptText} - \n - Response: {entry._entryText} - \n - Wrote from: {entry._location} - ");
                }
                Console.WriteLine($"\n{file} Has been saved to path: {fileName}");
                Console.WriteLine("");
            }
        }else {
            using(StreamWriter streamWriter = File.AppendText(fileName)){
                foreach(Entry entry in _entries){
                    streamWriter.WriteLine($" - Date: {entry._date} Feeling {entry._emotionalState} - \n - Prompt: {entry._promptText} - \n - Response: {entry._entryText} - \n - Wrote from: {entry._location} - ");
                }
                Console.WriteLine($"\nChanges to {file} have been sucessfully saved\n");
            }
        }
    }

    public void LoadFromFile(string file){
        string fileName = $@"C:\Users\nahom\OneDrive\Escritorio\journals\{file}.txt";

        if(File.Exists(fileName)){
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
            _entries.Clear();
        }else{
            Console.WriteLine($"{file} File located in the directory: {fileName} was not found\n");
        }
    }
}