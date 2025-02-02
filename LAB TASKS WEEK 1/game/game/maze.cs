using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Maze
    {
        private string[] layout = new string[]
        {
        "#################################################################################",
        "#   O                              O                                  O        #",
        "#  /|\\                           /|\\                               /|\\         #",
        "#  / \\                           / \\                               / \\         #",
        "#                                                                              #",
        "#                                                                              #",
        "#                                                                              #",
        "#                                                                              #",
        "#                    |*|                                                       #",
        "#                                                                              #",
        "#                                                                              #",
        "#                                                                              #",
        "#                                                                              #",
        "#                0                                                             #",
        "#               /|\\                                                            #",
        "#               / \\                                                            #",
        "#################################################################################"
        };

        public void Print()
        {
            Console.Clear();
            foreach (string line in layout)
            {
                Console.WriteLine(line);
            }
        }

        public char GetCharAt(int x, int y)
        {
            if (y >= 0 && y < layout.Length && x >= 0 && x < layout[y].Length)
            {
                return layout[y][x];
            }
            return '#';
        }
    }


}
