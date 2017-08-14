using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class LemonadeStand
    {
        Player player = new Player();
        Weather weather = new Weather();
        Store store = new Store();

        public void Start()
        {
            
            double days = 1;

            player.GetPlayer();
            WelcomeMessage();

            while (days < 7)
            {
                string todayWeather = weather.GetWeatherForecast;
                double todayTemperature = weather.GetTemperature;
                GetForcast(todayWeather, todayTemperature);

                double currentWallet = player.GetWallet;

                Console.WriteLine("Welcome to the store.");
                BuyLemons();
                

                days++;
            }
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("You have decided to earn some extra change by selling lemonade. \n You start out with 10$ to buy lemons, sugar, ice, and cups. \n You can mix your own recipe and add a price. \n You will get the forcast of that day's weather and it could change. \n Remember that the weather affect a customer's thirst level.");
        }

        public void GetForcast(string todayWeather, double todayTemperature)
        {
            Console.WriteLine("The forcast for today is " + todayWeather + " and " + todayTemperature);
        }

        public void BuyLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            double buyLemon = player.BuyAmount();
            GetLemons(buyLemon, store.GetLemonPrice);
        }

        public void GetLemons(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if(itemsToBuy == "Not enough money")
            {
                BuyLemons();
            }
            else
            {
                for(double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddLemon();
                }
            }
        }

        public void BuySugar()
        {
            Console.WriteLine("How much sugar would you like to buy?");
            double buySugar = player.BuyAmount();
            GetSugar(buySugar, store.GetSugarPrice);
        }

        public void GetSugar(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                BuySugar();
            }
            else
            {
                for (double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddSugar();
                }
            }
        }

        public void BuyIce()
        {
            Console.WriteLine("How much ice would you like to buy?");
            double buyIce = player.BuyAmount();
            GetIce(buyIce, store.GetIcePrice);
        }

        public void GetIce(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                BuyIce();
            }
            else
            {
                for (double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddIce();
                }
            }
        }

        public void BuyCup()
        {
            Console.WriteLine("How much cup would you like to buy?");
            double buyCup = player.BuyAmount();
            GetCup(buyCup, store.GetCupPrice);
        }

        public void GetCup(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                BuyCup();
            }
            else
            {
                for (double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddCups();
                }
            }
        }
    }
}