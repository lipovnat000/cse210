class Square : Shape {
    private double _side;

    public Square() {
        _side = 1.0;
    }

    public override double GetArea() {
        return _side * _side;
    }
}