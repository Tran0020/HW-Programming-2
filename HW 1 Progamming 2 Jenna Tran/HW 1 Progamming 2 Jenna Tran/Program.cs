﻿using System;

namespace HW_1_Progamming_2_Jenna_Tran
{
    class Program
    {
       public const double cogs = 79.99;
        public const double gears = 250.00;
        public const double standardMarkup = 0.15;
        public const double specialMarkup = 0.125;


        static void Main(string[] args)
        {//DONE
            //You will be creating an application to help our sales associates sell our main products, cogs and gears.
            // Cogs have a whole sale price of $79.99 and gears have a whole sale price of $250.00.
            // When our sales associates are selling to our customers on the floor, 
            //we have a standard 15 % markup on our wholesale price for our sales price.
            //  However, if the customer purchases more than 10 of either item or a combined quantity of 16 items 
            //we only markup the items by 12.5 %.On top of this, the sales tax for all sales is 8.9 %.
            //Create a console application that will prompt the sales associate for the number of cogs as well as the number of gears
            //for a salesorder.Create class level constant variables for the whole sale prices for the items as 
            //    well as the markup percentages.Once the user has input all of the data, create a receipt 
            //    and display the total cost for the items, the discount amount, the sales tax amount as well as the grand total.
            //    Format all values appropriately(e.g.percentages should have the appropriate format specifier, same with currency)
            //   as well as make the receipt user friendly(e.g. do not just list all the values next to each other, put on different
            //    lines and make sure to show what each value represents) 

            int cogs1, gears1;
            const double salesTax = 0.089;
            double totalcost, discountAmount, Tax, grandtotal, StandMarkupCogs, StandMarkupGears, SpecMarkupCogs, SpecMarkupGears;
            Console.WriteLine("Please enter the number of cogs needed for a saleorder.");
            cogs1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number of gears needed for a saleorder.");
            gears1 = Convert.ToInt32(Console.ReadLine());
            StandMarkupCogs = ((cogs + (cogs * standardMarkup)));
            StandMarkupGears =((gears + (gears * standardMarkup)));
            SpecMarkupCogs = ((cogs + (cogs * specialMarkup)));
            SpecMarkupGears = ((gears + (gears * specialMarkup)));


            if (cogs1 > 10 || gears1 > 10 || cogs1 + gears1 >= 16)
            {

                discountAmount = (cogs1 * (StandMarkupCogs - SpecMarkupCogs)) + (gears1 * (StandMarkupGears - SpecMarkupGears));
                totalcost = (cogs1 * SpecMarkupCogs) + (gears1 * SpecMarkupGears);
                Tax = totalcost * salesTax;
                grandtotal = totalcost + Tax;

                Console.WriteLine($"The total cost for the items are {totalcost:c}.\n" +
                $"The discount amount is {discountAmount:c}.\n" +
                $"The sales tax is {Tax:c}.\n" +
                $"The grand total is {grandtotal:c}");
            }
            else
            {
                discountAmount = 0.00;

                totalcost = (cogs1 * StandMarkupCogs) + (gears1 * StandMarkupGears);
                Tax = totalcost * salesTax;
                grandtotal = totalcost + Tax;

                Console.WriteLine($"The total cost for the items are {totalcost:c}.\n" +
                    $"The discount amount is {discountAmount:c}.\n" +
                    $"The sales tax is {Tax:c}.\n" +
                    $"The grand total is {grandtotal:c}");
            }


            Console.ReadLine();

        }
    }
}
