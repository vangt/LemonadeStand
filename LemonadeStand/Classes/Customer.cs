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
    }
}
