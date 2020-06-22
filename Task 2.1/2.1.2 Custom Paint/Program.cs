using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._2_Custom_Paint
{
    public class Figure
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format("Coordinate X: {0}, Y: {1}", X, Y);
        }
    }

    public class RoundShape : Figure
    {
        public int Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
        public double Lenght => 2 * Math.PI * Radius;

        public RoundShape(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return string.Format("Radius: {0}, Area: {1}, Lenght: {2}, {3}", Radius, Area, Lenght, base.ToString());
        }
    }

    public class Circle : RoundShape
    {
        public string Color { get; set; }
        
        public Circle(int x, int y, int radius, string color) :
            base(x, y, radius)
        {
            Color = color;
        }

        public override string ToString()
        {
            return string.Format("Color: {0}, {1}", Color, base.ToString());
        }
    }

    public class Ring : RoundShape
    {
        public int InnerRadius { get; set; }
        public new double Area =>
            Math.PI * (Radius * Radius - InnerRadius * InnerRadius);
        public double RingThickness => Radius - InnerRadius;
        public Ring(int x, int y, int radius, int innerRadius) :
            base(x, y, radius)
        {
            InnerRadius = innerRadius;
        }
        public override string ToString()
        {
            return string.Format("Inner Radius: {0}, {1}", InnerRadius, base.ToString());
        }
    }

    public class Rectangle : Figure
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int Area => SideA * SideB;
        public int Lenght => SideA * 2 + SideB * 2;
        public Rectangle(int x, int y, int sideA, int sideB) :
            base(x, y)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override string ToString()
        {
            return string.Format("Width: {0}, Hight: {1}, Area: {2}, Lenght: {3}", SideA, SideB, Area, Lenght, base.ToString());
        }
    }

    public class Square : Figure
    {
        public int Side { get; set; }
        public int Area => Side * 2;
        public int Lenght => Side * 4;
        public Square(int x, int y, int side) :
            base(x, y)
        {
            Side = side;
        }
        public override string ToString()
        {
            return string.Format("Side: {0}, Area: {1}, Lenght: {2}", Side, Area, Lenght, base.ToString());
        }
    }

    public class Triangle : Figure
    {
        public int SideA;
        public int SideB;
        public int SideC;
        public int Lenght => SideA + SideB + SideC;
        private double p => Lenght / 2;
        public double Area =>
            Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        public Triangle(int x, int y, int sideA, int sideB, int sideC) :
            base(x, y)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override string ToString()
        {
            return string.Format("Side A: {0}, Side B: {1}, Side C: {2}, Area: {3}, Lenght: {4}", SideA, SideB, SideC, Area, Lenght, base.ToString());
        }
    }

    public class Line : Figure
    {
        public int Lenght;
        public Line(int x, int y, int lenght) :
            base(x, y)
        {
            Lenght = lenght;
        }
        public override string ToString()
        {
            return string.Format("Lenght: {0}", Lenght, base.ToString());
        }
    }
    public class FigureManager
    {
        public Figure AddFigure(string figureType)
        {
            switch (figureType)
            {
                case "RoundShape":
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out int x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out int y);
                    Console.WriteLine("Enter radius");
                    int.TryParse(Console.ReadLine(), out int radius);
                    Console.WriteLine("Round shape created");
                    return new RoundShape(x, y, radius);
                case "Circle":
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine("Enter radius");
                    int.TryParse(Console.ReadLine(), out radius);
                    Console.WriteLine("Enter color");
                    string color = Console.ReadLine();
                    Console.WriteLine("Circle created");
                    return new Circle(x, y, radius, color);
                case "Ring":
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine("Enter radius");
                    int.TryParse(Console.ReadLine(), out radius);
                    Console.WriteLine("Enter inner radius");
                    int.TryParse(Console.ReadLine(), out int innerRadius);
                    Console.WriteLine("Ring created");
                    return new Ring(x, y, radius, innerRadius);
                case "Rectangle":
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine("Enter lenght side A");
                    int.TryParse(Console.ReadLine(), out int sideA);
                    Console.WriteLine("Enter lenght side B");
                    int.TryParse(Console.ReadLine(), out int sideB);
                    Console.WriteLine("Rectangle created");
                    return new Rectangle(x, y, sideA, sideB);
                case "Square":
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine("Enter lenght side");
                    int.TryParse(Console.ReadLine(), out int side);
                    Console.WriteLine("Square created");
                    return new Square(x, y, side);
                case "Triangle":
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine("Enter lenght side A");
                    int.TryParse(Console.ReadLine(), out sideA);
                    Console.WriteLine("Enter lenght side B");
                    int.TryParse(Console.ReadLine(), out sideB);
                    Console.WriteLine("Enter lenght side C");
                    int.TryParse(Console.ReadLine(), out int sideC);
                    Console.WriteLine("Triangle created");
                    return new Triangle(x, y, sideA, sideB, sideC);
                case "Line":
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine("Enter lenght");
                    int.TryParse(Console.ReadLine(), out int lenght);
                    Console.WriteLine("Line created");
                    return new Line(x, y, lenght);
                default:
                    Console.WriteLine("Enter coordinate X");
                    int.TryParse(Console.ReadLine(), out x);
                    Console.WriteLine("Enter coordinate Y");
                    int.TryParse(Console.ReadLine(), out y);
                    Console.WriteLine("Unknown figure created");
                    return new Figure(x, y);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FigureManager figureManager = new FigureManager();
            List<Figure> figures = new List<Figure>();
            Console.WriteLine("Enter you name");
            string name = Console.ReadLine();
            int value = 0;
            while(value !=5)
            {
                Console.WriteLine("Pick action, {0}!", name);
                Console.WriteLine("1.Add figure\n2.Output figures");
                Console.WriteLine("3.Remove all figures\n4.Switch user\n5.Exit");
                int.TryParse(Console.ReadLine(), out value);
                switch(value)
                {
                    case 1:
                        Console.WriteLine("Enter type figure: RoundShape, Circle, Ring, Rectangle, Triangle, Square, Line.");
                        figures.Add(figureManager.AddFigure(Console.ReadLine()));
                        break;
                    case 2:
                        if (figures.Count == 0)
                        {
                            Console.WriteLine("Figures not found");
                        }
                        else
                        {
                            foreach (var item in figures)
                            {
                                Console.WriteLine(string.Format("Figure: {0}, {1}", item.GetType().Name, item.ToString()));
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("All figures removed");
                        Console.WriteLine();
                        figures.Clear();
                        break;
                    case 4:
                        figures.Clear();
                        Console.Clear();
                        Console.WriteLine("Enter you name");
                        Console.WriteLine();
                        name = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
