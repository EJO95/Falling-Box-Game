using System;
using System.Collections.Generic;
using System.Text;

namespace Falling_Box_Game
{
    class Player
    {
        public int size { get; set; }
        public bool isAlive { get; set; }
        public bool isAirborne { get; set; }
        public bool isOnSideOfBox { get; set; }
        public Player(int sizeOfCharacter)
        {
            size = sizeOfCharacter;
            isAlive = true;
            isAirborne = false;
            isOnSideOfBox = false;
        }
    }
}
