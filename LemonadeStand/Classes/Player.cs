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
        private double price;
        private double profit;
        private double loss;
        Inventory intventory = new Inventory();
        
        public Player()
        {

        }

        public void GetPlayer()
        {
            name = GetName;
            wallet += 10;
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

        public void BuyCup()
        {

        }

        public void BuyLemon()
        {

        }

        public void BuySugar()
        {

        }

        public void BuyIce()
        {

        }

        public void GetRecipe()
        {

        }

        public void AddMoney(double sales)
        {
            wallet += sales;
        }

        public void RemoveMoney(double price)
        {
            wallet -= price;
        }

        public void RemoveCup()
        {

        }

        public void RemoveLemon()
        {

        }

        public void RemoveSugar()
        {

        }

        public void RemoveIce()
        {

        }

        public void GetPrice()
        {

        }

        public void GetProfit()
        {

        }

        public void GetLoss()
        {

        }
    }
}
