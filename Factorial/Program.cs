/*
# Name: Drew Wolfe
# email: wolfeaw@mail.uc.edu
# Assignment Title: Assignment GitHub20241024
# Due Date: 10/24/2024
# Course: IS 3050
# Semester/Year: Semester 1, Year 4
# Brief Description: This project is also working with GitHub
# Citations:
# Anything else that's relevant:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find factorial:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ComputeFactorial(number));
            // Console.WriteLine("Factorial of 9: " + ComputeFactorial(9));
            // Console.WriteLine("Factorial of 4: " + ComputeFactorial(4));
            // Console.WriteLine("Factorial of 15: " + ComputeFactorial(15));
        }
        static int ComputeFactorial(int num)
        {
            int factorial = 1;
            int counter = 1;
            while (counter <= num)
            {
                factorial = factorial * counter;
                counter++;
            }
            return factorial;

        }
    }
}
