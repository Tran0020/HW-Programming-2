using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2_Problem_1_and_2
{
    class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }
        private double SalesTaxPercent { get; set; }
        private double CogPrice { get; set; }
        private double GearPrice { get; set; }

        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Today;
            SalesTaxPercent = .089;
            CogPrice = 79.99;
            GearPrice = 250.00;
        }

        public Receipt(int id, int cog, int gear)
        {
            this.CustomerID = id;
            this.CogPrice = cog;
            this.GearPrice = gear;
        }

        public double CalculateTotal()
        {

        }

        public void PrintReceipt()
        {
            Console.WriteLine($"The # of cogs:{CogQuantity}/n The # of gears: {GearQuantity}/n ")
        }

        private double CalculateTaxAmount()
        {

        }

        private double CalculateNetAmount()
        {
            double cogpricewithstandmarkup = CogPrice * .15;
            double cogpricewithspecmarkup = CogPrice * .125;
            double gearspricewithstandmarkup = GearPrice * .15;
            double gearspricewithspecmarkup = GearPrice * .125;
            double netAmount;
            if (CogQuantity > 10 || GearQuantity > 10 || CogQuantity + GearQuantity > 16)
            {
                netAmount = (CogQuantity * cogpricewithspecmarkup) + (GearQuantity * gearspricewithspecmarkup);
            }
            else
            {
                netAmount = (CogQuantity * cogpricewithstandmarkup) + (GearQuantity * gearspricewithstandmarkup);
            }
            return netAmount;
        }
    }
}
