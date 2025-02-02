using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Enemy : Entity
    {
        private int startX, startY;
        private int directionX, directionY;

        public Enemy(int startX, int startY, int initialX, int initialY, int dirX, int dirY)
            : base(initialX, initialY, new char[,] {
            { ' ', 'O', ' ' },
            { '/', '|', '\\' },
            { '/', ' ', '\\' }
            })
        {
            this.startX = startX;
            this.startY = startY;
            directionX = dirX;
            directionY = dirY;
        }

        public void Move()
        {
            Erase();
            x += directionX;
            y += directionY;

            if (x > 80 || y > 13 || x < 2)
            {
                x = startX;
                y = startY;
            }

            Print();
        }
    }
}
