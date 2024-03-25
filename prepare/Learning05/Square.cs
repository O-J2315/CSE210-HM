public class Square : Shape{
    private double _side;

    public override double GetArea(){
        return _side * _side;
    }
    public void SetSide(double side){
        _side = side;
    }
}