using System;
using System.Linq;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an application that will keep prompting the user to input all 3 of their exam grades(using a For loop). 
            //Calculate the average of their exam scores and output the result.
            //When you display the result, make sure to use a Format Specifier for percentages.



            double[] scores = new double[3];
            double avgscore,totalscores = 0;
            



            for (int examgrade = 0; examgrade < 3; examgrade++)
            {
                Console.WriteLine($"Please enter all your exam scores.");
                scores[examgrade] = Convert.ToDouble(Console.ReadLine());
                

            }
            totalscores = scores.Sum();
            avgscore = totalscores / 3;
            Console.WriteLine($"Your average exam score is {avgscore/100:p}");
            Console.ReadLine();

        }

    }
}
