public class Library{

    private List<Scripture> _scriptures = new List<Scripture>();

    public void AddScripture(Scripture theScripture){
        _scriptures.Add(theScripture);
    }

    public Scripture GetRandomScripture(){
        Random rd = new Random();
        int index = rd.Next(0, _scriptures.Count);
        return _scriptures[index];
    }
}