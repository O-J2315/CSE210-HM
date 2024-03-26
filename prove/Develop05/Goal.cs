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
    public abstract int RecordEvent();
    public abstract bool isComplete();
    public virtual string GetDetailsString(){
        if (isComplete()){
            return $"[x] {GetName()} ({GetDescription()})";
        }else {
            return $"[ ] {GetName()} ({GetDescription()})";
        }
    }
    public abstract string GetStringRepresentation();
    public string GetName(){
        return _shortName;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetPoints(){
        return int.Parse(_points);
    }
}
