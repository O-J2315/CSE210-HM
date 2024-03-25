public class Rectangle : Shape {
    private double _length;
    private double _width;
    public override double GetArea(){
        return _length * _width;
    }
    public void SetLenght(double lenght){
        _length = lenght;
    }
     public void SetWidth(double width){
        _width = width;
    }
}