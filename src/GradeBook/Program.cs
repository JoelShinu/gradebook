using System.Collections.Generic;
using System.Security.Cryptography;
using System.Globalization;
using System;

namespace GradeBook
{

    class Program
    {
        static void Main()
        {
            var book = new Book("Scott#S Grade Book");
            book.AddGrade(54.5);
            book.AddGrade(65.4);
            book.AddGrade(78.1);
            book.AddGrade(89.6);
            book.AddGrade(12.2);
            book.AddGrade(11.4);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            

                        
        }
    }
}