using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a console application that prompts the user to enter the item they desire, and return the value / price of the item.
            //  Your console application should contain two parallel arrays, as well as an error if they enter or spell 
            //   the item name incorrectly.

            //Array #1: should contain items apples, oranges, bananas, grapes, blueberries
            //Array #2: should contain prices for each item.
            //Apples are 0.99, oranges are 0.50, bananas are 0.50, grapes are 2.99, blueberries are 1.99.

            string[] fruit = { "apples", "oranges", "bananas", "grapes", "blueberries" };
            double[] price = { 0.99, 0.50, 0.50, 2.99, 1.99 };
            string fruitname;
            bool isvalid = false;
            Console.WriteLine("Please enter the fruit you desire.");
            fruitname = Console.ReadLine();
            int i;
           do
            {
                for (i = 0; i < fruit.Length - 1; i++)
                {
                    if (fruitname == fruit[i])
                    {
                        Console.WriteLine($"The price of {fruitname} is {price[i]:c}");
                    isvalid = true;
                    }

                }
                if (isvalid == false)
                {
                    Console.WriteLine("Error! Please enter the fruit name again.");
                    fruitname = Console.ReadLine();

                }

            } while (isvalid==false);


            Console.ReadLine();
            }   
    }
}
