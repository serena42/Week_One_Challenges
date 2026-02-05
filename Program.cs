using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Week_One_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
            //Temp 0 < 10 then Freezing weather
            //Temp 11 - 20 then Very Cold weather
            //Temp 21 - 35 then Cold weather
            //Temp 36 - 50 then Normal in Weather
            //Temp 51 - 65 then Its Hot
            //Temp 66 - 80 then Its Very Hot
            //Test Data :
            //67
            //Expected Output :
            //Its very hot.
            Console.WriteLine("Input a temperature in Fahrenheit: ");
            float temp = Convert.ToSingle(Console.ReadLine());
            if (temp <= 10)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp > 20 && temp <= 35)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp > 35 && temp <= 50)
            {
                Console.WriteLine("Normal in Weather");
            }
            else if (temp > 50 && temp <= 65)
            {
                Console.WriteLine("It's Hot");
            }
            else
            {
                Console.WriteLine("It's Very Hot");
            }
            //Write a C# Sharp program that takes userid and password as input
            //(type string). After 3 wrong attempts, user will be rejected.
            string correctUserId = "admin";
            string correctPassword = "password123";
            int attempts = 0;
            while (attempts < 3)
            {
                Console.Write("Enter User ID: ");
                string userId = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();
                if (userId == correctUserId && password == correctPassword)
                {
                    Console.WriteLine("Login successful!");
                    break;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("Incorrect User ID or Password. Try again.");
                    if (attempts == 3)
                    {
                        Console.WriteLine("Too many failed attempts. Access denied.");
                    }
                }
            }
            //            3.Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
            //Test Data
            //Enter a number: 6
            //Enter the desired width: 6
            //Expected Output:

            //666666

            //66666

            //6666

            //666

            //66

            //6
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = (int)width; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
//            4.Write a C# Sharp program to read roll no, name and marks of three subjects and calculate
//            the total, percentage and division. (May use a struct / class to represent the student)
            //Test Data :
            //Input the Roll Number of the student: 784
            //Input the Name of the Student :James
            //Input the marks of Physics, Chemistry and Computer Application: 70 80 90
            //Expected Output :
            //Roll No : 784
            //Name of Student: James
            //Marks in Physics: 70
            //Marks in Chemistry: 80
            //Marks in Computer Application : 90
            //Total Marks = 240
            //Percentage = 80.00
            //Division = First
            Random rand = new Random();
            Console.Write("Input the Roll Number of the student: ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();
            Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
            int physicsMarks = Convert.ToInt32(Console.ReadLine());
            int chemistryMarks = Convert.ToInt32(Console.ReadLine());
            int computerAppMarks = Convert.ToInt32(Console.ReadLine());
            int totalMarks = physicsMarks + chemistryMarks + computerAppMarks;
            float percentage = (totalMarks / 300.0f) * 100;
            string division;
            if (percentage >= 60)
            {
                division = "First";
            }
            else if (percentage >= 45)
            {
                division = "Second";
            }
            else if (percentage >= 33)
            {
                division = "Third";
            }
            else
            {
                division = "Fail";
            }
            Console.WriteLine("\nRoll No : " + rollNumber);
            Console.WriteLine("Name of Student: " + name);
            Console.WriteLine("Marks in Physics: " + physicsMarks);
            Console.WriteLine("Marks in Chemistry: " + chemistryMarks);
            Console.WriteLine("Marks in Computer Application : " + computerAppMarks);
            Console.WriteLine("Total Marks = " + totalMarks);
            Console.WriteLine("Percentage = " + percentage.ToString("F2"));
            Console.WriteLine("Division = " + division);
        }
    }
}