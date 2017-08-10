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
        Inventory intventory = new Inventory();
        
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

        public void GetProfit()
        {

        }

        public void GetLoss()
        {

        }
    }
}
