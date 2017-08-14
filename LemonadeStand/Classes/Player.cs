using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Player
    {
        private double wallet;
        private string name;
        private double profit;
        private double loss;
        private double netProfitLoss;
        Inventory inventory = new Inventory();
        
        public Player()
        {

        }

        public void GetPlayer()
        {
            name = GetName;
            AddRemoveMoney += 10;
        }

        public string GetName
        {
            get
            {
                return name;
            }  
            set
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            }
        }

        public double GetWallet
        {
            get
            {
                return wallet;
            }
        }

        public string Buy(double amount, double price)
        {
            double total = price * amount;
            string walletamount = "";

            if (wallet < total)
            {
                walletamount = "Not enough money";
            }
            else
            {
                walletamount = "You have enough money";
                AddRemoveMoney -= total;
            }

            return walletamount;
        }

        public void GetRecipe(double lemon, double sugar, double ice)
        {
            
        }

        public double AddRemoveMoney
        {
            get
            {
                return wallet;
            }
            set
            {
                wallet = value;
            }
        }

        public void GetProfit()
        {

        }

        public void GetLoss()
        {

        }

        public void GetNetProfitLoss()
        {

        }

        public double AskLemonAmount()
        {
            double lemon = 0;
            Console.WriteLine("How many lemons do you wish to put in your recipe?");

            try
            {
                lemon = double.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("That was not a valid number.");
            }

            return lemon;
        }

        public double AskSugarAmount()
        {
            double sugar = 0;
            Console.WriteLine("How many sugar do you wish to put in your recipe?");

            try
            {
                sugar = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid number.");
            }

            return sugar;
        }

        public double AskIceAmount()
        {
            double ice = 0;
            Console.WriteLine("How many ice do you wish to put in your recipe?");

            try
            {
                ice = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid number.");
            }

            return ice;
        }
    }
}
