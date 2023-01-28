/*
 * Author:  Christian Amith
 * Course:  COMP-003A-L01
 * Purpose: Code for Assignment 2
 */
using System.Diagnostics;

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console Section
            Console.WriteLine("****************************************\nConsole Section \n****************************************\n\n");

            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;


            // String Section
            Console.WriteLine("****************************************\nString Section \n****************************************");

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age in 2023: ");
            string inputAge = Console.ReadLine();

            int yearBorn = 2023 - Convert.ToInt32(inputAge); // Converts string literal to integer and subtracts it from current year

            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.\n\n"); 


            // Math Section
            Console.WriteLine("****************************************\nMath Section \n****************************************");

            Console.Write("Enter an integer for integer1: ");
            string integer1Text = Console.ReadLine();
            int integer1 = Convert.ToInt32(integer1Text);
            Console.Write("Enter an integer for integer2: ");
            string integer2Text = Console.ReadLine();
            int integer2 = Convert.ToInt32(integer2Text);

            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
            Console.WriteLine("\n");


            // Circle Area & Circumference Calculator Section
            Console.WriteLine("****************************************\nCircle Area & Circumference Calculator Section \n****************************************");

            Console.WriteLine("Enter Radius: ");
            double radius = Convert.ToDouble( Console.ReadLine() );
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The area is {area}");
            Console.WriteLine($"The area is {circumference}");

        }
    }
}