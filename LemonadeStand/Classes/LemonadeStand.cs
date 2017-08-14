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
                Console.WriteLine("Day " + days);
                string todayWeather = weather.GetWeatherForecast;
                double todayTemperature = weather.GetTemperature;
                GetForcast(todayWeather, todayTemperature);

                double currentWallet = player.GetWallet;

                GetStore();
                GetPrice();


                double cost = currentWallet - player.GetWallet;



                days++;
            }
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("You have decided to earn some extra change by selling lemonade. \n You have only 7 days to earn extra cash before you have to go back to your real job. \n You start out with 10$ to buy lemons, sugar, ice, and cups. \n You can mix your own recipe and add a price. \n You will get the forcast of that day's weather and it could change. \n Remember that the weather affect a customer's thirst level.");
            Console.ReadLine();
        }

        public void GetForcast(string todayWeather, double todayTemperature)
        {
            Console.WriteLine("The forcast for today is " + todayWeather + " and " + todayTemperature);
            Console.ReadLine();
        }

        public void BuyLemons()
        {
            Console.WriteLine("Lemons are .50 cents per lemon. How many lemons would you like to buy?");
            double buyLemon = player.BuyAmount();
            GetLemons(buyLemon, store.GetLemonPrice);
        }

        public void GetLemons(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if(itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enougn money.");
                Console.ReadLine();
                BuyLemons();
            }
            else
            {
                Console.WriteLine("You've bought " + item + " lemons.");
                for(double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddLemon();
                }
            }
        }

        public void BuySugar()
        {
            Console.WriteLine("Sugar is .75 cents a lbs. How much sugar would you like to buy?");
            double buySugar = player.BuyAmount();
            GetSugar(buySugar, store.GetSugarPrice);
        }

        public void GetSugar(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enough money.");
                Console.ReadLine();
                BuySugar();
            }
            else
            {
                Console.WriteLine("You've bought " + item + " lbs of sugar.");
                for (double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddSugar();
                }
            }
        }

        public void BuyIce()
        {
            Console.WriteLine("Ice is .10 cents a bag. How much ice would you like to buy?");
            double buyIce = player.BuyAmount();
            GetIce(buyIce, store.GetIcePrice);
        }

        public void GetIce(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enough money.");
                Console.ReadLine();
                BuyIce();
            }
            else
            {
                Console.WriteLine("You've bought " + item + " bags of ice.");
                for (double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddIce();
                }
            }
        }

        public void BuyCup()
        {
            Console.WriteLine("Cups are .05 cents a cup. How many cups would you like to buy?");
            double buyCup = player.BuyAmount();
            GetCup(buyCup, store.GetCupPrice);
        }

        public void GetCup(double item, double price)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enough money.");
                Console.ReadLine();
                BuyCup();
            }
            else
            {
                Console.WriteLine("You've bought " + item + " cups.");
                for (double i = 0; i <= item; i++)
                {
                    player.GetInventory.AddCups();
                }
            }
        }

        public double GetPrice()
        {
            double price = 0;

            Console.WriteLine("Please enter a price. Max price is 99 cents.  DO NOT ADD THE DECIMAL. Anything entered higher than 99 will be coverted (i.e. 100 = .10, 89989 = .90, 1 = .10, etc.");
            try
            {
                price = double.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("You've made an invalid entry.");
                GetPrice();
            }

            if(price < 1)
            {
                Console.WriteLine("You've entered a number less than 1.");
                GetPrice();
            }
            else
            {
                price = ConvertPrice(price);
            }

            Console.WriteLine("You chose " + price + " per cup of lemonade.");
            Console.ReadLine();

            return price;
        }

        public double ConvertPrice(double price)
        {
            string newPrice = price.ToString();
            newPrice = ("." + newPrice);
            decimal priceToReturn = decimal.Parse(newPrice);
            priceToReturn = decimal.Round(priceToReturn, 2);
            newPrice = priceToReturn.ToString();
            double number = double.Parse(newPrice);
            return number;
        }

        public void GetStore()
        {
            Console.WriteLine("Welcome to the store.");
            Console.WriteLine("You currently have " + player.GetInventory.GetLemonList.Count + "of lemons, " + player.GetInventory.GetSugarList.Count + " lbs of sugar, " + player.GetInventory.GetIceList.Count + " bags of ice, " + player.GetInventory.GetCupList.Count + " of cups. \n");

            BuyLemons();
            BuySugar();
            BuyIce();
            BuyCup();
        }


    }
}