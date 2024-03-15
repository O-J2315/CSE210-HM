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
    public Scripture(Scripture scripture){
        _reference = scripture._reference;
        _words = scripture._words;
    }
    public string GetDisplayText(){
        string wholeScripture = $"{_reference.GetDisplayText()} ";
        foreach(Word word in _words){
            wholeScripture += $"{word.GetDisplayText()} ";
        }
        return wholeScripture;
    }
    public void HideRandomWords(int numberOfHides){
        Random random = new Random();
        int x = 0;
        List<int> unUsedWords = new List<int> ();

        for(int i=0; i<_words.Count; i++){
            unUsedWords.Add(i);
        }

        while (x < numberOfHides){
            int index = random.Next(0, unUsedWords.Count);
            if (!_words[index].IsHidden()){
                _words[index].Hide();
                unUsedWords.Remove(index);
                x+=1;
            }else if (IsCompletelyHidden()){
                x+=1;
            }
        }
    }
    public bool IsCompletelyHidden(){
        bool aWordIsHidden = true;

        foreach(Word word in _words){

            if(!word.IsHidden()){
                aWordIsHidden = false;
                break;
            }else{
                aWordIsHidden = true;
            }
        }
        return aWordIsHidden;
    }
}