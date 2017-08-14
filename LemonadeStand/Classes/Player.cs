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

        public void GetRecipe()
        {
            LemonsToRemove();
            SugarToRemove();
            IceToRemove();
        }

        public void LemonsToRemove()
        {
            double number = 0;
            number = AskLemonAmount();

            if (number > inventory.GetLemonList.Count)
            {
                Console.WriteLine("You don't have that many lemons.");
                LemonsToRemove();
            }
            else
            {
                for (double i = 0; i <= number; i++)
                {
                    inventory.RemoveLemon();
                }
            }
        }

        public void SugarToRemove()
        {
            double number = 0;
            number = AskSugarAmount();

            if (number > inventory.GetSugarList.Count)
            {
                Console.WriteLine("You don't have that much sugar.");
                SugarToRemove();
            }
            else
            {
                for (double i = 0; i <= number; i++)
                {
                    inventory.RemoveSugar();
                }
            }
        }

        public void IceToRemove()
        {
            double number = 0;
            number = AskIceAmount();

            if (number > inventory.GetIceList.Count)
            {
                Console.WriteLine("You don't have that much ice.");
                IceToRemove();
            }
            else
            {
                for (double i = 0; i <= number; i++)
                {
                    inventory.RemoveIce();
                }
            }
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

        public void GetProfitLoss(double cost, double sales)
        {
            double amount = 0;
            
            if(sales > cost)
            {
                amount = sales - cost;
                Console.WriteLine("Today's profit is: " + amount);
            }
            else
            {
                amount = cost - sales;
                Console.WriteLine("Today's loss is: " + amount);
            }
        }

        public void GetNetProfitLoss(double net)
        {
            if (net > 0)
            {
                Console.WriteLine("You have a net income of: " + net);
            }
            else if (net < 0)
            {
                Console.WriteLine("You have a net loss of: " + net);
            }
            else
            {
                Console.WriteLine("You broke even at the end of 7 days.");
            }
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
