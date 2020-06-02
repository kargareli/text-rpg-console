using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Dragon : Enemy
    {
        public Dragon()
        {
            HP = 8;
            targetName = Target.Dragon;
            Name = "D";
        }
        public override void Fight()
        {
            if (HP > 0)
                HP--;
            else
                this.Kill();
        }
    }
}
