using System.Collections.Generic;
using System;

namespace GradeBook
{
    public class Book 
    {
        public string Naam;
        
        private List<double> grades;

        public Book(string naam) 
        {
            grades = new List<double>();
            this.Naam = naam;
        }

        public void AddLetterGrade(char letter) 
        {
            // if (letter == 'A')
            // {
            //     AddGrade(90);
            // }
            // else if (letter == 'B')
            // {
            //     AddGrade(80);
            // }

            switch(letter)
            {
                case 'A': 
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade (double grade) 
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                System.Console.WriteLine("Invalid value!");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;


            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            
            // var index = 0;

            // do 
            // {
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Average += grades[index];
            //     index++;
            // } while (index < grades.Count); // loop always executes atleast once

            // while (index < grades.Count)
            // {
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.High = Math.Max(grades[index], result.High);
            //     result.Average += grades[index];
            //     index++; 
            // }

            // for (var i =0; i < grades.Count; i++)
            // {
            //     if (grades[i] == 42.1)
            //     {
            //         break;    
            //     }
                
            //     if (grades[i] == 4.3)
            //     {
            //         continue;
            //     }
            //     //goto;
            //     result.Low = Math.Min(grades[i], result.Low);
            //     result.High = Math.Max(grades[i], result.High);
            //     result.Average += grades[i];
            // }
           
            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                
                case var d when d >= 50.0:
                    result.Letter = 'E';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
    }
}