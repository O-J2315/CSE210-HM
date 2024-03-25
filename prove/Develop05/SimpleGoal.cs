public class SimpleGoal : Goal {
    private bool _isComplete;

    public SimpleGoal(string name,string description,string points) : base(name,description,points){

    }
    public override void RecordEvent(){
        
    }
    public override bool isComplete(){
        return true;
    }
    public override string GetStringRepresentation(){
        return GetStringRepresentation();
    }
}