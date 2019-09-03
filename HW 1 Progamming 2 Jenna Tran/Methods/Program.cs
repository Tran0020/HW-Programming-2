using System;

namespace Methods
{
    class Program


    //    The first method that you will need to create is to calculate the y value of a line,
    //        given by the slope(m), the x value(x) and the y intercept(b).  
    //    Your method should be named LineValueForY with a return type of double.Y.
    //        Your method should accept 3 parameters, all of type double.
    //        The first parameter will be the slope of the line(name this parameter m),
    //    the second parameter should be the x value(name this parameter x)
    //        and the last parameter should be the y intercept(name this parameter b).
    //        The formula to calculate the Y value is Y = mx + b
    //}
    {
        static double LineValueForY(double m,double x, double b)
        {
            double Y = (m*x) + b;
            return Y;

        }

        //        The second method that you will need to create is to calculate the factorial of a number.
        //            Your method name should be Factorial and should have a return type of int.  
        //            Your method should accept a single parameter of type int.  
        //            To calculate the factorial of a number, you multiply it by every number before it.
        //e.g. 5 factorial = 5 * 4 * 3 * 2 * 1 = 120

        static int Factorial(int num)
        {
            int factor = 1;
            for(int i=1;i<=num; i++)
            {
             
                factor=factor*i;
               

            }
            return factor;
        }

        static void Main(string[] args)
        {
            ////double slope = LineValueForY(1, 2, 3);
            ////Console.WriteLine($"The slope is {slope}");

            int factor = Factorial(5);
            Console.WriteLine(factor);


        }
    }
}
