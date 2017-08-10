using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Weather
    {
        private string[] weather = { "sunny", "partly cloudy", "cloudy" };
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
                int number = random.Next(0, 2);

                weatherOfDay = weather[number];

                weatherOfDay = GetRain(weatherOfDay);
            }
        }

        public string GetRain(string weatherOfDay)
        {
            if (weatherOfDay == "partly cloudy")
            {
                Random random = new Random();
                int number = random.Next(0, 1);

                return weatherOfDay = number == 0 ? weatherOfDay : weatherOfDay = "scattered showers";
            }
            else if (weatherOfDay == "cloudy")
            {
                Random random = new Random();
                int number = random.Next(0, 1);

                return weatherOfDay = number == 0 ? weatherOfDay : weatherOfDay = "heavy rain";
            }
            else
            {
                return weatherOfDay;
            }
        }
    }
}
