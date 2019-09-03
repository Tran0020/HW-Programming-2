using System;
namespace Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create an application that asks the user for their exam score,
            //    add their input to an accumulator and then ask the user if they have another score to enter.
            //                If they do, ask for the exam score and repeat the process until they say no.
            //                Make sure that their answer is case insensitive
            //                (e.g.they can say Yes or yes and your code treats it the same).
            //Once they say no, calculate the average of all of the exam scores based upon
            //your accumulator and your counting variable.
            //Make sure that you use some sort of a While Loop, an accumulating variable
            //(to keep track of the total exam scores), 
            //and a counting variable(to keep track of the number of scores they entered).

            double examscore;
            string response="";
            Console.WriteLine("Please enter your exam score.");
            examscore = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do you want to list another exam grade?");
            Console.WriteLine("Type 'Yes' if you want to continue to input your exam grades. Type 'No' to move on.");
            string.Equals("Yes", "yes", StringComparison.CurrentCultureIgnoreCase);
            response = Console.ReadLine();
            while ( response == "Yes")
            {
                Console.WriteLine("Please enter your exam score.");
                examscore = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you want to list another exam grade?");
                 Console.WriteLine("Type 'Yes' if you want to continue to input your exam grades. Type 'No' to move on.");
                string.Equals("Yes", "yes", StringComparison.CurrentCultureIgnoreCase);
                response = Console.ReadLine();
                //if (response == "No")
                //{
                //    double examtotal;
                //    examtotal = examscore + examscore++;
                //    Console.WriteLine($"{examtotal}");
                //}

            }

            double examtotal;
            examtotal = examscore + examscore;
            Console.WriteLine($"{examtotal}");
            Console.ReadKey();
        }
    }
}
