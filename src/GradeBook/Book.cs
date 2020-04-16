using System.Collections.Generic;

namespace GradeBook
{
    class Book 
    {
        private List<double> grades;
        private string naam;
        public Book(string naam) 
        {
            grades = new List<double>();
            this.naam = naam;
        }

        public void AddGrade (double grade) 
        {
            grades.Add(grade);
        }
    }
}