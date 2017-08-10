using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Weather
    {
        private string[] weather = { "sunny", "partly cloudy", "cloudy", "scattered showers", "heavy rain" };
        private string weatherOfDay = "";

        public Weather()
        {

        }

        public string GetWeather
        {
            get
            {
                return weatherOfDay;
            }
            set
            {
                Random random = new Random();
                int number = random.Next(0, weather.Length - 1);

                weatherOfDay = weather[number];
            }
        }
    }
}
