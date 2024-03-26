public class SimpleGoal : Goal {
    private bool _isComplete;
    public SimpleGoal(string name,string description,string points) : base(name,description,points){
    }
    public SimpleGoal(string name,string description,string points,string isComplete) : base(name,description,points){
        _isComplete = bool.Parse(isComplete);
    }
    public override int RecordEvent(){
        _isComplete = true;
        return GetPoints();
    }
    public override bool isComplete(){
        return _isComplete;
    }
    public override string GetStringRepresentation(){
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{isComplete()}";
    }
}