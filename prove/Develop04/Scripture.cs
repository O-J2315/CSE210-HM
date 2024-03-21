using System.Security.Cryptography.X509Certificates;
public class Scripture {
    private string _reference;
    private string _words;
    public Scripture(string theReference, string theText){
        _reference = theReference;
        _words = theText;
    }
    public string DisplayScripture(){
        return $"{_reference} {_words}";
    }
    public string GetReference(){
        return _reference;
    }
    public string GetText(){
        return _words;
    }
}