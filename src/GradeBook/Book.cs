using System.Collections.Generic;
using System;

namespace GradeBook
{
    class Book 
    {
        private string naam;
        
        private List<double> grades;
        private double lowGrade;
        private double highGrade;
        private double result = 0.0;


        public Book(string naam) 
        {
            grades = new List<double>();
            this.naam = naam;
        }

        public void AddGrade (double grade) 
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            highGrade = double.MinValue;
            lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            //System.Console.WriteLine(grades.Contain;
            System.Console.WriteLine($"The best grade {highGrade}");
            System.Console.WriteLine($"The worst grade {lowGrade}");
            System.Console.WriteLine($"The new average {result/grades.Count}");
        }
    }
}