using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Target
    {
        Soldier,
        Dragon
    }
    class Sword : Item
    {
        public Sword()
        {
            Range[0] = 4;
            Range[1] = 7;
            target = Target.Soldier;
            Cost = 20;
            name = "Sword";
        }
        public override void Dmg(int Hp)
        {
            Hp -= GetRange();
        }
    
    }
}
