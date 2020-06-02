using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Item
    {
        public abstract void Dmg(int Hp);
        public int[] Range = new int[2];
        public Target target;
        public int Cost;
        private bool Bought = false;
        public string name;

        public int GetRange()
        {
            Random random = new Random();
            return random.Next(Range[0], Range[1]);
        }

        public void Buy()
        {
            Bought = true;
        }

        public bool IsBought()
        {
            return Bought;
        }
    }
}
