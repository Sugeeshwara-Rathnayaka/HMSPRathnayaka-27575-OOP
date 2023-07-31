using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac03_01
{
    public class BasicArithmetic
    {
        private double num1;
        private double num2;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double Summation()
        {
            return num1 + num2;
        }

        public double Subtraction()
        {
            return num1 - num2;
        }

        public double Multiplication()
        {
            return num1 * num2;
        }

        public double Division()
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }
    }

    public class Program
    {
        public static void Main()
        {
            BasicArithmetic arithmetic = new BasicArithmetic();

       
            Console.Write("Enter the first number: ");
            arithmetic.Num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            arithmetic.Num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Summation: {arithmetic.Summation()}");
            Console.WriteLine($"Subtraction: {arithmetic.Subtraction()}");
            Console.WriteLine($"Multiplication: {arithmetic.Multiplication()}");

            try
            {
                Console.WriteLine($"Division: {arithmetic.Division()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
