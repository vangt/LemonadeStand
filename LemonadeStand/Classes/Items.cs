﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public abstract class Items
    {
        protected string name;
        protected double price;

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public virtual double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
