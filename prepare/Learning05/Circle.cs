class Circle : Shape {
    private double _radius;

    public Circle() {
        _radius = 5.0;
    }

    public override double GetArea() {
        return _radius * _radius * Math.PI;
    }
}