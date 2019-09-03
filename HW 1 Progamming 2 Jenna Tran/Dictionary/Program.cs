using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {//NEED HELP don't know how to find to connect key with values
            // Redo the Arrays problem, however this time use a dictionary.  
            //Your key value will be the fruit name and the value will be the price of the piece of fruit.
            Dictionary<string, double> fruit = new Dictionary<string, double>();
            fruit.Add("apples", 0.99);
            fruit.Add("oranges", 0.50);
            fruit.Add("bananas", 0.50);
            fruit.Add("grapes", 2.99);
            fruit.Add("blueberries", 1.99);
            //bool isvalid = false;
            double price;
            string fruitname;
            do
            {
            Console.WriteLine("Please enter the fruit you desire.");
            fruitname = Console.ReadLine();

            if (fruit.ContainsKey("apples"))
                {
                    fruitname = fruit("apples");
                Console.WriteLine($"The price of apples is {price:C}");
                }
            else if(fruit.TryGetValue("oranges",out price))
            {
                Console.WriteLine($"The price of oranges is {price:c}");
            }
            
            } while (fruitname != KeyValuePair<string,double>);

            



        }
    }
}
