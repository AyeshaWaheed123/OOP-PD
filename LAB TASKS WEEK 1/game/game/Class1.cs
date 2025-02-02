using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Entity
    {
        protected int x, y;
        protected char[,] shape;

        public Entity(int startX, int startY, char[,] entityShape)
        {
            x = startX;
            y = startY;
            shape = entityShape;
        }

        protected void Gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        public void Print()
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Gotoxy(x, y + i);
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.Write(shape[i, j]);
                }
            }
        }

        public void Erase()
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Gotoxy(x, y + i);
                Console.Write(new string(' ', shape.GetLength(1)));
            }
        }
    }
}
