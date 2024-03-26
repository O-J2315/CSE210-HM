using System.ComponentModel;
public class EternalGoal : Goal {
    public EternalGoal(string name,string description,string points) :base (name,description,points){}
    public override int RecordEvent(){
        return GetPoints();
    }
    public override bool isComplete(){
        return false;
    }
    public override string GetStringRepresentation(){
        return $"EternalGoal,{GetName()},{GetDescription()},{GetPoints()}";
    }
}