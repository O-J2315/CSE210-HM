public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name,string description,string points,int target,int bonus) : base (name,description,points){
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool isComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}