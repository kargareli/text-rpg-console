using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Entity
    {
        public int HP;
        public int PosX, PosY;
        public string Name;

      
        public void Initial(int x, int y)
        {
            PosX = x;
            PosY = y;
        }


    }
}
