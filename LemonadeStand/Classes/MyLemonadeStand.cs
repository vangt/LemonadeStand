using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class MyLemonadeStand
    {
        Player player = new Player();
        Weather weather = new Weather();
        Store store = new Store();
        List<Customer> customers = new List<Customer>();

        public void Start()
        {
            
            double days = 1;

            player.GetPlayer();
            WelcomeMessage();

            while (days < 7)
            {
                Console.WriteLine("Day " + days);
                weather.GetWeatherForecast = weather.GetRandomWeather();
                weather.GetTemperature = weather.GetRandomTemperature();
                GetForcast(weather.GetWeatherForecast, weather.GetTemperature);
                double cupsUsed = 0;
                double currentWallet = player.GetWallet;
                double sales = 0;

                GetStore();

                cupsUsed += GetRecipe();
                double price = GetPrice();
                double cost = currentWallet - player.GetWallet;

                weather.GetActualWeather = weather.GetTodaysActualWeather();
                weather.GetActualTemperature = weather.GetNewTemperature() ;

                GetActualWeather(weather.GetActualWeather, weather.GetActualTemperature);

                GenerateCustomers(weather.GetActualWeather, weather.GetActualTemperature, price);

                sales = GetNumberOfSales(customers, price);

                player.GetProfitLoss(cost, sales);

                days++;
            }

            player.GetNetProfitLoss();
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("You have decided to earn some extra change by selling lemonade. \n You have only 7 days to earn extra cash before you have to go back to your real job. \n You start out with 25 dollars to buy lemons, sugar, ice, and cups. \n You can mix your own recipe and add a price, 1 recipe makes 10 cups. \n You will get the forcast of that day's weather and it could change. \n Remember that the weather affect a customer's thirst level.");
            Console.ReadLine();
        }

        public void GetForcast(string todayWeather, double todayTemperature)
        {
            Console.WriteLine("The forcast for today is " + todayWeather + " and a high of " + todayTemperature);
            Console.ReadLine();
        }

        public void GetActualWeather(string actualWeather, double actualTemperature)
        {
            Console.WriteLine("The actual weather today is " + actualWeather + " and a high of " + actualTemperature);
            Console.ReadLine();
        }

        public void BuyLemons(double wallet)
        {
            Console.WriteLine("You currently have " + wallet + " in your wallet.");
            Console.WriteLine("Lemons are .50 cents per lemon. How many lemons would you like to buy?");
            double buyLemon = player.BuyAmount();
            GetLemons(buyLemon, store.GetLemonPrice, wallet);
        }

        public void GetLemons(double item, double price, double wallet)
        {
            string itemsToBuy = player.Buy(item, price);

            if(itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enougn money.");
                Console.ReadLine();
                BuyLemons(wallet);
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

        public void BuySugar(double wallet)
        {
            Console.WriteLine("You currently have " + wallet + " in your wallet.");
            Console.WriteLine("Sugar is .75 cents a lbs. How much sugar would you like to buy?");
            double buySugar = player.BuyAmount();
            GetSugar(buySugar, store.GetSugarPrice, wallet);
        }

        public void GetSugar(double item, double price, double wallet)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enough money.");
                Console.ReadLine();
                BuySugar(wallet);
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

        public void BuyIce(double wallet)
        {
            Console.WriteLine("You currently have " + wallet + " in your wallet.");
            Console.WriteLine("Ice is .10 cents a bag. How much ice would you like to buy?");
            double buyIce = player.BuyAmount();
            GetIce(buyIce, store.GetIcePrice, wallet);
        }

        public void GetIce(double item, double price, double wallet)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enough money.");
                Console.ReadLine();
                BuyIce(wallet);
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

        public void BuyCup(double wallet)
        {
            Console.WriteLine("You currently have " + wallet + " in your wallet.");
            Console.WriteLine("Cups are .05 cents a cup. How many cups would you like to buy?");
            double buyCup = player.BuyAmount();
            GetCup(buyCup, store.GetCupPrice, wallet);
        }

        public void GetCup(double item, double price, double wallet)
        {
            string itemsToBuy = player.Buy(item, price);

            if (itemsToBuy == "Not enough money")
            {
                Console.WriteLine("Not enough money.");
                Console.ReadLine();
                BuyCup(double wallet);
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

            BuyLemons(player.GetWallet);
            BuySugar(player.GetWallet);
            BuyIce(player.GetWallet);
            BuyCup(player.GetWallet);
        }

        public double GetRecipe()
        {
            double cupsUsed = 0;
            double amount = 0;

            Console.WriteLine("How many recipe batches do you wish to make?");
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
                GetRecipe();
            }

            if (player.GetInventory.GetCupList.Count > 10 * amount)
            {
                player.GetRecipe(amount);

                for(int i = 0; i <= 10; i++)
                {
                    player.GetInventory.RemoveCup();
                }

                cupsUsed += (10 * amount);
            }
            else
            {
                Console.WriteLine("You need more cups to make a recipe.");
                Console.ReadLine();
                GoBackToStore();                
            }

            return cupsUsed;
        }

        public void GoBackToStore()
        {
            Console.WriteLine("Do you wish to go back to the store?");
            string yesNo = Console.ReadLine();

            if(yesNo == "yes")
            {
                GetStore();
                GetRecipe();
            }
        }

        public void GenerateCustomers(string weather, double temperature, double price)
        {
            for(double i = 0; i <= 100; i++)
            {
                Customer customer = new Customer(weather, temperature, price);
                customers.Add(customer);
            }
        }

        public double GetNumberOfSales(List<Customer> customers, double price)
        {
            double numberOfCustomers = 0;
            double sales = 0;

            foreach(Customer customer in customers)
            {
                if(customer.AddRemoveThirst > 75)
                {
                    player.AddRemoveMoney += price;
                    numberOfCustomers++;
                    sales += price;
                }
            }

            Console.WriteLine("You had " + numberOfCustomers + " customers.");
            Console.ReadLine();

            return sales;
        }
    }
}