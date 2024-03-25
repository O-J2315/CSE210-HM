public class Circle : Shape {
    private double _radius;
    public override double GetArea() {
        return 3.1416 * _radius*_radius;
    }

    public void SetRadius(double radius){
        _radius = radius;
    }
}