
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Move
    {
        Right,
        Left,
        Up,
        Down
    }
    static class Map
    {
        public static Node[,] map = new Node[7, 7];
        public static Action<int,int> NodeisFull;
        public static void Init()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    map[i, j] = new Node();
                }
            }
        }
        public static void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                Console.Write("     ");
                for (int j = 0; j < 7; j++)
                {
                    if (map[i, j].entity == null)
                        Console.Write(".");
                    else
                        Console.Write(map[i,j].entity.Name);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
       

        public static void SetEntity(Entity entity)
        {
            int x = entity.PosX;
            int y = entity.PosY;
            if (map[y, x].IsEmpty())
            {
                map[y, x].Initial(entity);
            }
            else
                Console.WriteLine("Node is Full");
        }

        

        public static void MovePlayer(Player player, Move move)
        {
            int x = player.PosX;
            int y = player.PosY;
            switch (move)
            {
                case Move.Right:
                    if (x + 1 < 7)
                    {
                        if (map[y, x + 1].IsEmpty())
                        {
                            map[y, x].SetEmpty();
                            map[y, x + 1].Initial(player);
                            player.MoveRight();
                        }
                        else
                        {
                            NodeisFull?.Invoke(y,x+1);
                        }
                    }
                    break;
                case Move.Left:
                    if (x - 1 >= 0)
                    {
                        if (map[y, x - 1].IsEmpty())
                        {
                            map[y, x].SetEmpty();
                            map[y, x - 1].Initial(player);
                            player.MoveLeft();
                        }
                        else
                        {
                            NodeisFull?.Invoke(y,x-1);
                        }
                    }
                    break;
                case Move.Up:
                    if (y - 1 >= 0)
                    {
                        if (map[y-1, x].IsEmpty())
                        {
                            map[y, x].SetEmpty();
                            map[y - 1, x].Initial(player);
                            player.MoveUp();
                        }
                        else
                        {
                            NodeisFull?.Invoke(y - 1, x);
                        }
                    }
                    break;
                case Move.Down:
                    if (y + 1 < 7)
                    {
                        if (map[y+1, x].IsEmpty())
                        {
                            map[y, x].SetEmpty();
                            map[y + 1, x].Initial(player);
                            player.MoveDown();
                        } else
                        {
                            NodeisFull?.Invoke(y+1,x);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Try Another Move");
                    break;
            }
        }



    }
}
