using System;

namespace Game
{
    static class Program
    {
        static Player player = new Player();
        public static int EnemyNum = 4;
        static void Main(string[] args)
        {
            InitialGame();
            while (player.HP > 0)
            {
                InputManager.Manager(player);
            }
            if (player.HP <= 0)
                Console.WriteLine("Game Over");
        }


        public static void InitialGame()
        {
            Map.Init();
            Random random = new Random();
            Map.NodeisFull += player.Fight;
            ShopStore.BuyingWeapon += player.BuyWeapon;

            int x, y;
            for (int i = 0; i < 4; i++)
            {

                x = random.Next(0, 7);
                y = random.Next(0, 7);
                while (!Map.map[y, x].IsEmpty())
                {
                    x = random.Next(0, 7);
                    y = random.Next(0, 7);
                }

                int z = random.Next(0, 10);
                if (z < 5)
                {
                    Soldier soldier = new Soldier();
                    soldier.Initial(y, x);
                    Map.SetEntity(soldier);
                    soldier.isKilled += Map.map[y, x].SetEmpty;

                }
                else
                {
                    Dragon dragon = new Dragon();
                    dragon.Initial(y, x);
                    Map.SetEntity(dragon);
                    dragon.isKilled += Map.map[y, x].SetEmpty;
                }
            }

            x = random.Next(0, 7);
            y = random.Next(0, 7);
            while (!Map.map[y, x].IsEmpty())
            {
                x = random.Next(0, 7);
                y = random.Next(0, 7);
            }
            player.Initial(y, x);
            Map.SetEntity(player);
        }
    }
}
