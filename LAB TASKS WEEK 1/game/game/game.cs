using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game
{
    class Game
    {
        private Maze maze;
        private Player player;
        private Enemy[] enemies;

        public Game()
        {
            Console.CursorVisible = false;
            maze = new Maze();
            player = new Player(15, 13, maze);
            enemies = new Enemy[]
            {
            new Enemy(2, 1, 4, 1, 1, 1),
            new Enemy(33, 1, 35, 1, 0, 1),
            new Enemy(68, 1, 68, 1, -1, 1)
            };
        }

        public void Run()
        {
            maze.Print();
            player.Print();
            foreach (var enemy in enemies) enemy.Print();

            while (true)
            {
                foreach (var enemy in enemies) enemy.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    player.HandleInput(key);
                }

                Thread.Sleep(100);
            }
        }
    }
}
