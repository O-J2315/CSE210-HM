using System.ComponentModel;

public class Assignment {

    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }


    public string GetStudentName(){
        return _studentName;
    }
    public string GetSummary(){
        return $"{_studentName}, assignment topic - {_topic}";
    }

}
