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
                temperature = value;
            }
        }

        public double GetActualTemperature
        {
            get
            {
                return temperature;
            }
            set
            {
                temperature = value;
            }
        }

        public double GetNewTemperature()
        {
            Random random = new Random();
            int plusminus = random.Next(0, 1);
            double number = random.Next(0, 6);

            if(plusminus == 0)
            {
                GetTemperature += number;
            }
            else
            {
                GetTemperature -= number;
            }

            return temperature;
        }

        public string GetWeatherForecast
        {
            get
            {
                return weatherOfDay;
            }
            set
            {
                weatherOfDay = value;
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
                weatherOfDay = value;
            }
        }


        public string GetTodaysActualWeather()
        {
            string weatherOfToday = "";

            Random random = new Random();
            int number = random.Next(0, 2);

            if (number == 0)
            {
                weatherOfToday = GetWeatherForecast;
            }
            else
            {
                weatherOfToday = IncreaseDecrease(weatherOfDay);
            }

            return weatherOfToday;
        }
        public double GetRandomTemperature()
        {
            Random random = new Random();
            double temperature = random.Next(50, 100);

            return temperature;
        }

        public string GetRandomWeather()
        {
            string todaysWeather = "";
            Random random = new Random();
            int number = random.Next(0, weather.Length);

            todaysWeather = weather[number];
            return todaysWeather;
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
                else if (weatherOfDay == weather[weather.Length - 1])
                {
                    newWeather = weather[i - 1];
                }
            }

            return newWeather;
        }
    }
}
