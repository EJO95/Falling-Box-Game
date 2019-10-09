using System;
using System.Collections.Generic;
using System.Text;

namespace Falling_Box_Game
{
    class Player
    {
        public int Size { get; set; }
        public bool IsAlive { get; set; }
        public bool IsAirborne { get; set; }
        public bool IsOnSideOfBox { get; set; }
        public Player(int sizeOfCharacter)
        {
            Size = sizeOfCharacter;
            IsAlive = true;
            IsAirborne = false;
            IsOnSideOfBox = false;
        }
    }
}
