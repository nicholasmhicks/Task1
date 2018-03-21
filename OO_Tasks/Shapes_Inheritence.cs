using System;

namespace OO_Tasks_Inheritence
{

    public abstract class Shape
    {
        private string _name;
        private string _colour;

        public string Colour => _colour;

        public string Name => _name;

        public Shape(string vNew1, string vNew2)
        {
            this._colour = vNew1;
            this._name = vNew2;
        }

        abstract public double GetArea();

        abstract public double GetPerimeter();
    }
    public abstract class Quadrilateral : Shape
    {
        public Quadrilateral(string vNew1, string vNew2) : base(vNew1, vNew2)
        {

        }

        private int _NumSides = 4;

        public int NumSides => _NumSides;

    }
    public class Square : Quadrilateral
    {
        private double _sideLength;

        public double SideLength => _sideLength;

        public Square (string vNew1, string vNew2, double vNew3) : base(vNew1, vNew2)
        {
            this._sideLength = vNew3;
        }

        public override double GetArea()
        {
            return Math.Round(this._sideLength * this._sideLength,2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(4 * this._sideLength,2);
        }
    }
    public class Rectangle : Quadrilateral
    {
        private double _length;
        private double _width;

        public double Length => _length;
        public double Width => _width;

        public Rectangle(string vNew1, string vNew2, double vNew3, double vNew4) : base(vNew1, vNew2)
        {
            this._length = vNew3;
            this._width = vNew4;
        }

        public override double GetArea()
        {
            return Math.Round(this._length * this._width,2);
        }

        public override double GetPerimeter()
        {
            return Math.Round((2 * this._length) + (2 * this._width),2);
        }

    }
    public class Circle : Shape
    {

        private double _radius;

        public double Radius => _radius;

        public const double PI = 3.142;

        public Circle(string vNew1, string vNew2, double vNew3) : base(vNew1, vNew2)
        {
            this._radius = vNew3;
        }

        public override double GetArea()
        {
            return Math.Round(this._radius * this._radius * PI,2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * this._radius * PI, 2);
        }

        public double GetCircumference()
        {
            return Math.Round(2 * this._radius * PI,2);
        }
    }
}