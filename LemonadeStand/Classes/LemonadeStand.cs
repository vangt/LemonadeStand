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
        Customer custome = new Customer();

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
    }
}