using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Weapon
    {
        Sword,
        Bow
    }

    static class ShopStore
    {
        public static Action<Item> BuyingWeapon;
        public static void ShopPage()
        {
            Sword sword = new Sword();
            Bow bow = new Bow();
            Console.WriteLine("Sword cost {0} and its target is {1}.To Buy it press F1.", sword.Cost, sword.target.ToString());
            Console.WriteLine("Bow cost {0} and its target is {1}.To Buy it press F2.", bow.Cost, bow.target.ToString());
            ConsoleKey tmp = Console.ReadKey().Key;
            if(tmp == ConsoleKey.F1)
            {
                BuyingWeapon?.Invoke(sword);
            }
            else if(tmp == ConsoleKey.F2)
            {
                BuyingWeapon?.Invoke(bow);
            }
            else
            {
                 tmp = Console.ReadKey().Key;
            }
            InputManager.currentPage = Page.Game;
        }
    }

}
