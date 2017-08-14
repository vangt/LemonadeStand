using LemonadeStand.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyLemonadeStand lemonadeStand = new MyLemonadeStand();
            lemonadeStand.Start();
        }
    }
}
