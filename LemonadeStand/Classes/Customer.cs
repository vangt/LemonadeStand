﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Customer
    {
        private double thirst;
        private bool isBuying;
        
        public Customer()
        {
            thirst = GetThirst;
        }

        public double GetThirst
        {
            get
            {
                return thirst;
            }
            set
            {
                Random random = new Random();
                GetTimer();
                thirst = random.Next(40, 61);
            }
        }

        public void GetTimer()
        {
            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
        }

        public bool IsBuying
        {
            get
            {
                return isBuying;
            }
            set
            {
                if(thirst > 75)
                {
                    isBuying = true;
                }
                else
                {
                    isBuying = false;
                }
            }
        }

        public double AddRemoveThirst
        {
            get
            {
                return thirst;
            }
            set
            {
                thirst += value;
            }
        }

        public void WeatherThirst(string weatherOfDay, double temperature)
        {
            if(temperature > 90)
            {
                
            }
        }
    }
}
