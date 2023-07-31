using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac02_ii
{
    class FindValues
    {
        public double FindArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            FindValues finder = new FindValues();

            double area = finder.FindArea(radius);
            double circumference = finder.FindCircumference(radius);

            Console.WriteLine($"Area of the circle: {area:F2}");
            Console.WriteLine($"Circumference of the circle: {circumference:F2}");

            Console.ReadKey();
        }
    }
}
