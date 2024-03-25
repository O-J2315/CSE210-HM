using System.Collections.Concurrent;
using System.ComponentModel;

public abstract class Goal{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal (string name,string description,string points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool isComplete();
    public virtual string GetDetailsString(){
        return $"{_shortName}\n{_description}";
    }
    public abstract string GetStringRepresentation();
}