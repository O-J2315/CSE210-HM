using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class Reference {

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book,int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
        }
    public Reference(string book,int chapter, int verse,int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetDisplayText(){
        string reference = "";
        if(_endVerse==0){
            reference = $"{_book} {_chapter}:{_verse}";
            
        }else if(_endVerse!=0){
            reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    return reference;
    }
}