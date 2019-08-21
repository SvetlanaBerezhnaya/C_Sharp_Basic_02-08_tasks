using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesConsole
{
    interface IShape
    {
        string GetName();
        double GetАrea();
    }
    class Triangle : IShape
    {
        protected string name;
        protected double a, b, c;
        public Triangle(double a, double b, double c) 
        {
            name = "Triangle";
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string GetName()
        {
            return name;
        }
        public double GetАrea()
        {
            //Using the formula of Gerona:
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Circle : IShape
    {
        protected string name;
        protected double r;
        public Circle(double r) 
        {
            name = "Circle";
            this.r = r;
        }
        public string GetName()
        {
            return name;
        }
        public double GetАrea()
        {
            return Math.PI * r * r;
        }
    }
    class Rectangle : IShape
    {
        protected string name;
        protected double a, b;
        public Rectangle(double a, double b)
        {
            name = "Rectangle";
            this.a = a;
            this.b = b;
        }
        public string GetName()
        {
            return name;
        }
        public double GetАrea()
        {
            return a * b;
        }
    }
    class IsoscelesTriangle : IShape 
    {
        protected string name;
        protected double a, b, c;
        public IsoscelesTriangle(double a, double b, double c) 
        {
            if (a == b || b == c || c == a)
            {
                name = "IsoscelesTriangle";
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
        public string GetName()
        {
            return name;
        }
        public double GetАrea()
        {            
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Square : IShape
    {
        protected string name;
        protected double a, b;
        public Square(double a, double b) 
        {            
            if (a == b)
            {
                name = "Square";
                this.a = a;
                this.b = b;
            }
            else
            {
                ArgumentException ex = new ArgumentException("Arguments have the wrong format.");
                throw ex;
            }
        }
        public string GetName()
        {
            return name;
        }
        public double GetАrea()
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1, shape2, shape3, shape4, shape5;
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