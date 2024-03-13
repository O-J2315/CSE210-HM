using System.Security.Cryptography.X509Certificates;

public class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference theReference,string theText){
        _reference = theReference;

        string[] separators = new string[] {",", ".", "!", "\'", " ", "\'s"};
        foreach (string word in theText.Split(separators, StringSplitOptions.RemoveEmptyEntries)){
            Word aWord = new(word);
            _words.Add(aWord);
        }   
    }
    public string GetDisplayText(){
        string wholeScripture = $"{_reference.GetDisplayText()} ";
        foreach(Word word in _words){
            wholeScripture += $"{word.GetDisplayText()} ";
        }
        return wholeScripture;
    }
}