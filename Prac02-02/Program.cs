using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilometerToMeterConverterApp
{
    class ConvertValues
    {
        public void KilometerToMeter(double kilometers)
        {
            double meters = kilometers * 1000; 

            Console.WriteLine($"{kilometers} Km is equal to {meters} m.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter the value in Kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            converter.KilometerToMeter(kilometers);

            Console.ReadKey();
        }
    }
}
