using System;

namespace Game
{
    class Node
    {
        public Entity entity=null;
        protected bool Empty=true;

        public bool IsEmpty()
        {
            return Empty;
        }
        public void Initial(Entity _entity)
        {
            if (IsEmpty())
            {
                entity = _entity;
                Empty = false;
            }
            else
            {
                Console.WriteLine("This Node isn't available");
            }
        }
        public void SetEmpty()
        {
            entity = null;
            Empty = true;
        }
    }
}
