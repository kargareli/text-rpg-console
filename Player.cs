using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{

    class Player : Entity
    {
        protected List<Item> weapons= new List<Item>();
        public int Score = 20;
       
        public Player()
        {
            HP = 10;
            Name = "P";
        }

        public void BuyWeapon(Item item)
        {
            if (Score > item.Cost && !item.IsBought())
            {
                Console.Write("You Buy it :)))");
                Score -= item.Cost;
                item.Buy();
                weapons.Add(item);
            }
            else if (Score < item.Cost)
            {
                Console.WriteLine("You don't have enough Score to buy this item");

            }
            else
                Console.WriteLine("You buy this item");
        }

      
        public void MoveRight()
        {
            Score += 10;
            PosX++;
        }
        public void MoveLeft()
        {
            Score += 10;
            PosX--;
        }
        public void MoveUp()
        {
            Score += 10;
            PosY--;
        }
        public void MoveDown()
        {
            Score += 10;
            PosY++;
        }

        
        public void Fight(int x,int y)
        {
           
            Console.Write("To fight without weapon press F6 , ");
            foreach (var weapon in weapons)
            {
               if(weapon.name == "Bow")
                {
                    Console.Write("To choose Bow press F3 ,");
                }
                else if (weapon.name == "Sword")
                {
                    Console.Write("To choose Bow press F4.");
                }
            }
            ConsoleKey tmp = Console.ReadKey().Key;
            Enemy enemy = (Enemy) Map.map[x, y].entity;
            switch (tmp)
            {
                case ConsoleKey.F6:
                    HP--;
                    enemy.Fight();
                    break;
                case ConsoleKey.F3:
                    if (Target.Dragon == enemy.targetName)
                    {
                        enemy.Kill();
                        Score += 20;
                        Map.map[x, y].SetEmpty();
                    }
                    break;
                case ConsoleKey.F4:
                    if (Target.Soldier == enemy.targetName)
                    {
                        enemy.Kill();
                        Score += 20;
                        Map.map[x,y].SetEmpty();
                    }
                    break;

            }

        }
    }
}
