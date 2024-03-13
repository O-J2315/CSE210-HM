using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Reference theReference = new Reference("1 Nefi", 3, 7);
        Scripture theScripture = new Scripture(theReference,"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        string ans = "";
        while (ans!="quit"){
            Console.Clear();
            Console.WriteLine(theScripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            ans = Console.ReadLine();
            if(theScripture.IsCompletelyHidden() || ans=="quit"){
                            break;
            }else{
                theScripture.HideRandomWords(4);
            }
        }
    }
}