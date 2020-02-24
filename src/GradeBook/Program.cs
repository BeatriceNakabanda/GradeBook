using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Beatrice Grade Book");
            // book.AddGrade(70.9);
            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }
                
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            //creating an array that holds 3 numbers
            //var numbers = new double[3] {25.5, 10.3, 60.5};
            // var numbers = new[] { 25.5, 10.3, 60.5 };

            //Initializing a list
            // var grades = new List<double>() { 10.9, 30.4, 50.4 };
            // grades.Add(56.2);        
        }
    }
}
