using System;
using System.Runtime.InteropServices.Marshalling;

namespace Shape_management
{
    class Shapes
    {
        public virtual void Shape()
        {
            System.Console.WriteLine("Shapes has got Area and perimeter");
        }
    }

    class Triangle : Shapes
    {

        public void info()
        {
            System.Console.WriteLine("please insert sides and height ");
            System.Console.WriteLine("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("c= ");
            double c = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("hight= ");
            double h = Convert.ToDouble(Console.ReadLine());

            double _area = area(b, h);
            double _primeter = primeter(a, b, c);
            System.Console.WriteLine("area = "+_area);
            System.Console.WriteLine("primeter = "+_primeter);

        }
        public override void Shape()
        {
            System.Console.WriteLine("triangel's primeter equals to sumrize the three sides");
            System.Console.WriteLine("triangel's area equals to (base*height)/2 ");
        }
        

        static double area(double a, double l)
        {
            double _area = (a * l) / 2;
            return _area;

        }

        static double primeter(double a, double b, double c)
        {
            double _primeter = (a + b + c);
            return _primeter;
        }



    }


    class Square : Shapes
    {
        public override void Shape()
        {
            System.Console.WriteLine("square's primeter equals to 4*sides");
            System.Console.WriteLine("square's area equals to sides*sides");
        }

        public void info()
        {
            System.Console.WriteLine("please insert sides and hight ");
            System.Console.WriteLine("a= ");
            double a = Convert.ToDouble(Console.ReadLine());

            double _area = area(a);
            double _primeter = primeter(a);
             System.Console.WriteLine("area = "+_area);
            System.Console.WriteLine("primeter = "+_primeter);

        }

        static double area(double a)
        {
            double _area = a * a;
            return _area;
        }
        
        static double primeter(double a)
        {
            double _primeter = a*4;
            return _primeter;
        }


    }


    class Circle : Shapes
    {
        public void info()
        {
            System.Console.WriteLine("please insert radios ");
            System.Console.WriteLine("a= ");
            double r = Convert.ToDouble(Console.ReadLine());

            double _area = area(r);
            double _primeter = primeter(r);
            System.Console.WriteLine("area = "+_area);
            System.Console.WriteLine("primeter = "+_primeter);


        }
        public override void Shape()
        {
            System.Console.WriteLine("circule's primeter equals to 2R*pi ");
            System.Console.WriteLine("circule's area equals to pi*R*R ");
        }


        static double area(double a)
        {
            double _area = a * a * 3.14;
            return _area;

        }

        static double primeter(double c)
        {
            double _primeter = (c * 2 * 3.14);
            return _primeter;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Mr,Wizzeman's shape management";

            System.Console.WriteLine("What is your shape ?(circule , triangle , square)");
            string choice = Console.ReadLine().ToLower();

            Triangle triangel = new Triangle();
            Circle circle = new Circle();
            Square square = new Square();
            

            switch (choice)
            {
                case "triangle":
                    triangel.info();
                    break;


                case "circule":
                    circle.info();
                    break;

                case "square":
                    square.info();
                    break;

                default:
                    System.Console.WriteLine("fuck you");
                    break;
            }


            Console.ReadKey();
        }
    }
}