using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Inventory
    {
        private double lemon;
        private double sugar;
        private double ice;

        public Inventory()
        {

        }

        public void AddLemon(int number)
        {
            lemon += number;
        }

        public void AddSugar(int number)
        {
            sugar += number;
        }

        public void AddIce(int number)
        {
            ice += number;
        }

        public void RemoveLemon(int number)
        {
            lemon -= number;

            if(lemon < 0)
            {
                lemon = 0;
            }
        }

        public void RemoveSugar(int number)
        {
            sugar -= number;

            if(sugar < 0)
            {
                sugar = 0;
            }
        }

        public void RemoveIce(int number)
        {
            ice -= number;

            if(ice < 0)
            {
                ice = 0;
            }
        }
    }
}
