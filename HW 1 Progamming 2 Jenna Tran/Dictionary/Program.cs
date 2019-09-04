using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {//DONE
            // Redo the Arrays problem, however this time use a dictionary.  
            //Your key value will be the fruit name and the value will be the price of the piece of fruit.
            Dictionary<string, double> fruit = new Dictionary<string, double>();
            fruit.Add("apples", 0.99);
            fruit.Add("oranges", 0.50);
            fruit.Add("bananas", 0.50);
            fruit.Add("grapes", 2.99);
            fruit.Add("blueberries", 1.99);
            string fruitname;
            Console.WriteLine("Please enter the fruit you desire.");
            fruitname = Console.ReadLine();
            if (fruit.ContainsKey(fruitname))
            {
                double value = fruit[fruitname.ToLower()];
                Console.WriteLine($"The price of {fruitname} is {value:c}");
            }
       



            Console.ReadKey();

        }
    }
}
