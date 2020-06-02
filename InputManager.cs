using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Page
    {
        Game,
        Shop,
        EndGame
    }
    static class InputManager
    {
       public static Page currentPage= Page.Game;

        public static void Manager(Player player)
        {

            if (Program.EnemyNum >= 0)
            {
                switch (currentPage)
                {
                    case Page.Game:
                        if(Program.EnemyNum == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You Win.");
                            currentPage = Page.EndGame;
                            break;
                        }

                        GamePage(player);
                        break;
                    case Page.Shop:
                        ShopStore.ShopPage();
                        break;
                    case Page.EndGame:
                        
                        break;
                    default:
                        break;
                }
            }
            
           
          
        }




        public static void GamePage(Player player)
        {
            Console.Clear();
            Console.WriteLine(Program.EnemyNum);
            Console.WriteLine("HP = {0} , Score= {1}  ", player.HP, player.Score);
            Map.Print();
            Console.WriteLine("Shop=F1 , Move By WASD : ");
            ConsoleKey tmp = Console.ReadKey().Key;
            switch (tmp)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    currentPage = Page.Shop;
                    break;
                case ConsoleKey.W:
                    Map.MovePlayer(player, Move.Up);
                    break;
                case ConsoleKey.S:
                    Map.MovePlayer(player, Move.Down);
                    break;
                case ConsoleKey.A:
                    Map.MovePlayer(player, Move.Left);
                    break;
                case ConsoleKey.D:
                    Map.MovePlayer(player, Move.Right);
                    break;

            }
        }


    }
   
}
