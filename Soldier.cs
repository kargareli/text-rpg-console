using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Soldier : Enemy
    {
        public Soldier()
        {
            HP = 5;
            targetName = Target.Soldier;
            Name = "S";
        }
        public override void Fight()
        {
            if (HP > 0)
                HP -= 2;
            else
                this.Kill();
        }
    }
}
