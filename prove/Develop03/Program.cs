//Added a new class Library that stores a list of scriptures in order to randomly select a different one each time the program starts again.
//Also exceeding the requirements by randomly selecting the words to hidde from only the words that are not already hidden.


using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Library favScriptures = new Library();

        Reference theReference = new Reference("1 Nephi", 3, 7);
        Scripture aScripture = new Scripture(theReference,"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        favScriptures.AddScripture(aScripture);
        theReference = new Reference("3 Nephi" , 11, 10, 11);
        aScripture = new Scripture(theReference, "Behold, I am Jesus Christ, whom the prophets testified shall come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the Father in all things from the beginning.");
        favScriptures.AddScripture(aScripture);
        theReference = new Reference("Alma" , 7, 11);
        aScripture = new Scripture(theReference, "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.");
        favScriptures.AddScripture(aScripture);
        theReference = new Reference("1 Nephi" , 17, 50);
        aScripture = new Scripture(theReference, "And I said unto them: If God had commanded me to do all things I could do them. If he should command me that I should say unto this water, be thou earth, it should be earth; and if I should say it, it would be done.");
        favScriptures.AddScripture(aScripture);
        theReference = new Reference("Ether" , 3, 5);
        aScripture = new Scripture(theReference, "Behold, O Lord, thou canst do this. We know that thou art able to show forth great power, which looks small unto the understanding of men.");
        favScriptures.AddScripture(aScripture);
        theReference = new Reference("Mosiah" , 2, 17);
        aScripture = new Scripture(theReference, "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
        favScriptures.AddScripture(aScripture);
        theReference = new Reference("Moroni" , 7, 47);
        aScripture = new Scripture(theReference, "But charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him.");
        favScriptures.AddScripture(aScripture);

        Scripture theScripture = new Scripture(favScriptures.GetRandomScripture());

        string ans = "";
        while (ans!="quit"){
            Console.Clear();
            Console.WriteLine(theScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            ans = Console.ReadLine();
            if(theScripture.IsCompletelyHidden() || ans=="quit"){
                            break;
            }else{
                theScripture.HideRandomWords(4);
            }
        }
    }
}