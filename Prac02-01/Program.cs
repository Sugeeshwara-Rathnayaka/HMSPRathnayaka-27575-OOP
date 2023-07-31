using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilometerToMeterConverterApp
{
    class ConvertValues
    {
        public void kilometerToMeter()
        {
            Console.Write("Enter the value in Kilometers : ");
            double kilometers = double.Parse(Console.ReadLine());

            double meters = kilometers * 1000; 

            Console.WriteLine($"{kilometers} Km is equal to {meters} m.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            ConvertValues converter = new ConvertValues();
            converter.kilometerToMeter();

            Console.ReadKey();
        }
    }
}