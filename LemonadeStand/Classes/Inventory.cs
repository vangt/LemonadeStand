using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.Classes
{
    public class Inventory
    {
        List<Lemon> lemons = new List<Lemon>();
        List<Sugar> sugars = new List<Sugar>();
        List<Ice> ices = new List<Ice>();
        List<Cup> cups = new List<Cup>();

        public Inventory()
        {

        }

        public void AddLemon()
        {
            Lemon lemon = new Lemon();
            lemons.Add(lemon);
        }

        public void AddSugar()
        {
            Sugar sugar = new Sugar();
            sugars.Add(sugar);
        }

        public void AddIce()
        {
            Ice ice = new Ice();
            ices.Add(ice);
        }

        public void AddCups()
        {
            Cup cup = new Cup();
            cups.Add(cup);
        }

        public void RemoveLemon()
        {
            lemons.RemoveAt(0);
        }

        public void RemoveSugar()
        {
            sugars.RemoveAt(0);
        }

        public void RemoveIce()
        {
            ices.RemoveAt(0);
        }

        public void RemoveCup()
        {
            cups.RemoveAt(0);
        }
    }
}
