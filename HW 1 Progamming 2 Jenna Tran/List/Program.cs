using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {//NEED HELP WITH 
            //            Create a console application that prompts the user to create a list of exam grades
            //                and then calculates the average. Your application should include two loops:

            //Loop #1 should initialize the entry of all quiz grades.
            //Loop #2 should calculate the sum and average of the total quiz grades.

            double quizgrades;
            string response;
            List<double> grades = new List<double>();
            //Console.WriteLine("Please list all your quiz grades");
            //quizgrades = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("Please list your quiz grade.");
                quizgrades= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you want to list another quiz grade?");
                Console.WriteLine("Type 'Yes' if you want to continue to input your quiz grades. Type 'No' to move on.");
                response = Console.ReadLine();

            } while (response == "Yes");
            double sum = 0;
            double average = 0;

            for (int i = 0; i < grades.Count; i++)
            {

                sum = sum + (grades[i]);
                average = sum / (i + 1);
               
            }

            Console.WriteLine($"The sum of the test {sum} and the average is {average / 100:P}  ");
            Console.ReadKey();
        }
    }
}
