using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Weather
    {
        public string rain;
        public string cloud;
        public string temperature;

        public Weather()
        {
        }

        public string GetRain()
        {
            string rain = "";

            // TODO:

            return rain;
        }

        public string GetCloud()
        {
            string cloud = "";
            Random random = new Random();
            int number = random.Next(0, 4);

            GetTypeOfCloud(number);

            return cloud;
        }

        public string GetTypeOfCloud(int number)
        {
            string type = "";



            return type;
        }

        public string GetTemperature()
        {
            string temperature = "";

            // TODO:

            return temperature;
        }
    }
}
