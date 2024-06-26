class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color) : base(color) {
        _length = 1.0;
        _width = 2.0;
    }

    public override double GetArea() {
        return _length * _width;
    }
}