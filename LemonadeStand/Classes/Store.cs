using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Store
    {
        Lemon lemon = new Lemon();
        Sugar sugar = new Sugar();
        Ice ice = new Ice();
        Cup cup = new Cup();

        public Store()
        {

        }

        public double GetLemonPrice
        {
            get
            {
                return lemon.Price;
            }
        }

        public double GetSugarPrice
        {
            get
            {
                return sugar.Price;
            }
        }

        public double GetIcePrice
        {
            get
            {
                return ice.Price;
            }
        }

        public double GetCupPrice
        {
            get
            {
                return cup.Price;
            }
        }
    }
}
