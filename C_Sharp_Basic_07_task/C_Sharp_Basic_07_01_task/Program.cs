using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesConsole
{
    abstract class Shape
    {
        protected string name;
        public Shape(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public virtual double GetАrea()
        {
            return 0;
        }
    }
    class Triangle : Shape
    {
        protected double a, b, c;
        public Triangle(string name) : base(name)
        {
        }
        public Triangle(double a, double b, double c) : base("Triangle")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetАrea()
        {
            //Using the formula of Gerona:
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Circle : Shape
    {
        protected double r;
        public Circle(string name) : base(name)
        {
        }
        public Circle(double r) : base("Circle")
        {
            this.r = r;
        }
        public override double GetАrea()
        {
            return Math.PI * r * r;
        }
    }
    class Rectangle : Shape
    {
        protected double a, b;
        public Rectangle(string name) : base(name)
        {
        }
        public Rectangle(double a, double b) : base("Rectangle")
        {
            this.a = a;
            this.b = b;
        }

        public override double GetАrea()
        {
            return a * b;
        }
    }
    class IsoscelesTriangle : Triangle
    {
        protected double a, b, c;
        public IsoscelesTriangle(double a, double b, double c) : base("IsoscelesTriangle")
        {
            if (a == b || b == c || c == a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                ArgumentException ex = new ArgumentException("Arguments have the wrong format.");
                throw ex;
            }
        }
        public override double GetАrea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Square : Rectangle
    {
        protected double a, b;
        public Square(double a, double b) : base("Square")
        {
            if (a == b)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                ArgumentException ex = new ArgumentException("Arguments have the wrong format.");
                throw ex;
            }
        }
        public override double GetАrea()
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1, shape2, shape3, shape4, shape5;
            shape1 = new Triangle(3, 4, 5);
            shape2 = new Circle(4);
            shape3 = new Rectangle(2, 6);
            shape4 = new IsoscelesTriangle(5, 4, 5);
            shape5 = new Square(8, 8);

            // results: 
            shape1.GetName(); shape1.GetАrea();
            shape2.GetName(); shape2.GetАrea();
            shape3.GetName(); shape3.GetАrea();
            shape4.GetName(); shape4.GetАrea();
            shape5.GetName(); shape5.GetАrea();
        }
    }
}