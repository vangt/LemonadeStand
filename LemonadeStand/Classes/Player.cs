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
            Console.WriteLine("What is your name?");
            GetName = Console.ReadLine();
            AddRemoveMoney += 25;
        }

        public string GetName
        {
            get
            {
                return name;
            }  
            set
            {

                name = value;
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

        public double BuyAmount()
        {
            double amountToBuy = 0;

            try
            {
                amountToBuy = double.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("That is an invalid number. \n Please enter a number.");
                BuyAmount();
            }

            if (amountToBuy < 1)
            {
                Console.WriteLine("You entered a number lower than 1.  Your amount has reset to 0.");
                amountToBuy = 0;
            }

            return amountToBuy;
        }

        public void GetRecipe(double amount)
        {            
            Console.WriteLine("You have " + inventory.GetLemonList.Count + " lemons.");
            LemonsToRemove(amount);
            Console.WriteLine("You have " + inventory.GetSugarList.Count + " sugar.");
            SugarToRemove(amount);
            Console.WriteLine("You have " + inventory.GetIceList.Count + " ice.");
            IceToRemove(amount);
        }

        public void LemonsToRemove(double amount)
        {
            double number = 0;
            number = AskLemonAmount(amount);

            if (number * amount > inventory.GetLemonList.Count)
            {
                Console.WriteLine("You don't have that many lemons.");
                LemonsToRemove(amount);
            }
            else
            {
                for (double i = 0; i <= number; i++)
                {
                    inventory.RemoveLemon();
                }
            }
        }

        public void SugarToRemove(double amount)
        {
            double number = 0;
            number = AskSugarAmount(amount);

            if (number * amount > inventory.GetSugarList.Count)
            {
                Console.WriteLine("You don't have that much sugar.");
                SugarToRemove(amount);
            }
            else
            {
                for (double i = 0; i <= number; i++)
                {
                    inventory.RemoveSugar();
                }
            }
        }

        public void IceToRemove(double amount)
        {
            double number = 0;
            number = AskIceAmount(amount);

            if (number * amount > inventory.GetIceList.Count)
            {
                Console.WriteLine("You don't have that much ice.");
                IceToRemove(amount);
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

        public Inventory GetInventory
        {
            get
            {
                return inventory;
            }
        }

        public void GetProfitLoss(double cost, double sales)
        {
            double amount = 0;
            
            if(sales > cost)
            {
                amount = sales - cost;
                Console.WriteLine("Today's profit is: " + amount);
                GetProfit += amount;
            }
            else
            {
                amount = cost - sales;
                Console.WriteLine("Today's loss is: " + amount);
                GetLoss += amount;
            }
        }

        public double GetProfit
        {
            get
            {
                return profit;
            }
            set
            {
                profit = value;
            }
        }

        public double GetLoss
        {
            get
            {
                return loss;
            }
            set
            {
                loss = value;
            }
        }

        public double GetNet
        {
            get
            {
                return netProfitLoss;
            }
            set
            {
                netProfitLoss = value;
            }
        }

        public void GetNetProfitLoss()
        {
            GetNet = GetProfit - GetLoss;

            if (profit > loss)
            {
                Console.WriteLine("You have a net income of: " + GetNet);
                Console.ReadLine();
            }
            else if (loss > profit)
            {
                Console.WriteLine("You have a net loss of: " + GetNet);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You broke even.");
                Console.ReadLine();
            }
        }

        public double AskLemonAmount(double amount)
        {
            double lemon = 0;
            Console.WriteLine("How many lemons do you wish to put in your recipe? This number is multiplied by " + amount + " for the number of batches");

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

        public double AskSugarAmount(double amount)
        {
            double sugar = 0;
            Console.WriteLine("How many sugar do you wish to put in your recipe? This number is multiplied by " + amount + " for the number of batches");

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

        public double AskIceAmount(double amount)
        {
            double ice = 0;
            Console.WriteLine("How many ice do you wish to put in your recipe? This number is multiplied by " + amount + " for the number of batches");

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
