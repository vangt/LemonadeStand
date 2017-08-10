using System;
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
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Thread.Sleep(1000);
                stopWatch.Stop();
                thirst = random.Next(40, 61);
            }
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

        public double AddThirst
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

        public double RemoveThirst
        {
            get
            {
                return thirst;
            }
            set
            {
                thirst -= value;
            }
        }
    }
}
