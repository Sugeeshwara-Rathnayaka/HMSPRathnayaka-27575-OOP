﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter the student's marks: ");
            int studentMarks = int.Parse(Console.ReadLine());

            string grade = CalculateGrade(studentMarks);

            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Student Grade: {grade}");

            Console.ReadKey();
        }

        static string CalculateGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
            {
                return "A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                return "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                return "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                return "D";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
