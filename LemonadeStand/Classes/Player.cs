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

        public void RemoveCup()
        {
            inventory.RemoveCup();
        }

        public void RemoveLemon()
        {
            inventory.RemoveLemon();
        }

        public void RemoveSugar()
        {
            inventory.RemoveSugar();
        }

        public void RemoveIce()
        {
            inventory.RemoveIce();
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
    }
}
