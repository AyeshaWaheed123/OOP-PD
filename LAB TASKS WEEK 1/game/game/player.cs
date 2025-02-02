using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Player : Entity
    {
        private Maze maze;

        public Player(int startX, int startY, Maze maze)
            : base(startX, startY, new char[,] {
            { ' ', 'O', ' ' },
            { '/', '|', '\\' },
            { '/', ' ', '\\' }
            })
        {
            this.maze = maze;
        }

        public void Move(int dx, int dy)
        {
            if (maze.GetCharAt(x + dx, y + dy) == ' ')
            {
                Erase();
                x += dx;
                y += dy;
                Print();
            }
        }

        public void HandleInput(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    Move(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    Move(-1, 0);
                    break;
                case ConsoleKey.UpArrow:
                    Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    Move(0, 1);
                    break;
            }
        }
    }
}
