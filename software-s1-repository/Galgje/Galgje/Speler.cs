using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    class Speler
    {
        private int lives = 6;

        public void RemoveLife()
        {
            lives--;
        }

        public bool CheckIfDead()
        {
            bool dead = false;
            if (lives == 0)
            {
                return dead = true;
            }
            return dead;
        }
    }
}
