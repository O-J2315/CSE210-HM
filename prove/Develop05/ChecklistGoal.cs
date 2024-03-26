public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name,string description,string points,int target,int bonus) : base (name,description,points){
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name,string description,string points,int bonus,int target,int amountCompleted) : base (name,description,points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    public override int RecordEvent(){
        if (isComplete()){
            return GetPoints() + _bonus;
        }else{
            _amountCompleted++;
            return GetPoints();
        }
    }
    public override bool isComplete()
    {
        if (_amountCompleted >= _target){
            return true;
        }else {
            return false;
        }
    }
    public override string GetDetailsString(){
        if(isComplete()){
                return $"[x] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
            }
            else{
                return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
            }
    }
    public override string GetStringRepresentation(){
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }
}