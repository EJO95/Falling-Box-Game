using System;
using System.Collections.Generic;
using System.Text;
using Falling_Box_Game.GameHandlers;
using Falling_Box_Game.GameInterfaces;

namespace Falling_Box_Game.GameElements
{ 

    class Poison : IPosition
    {
        public Position Position 
        { 
            get => Position;
            set => new Position(); 
        }

        public void Grow(double growRate)
        {
            Position.setPoint(Position.X + growRate, Position.Y + growRate);
        }

        public void PlacePoision(double x, double y)
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
