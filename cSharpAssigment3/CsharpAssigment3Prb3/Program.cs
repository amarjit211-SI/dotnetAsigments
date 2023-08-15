using System.Drawing;

namespace CsharpAssigment3Prb3
{
    internal class Program
    {
       static void Main(string[] args)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.CalculateArea();
                rectangle.CalculatePerimeter();

                Circle circle = new Circle();
                circle.CalculateArea();
                circle.CalculatePerimeter();

                Triangle triangle = new Triangle();
                triangle.CalculateArea();
                triangle.CalculatePerimeter();

                

            }
        }
    }