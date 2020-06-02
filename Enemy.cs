using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    abstract class Enemy : Entity
    {
        protected bool Alive = true;
        public Action isKilled;
        public abstract void Fight();
        public Target targetName;
        public bool IsAlive()
        {
            return Alive;
        }
        public void Kill()
        {
            Alive = false;
            Program.EnemyNum--;
            isKilled?.Invoke();
        }
    
    }
}
