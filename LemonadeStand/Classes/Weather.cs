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
        private double temperature = 0;

        public Weather()
        {

        }

        public double GetTemperature
        {
            get
            {
                return temperature;
            }
            set
            {
                Random random = new Random();
                double number = random.Next(50, 100);
            }
        }

        public string GetWeatherForecast
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

        public string GetActualWeather
        {
            get
            {
                return weatherOfDay;
            }
            set
            {
                Random random = new Random();
                int number = random.Next(0,2);

                if(number == 0)
                {
                    weatherOfDay = weatherOfDay;
                }
                else
                {
                    weatherOfDay = IncreaseDecrease(weatherOfDay);
                }
            }
        }

        public string IncreaseDecrease(string weatherOfDay)
        {
            string newWeather = "";
            Random randon = new Random();
            int number = randon.Next(0, 1);

            for(int i = 0; i <= weather.Length; i++)
            {
                if (weatherOfDay == weather[i] && weatherOfDay != weather[weather.Length - 1] && weatherOfDay != weather[0])
                {
                    if(number == 0)
                    {
                        newWeather = weather[i + 1];
                    }
                    else
                    {
                        newWeather = weather[i - 1];
                    }
                }
                else if (weatherOfDay == weather[0])
                {
                    newWeather = weather[i + 1];
                }
                else
                {
                    newWeather = weather[i - 1];
                }
            }

            return newWeather;
        }
    }
}
