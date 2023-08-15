using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssigment3Prb3
{        
    internal interface InterfaceShape
        {
            void CalculateArea();
            void CalculatePerimeter();

        }
        class Circle : InterfaceShape
        {

            public void CalculateArea()
            {
                Console.WriteLine("Enter raidus: ");
                double raidus = Convert.ToDouble(Console.ReadLine());
                double area = (raidus * raidus) * 3.146;
                Console.WriteLine($"Area of Circle is : {area}");
            }
            public void CalculatePerimeter()
            {
                Console.WriteLine("Enter raidus");
                double raidus = Convert.ToDouble(Console.ReadLine());
                double circumference = 2 * 3.146 * raidus;
                Console.WriteLine($"Circumference of Circle is : {circumference}");
            }

        }

        class Rectangle : InterfaceShape
        {
            public void CalculateArea()
            {
                Console.WriteLine("Enter length and breath:");
                double length = Convert.ToDouble(Console.ReadLine());
                double breath = Convert.ToDouble(Console.ReadLine());
                double area = length * breath;
                Console.WriteLine($"Area of Rectangle is : {area}");
            }
            public void CalculatePerimeter()
            {
                Console.WriteLine("Enter length and breath:");
                double length = Convert.ToDouble(Console.ReadLine());
                double breath = Convert.ToDouble(Console.ReadLine());
                double perimeter = (2 * length) + (2 * breath);
                Console.WriteLine($"Area of Rectangle is : {perimeter}");
            }
        }

        class Triangle : InterfaceShape
        {
            public void CalculateArea()
            {
                Console.WriteLine("Enter height and breath:");
                double height = Convert.ToDouble(Console.ReadLine());
                double breath = Convert.ToDouble(Console.ReadLine());
                double area = 0.5 * height * breath;
                Console.WriteLine($"Area of a triangle is: {area}");
            }
            public void CalculatePerimeter()
            {
                Console.WriteLine("Enter sides of a b and c:");
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());

                double perimeter = a + b + c;
                Console.WriteLine($"Perimeter of Triangle is: {perimeter}");
            }
        }
    
}

