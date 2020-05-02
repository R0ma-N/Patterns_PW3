using System;

namespace Patterns_PW3
{
    public abstract class Figure
    {
        protected void Draw()
        {
            Console.Write("#");
        }
    }

    public class Circle: Figure
    {
        public Circle(int radius)
        {
            int r = radius;
            for (int y = 0; y <= r; ++y)
            {
                int x = (int)Math.Round(Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));
                Console.SetCursorPosition(x + r, y + r);
                Draw();
                Console.SetCursorPosition(x + r, -y + r);
                Draw();
                Console.SetCursorPosition(-x + r, -y + r);
                Draw();
                Console.SetCursorPosition(-x + r, y + r);
                Draw();
            }
            Console.WriteLine();
        }
    }

    public class Square: Figure
    {
        public Square(int sideLength)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength*2; j++)
                {
                    Draw();
                }

                Console.WriteLine();
            }
        }
    }
    
    public class Rectangle: Figure
    {
        public Rectangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Draw();
                }

                Console.WriteLine();
            }
        }
    }

    public class FigureFactory
    {
        public static Figure CreateFigure(string type)
        {
            if (type == "Circle")
            {
                Console.Write("Radius = ");
                int radius = Convert.ToInt32(Console.ReadLine());
                return new Circle(radius);
            }
            else if (type == "Square")
            {
                Console.Write("Side length = ");
                int sideLength = Convert.ToInt32(Console.ReadLine());
                return new Square(sideLength);
            }
            else if (type == "Rectangle")
            {
                Console.Write("Height length = ");
                int heightLenght = Convert.ToInt32(Console.ReadLine());
                Console.Write("Width length = ");
                int widthLenght = Convert.ToInt32(Console.ReadLine());
                return new Rectangle(heightLenght, widthLenght);
            }
            else return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FigureFactory.CreateFigure("Circle");
            FigureFactory.CreateFigure("Square");
            FigureFactory.CreateFigure("Rectangle");
        }
    }
}
