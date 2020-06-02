using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Bow : Item
    {
        public Bow()
        {
            Range[0] = 2;
            Range[1] = 6;
            target = Target.Dragon;
            Cost = 25;
            name = "Bow";
        }
        public override void Dmg(int Hp)
        {
            Hp -= GetRange();
        }
        public void CriticalDmg(int Hp)
        {
            Random random = new Random();
            int Chance = random.Next(0, 100);
            if(Chance < 20)
            {
                Hp -= (int)( 1.3f * (GetRange()));
            }
        }
    }
}
