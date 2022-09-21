using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    class ComputeAverageProgram{
        static void Main(string[] args){
            double grade1, grade2, grade3, grade4, grade5, average;
            int convertedAverage;

            Console.WriteLine("Enter 5 grades separated by new line:");
            grade1 = (double) Convert.ToInt16(Console.ReadLine());
            grade2 = (double) Convert.ToInt16(Console.ReadLine());
            grade3 = (double) Convert.ToInt16(Console.ReadLine());
            grade4 = (double) Convert.ToInt16(Console.ReadLine());
            grade5 = (double) Convert.ToInt16(Console.ReadLine());

            average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            convertedAverage = (int) average;
            
            Console.WriteLine($"The average is {average} and round off to {convertedAverage}");
        }
    }
}
