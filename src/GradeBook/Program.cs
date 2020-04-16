using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var z = 10.2;
            var x = 13;
            var result = z + x;
            Console.WriteLine(result);

            var numbers = new double[3];
            numbers[0] = 6.5;
            numbers[1] = 6.5;
            numbers[2] = 6.5;
            
            var numbers2 = new [] {1.1, 2.2, 3.3, 4.4};
            result = 0.0;

            foreach(var number in numbers2)
            {
                result += number;
                System.Console.WriteLine(result);
            }

            var grades = new List<double>() {1.1, 2.2, 3.3, 4.4};
            grades.Add(1.3);
            result = 0.0;

            foreach (var number in grades)
            {
                result += number;   
            }
            System.Console.WriteLine($"The average grade {result:N1}");

            var average = result/ grades.Count;
            System.Console.WriteLine(average);

            if (args.Length > 0)
            {
                Console.WriteLine("Hello " + args[0] + "!");
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
            //
            var book = new Book("Rewiesh gradebook.");
            book.AddGrade(2.5);
        }
    }
}
