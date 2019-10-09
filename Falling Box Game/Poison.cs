using System;
using System.Collections.Generic;
using System.Text;

namespace Falling_Box_Game
{ 

    class Poison : IPosition
    {
        public Position Position 
        { 
            get => Position;
            set => new Position(); 
        }

        public void Grow(int growRate)
        {
            Position.setPoint(Position.X + growRate, Position.Y + growRate);
        }

        public void PlacePoision(int x, int y)
        {
            Position.setPoint(x, y);
        }

        public bool PlayerAndPoison(Player player)
        {
            return player.PlayerPositionX <= Position.X && 
                (player.PlayerPositionY + (player.Size / 2) <= Position.Y);
        }


    }
}
