using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer Value 1 : ");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a integer Value 2 : ");
            int value2 = int.Parse(Console.ReadLine());

            int sum = value1 + value2;
            int sub = value1 - value2;
            int mul = value1 * value2;
            double div = (double)value1 / value2;

            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"Substractin is :{sub}");
            Console.WriteLine($"Multiplicatin is :{mul}");
            Console.WriteLine($"Division is : {div}" );

            Console.ReadKey();

        }
    }
}
