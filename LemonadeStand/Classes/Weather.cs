﻿using System;
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
            string rain = "none";
            
            if(this.cloud == "none")
            {
                rain = "Rain chance is low to none.";
            }
            else
            {
                rain = RainType();
            }

            return rain;
        }

        public string RainType()
        {
            string type = "";
            Random random = new Random();
            int number = random.Next(0, 6);

            type = GetRainAmount(number);

            return type;
        }

        public string GetRainAmount(int number)
        {
            string heaviness = "";

            switch(number)
            {
                case 0:
                case 3:
                case 5:
                    heaviness = "scattered";
                    return heaviness;
                case 1:
                case 4:
                    heaviness = "light";
                    return heaviness;
                case 2:
                    heaviness = "heavy";
                    return heaviness;
                default:
                    return heaviness;
            }
        }

        public string GetCloud()
        {
            string cloud = "";
            Random random = new Random();
            int number = random.Next(0, 10);

            cloud = GetTypeOfCloud(number);

            return cloud;
        }

        public string GetTypeOfCloud(int number)
        {
            string type = "";

            switch(number)
            {
                case 2:
                case 4:
                case 6:
                case 8:
                    type = "none";
                    return type;
                case 0:
                case 5:
                    type = "partly";
                    return type;
                case 1:
                case 7:
                    type = "mostly";
                    return type;
                case 3:
                case 9:
                    type = "cloudy";
                    return type;
                default:
                    return type;
            }
        }

        public string GetTemperature()
        {
            string temperature = "";

            // TODO:

            return temperature;
        }
    }
}
