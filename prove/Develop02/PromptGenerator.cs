using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class PromptGenerator{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt(){
        Random random = new();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}