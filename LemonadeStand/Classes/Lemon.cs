using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Lemon : Items
    {
        public Lemon(string name)
        {
            this.name = Name;
            this.price = Price;
        }

        public override string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = "Lemon";
            }
        }

        public override double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = .5;
            }
        }
    }
}
