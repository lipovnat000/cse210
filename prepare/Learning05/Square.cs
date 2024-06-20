class Square : Shape {
    private double _side;

    public Square(string color) : base(color) {
        _side = 1.0;
    }

    public override double GetArea() {
        return _side * _side;
    }
}