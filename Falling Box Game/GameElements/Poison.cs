using System;
using System.Collections.Generic;
using System.Text;
using Falling_Box_Game.GameHandlers;
using Falling_Box_Game.GameInterfaces;

namespace Falling_Box_Game.GameElements
{ 

    class Poison : IPoison
    {
        public Poison(int X, int Y)
        {
            Position Position = new Position();
            Position.setPoint(X, Y);
        }

        public Position Position 
        { 
            get => Position;
            set => new Position();
        }

        public void Grow(int growRate)
        {
            Position.setPoint(Position.X, Position.Y + growRate);
        }

        public void PlacePoision(int x, int y)
        {
            Position.setPoint(x, y);
        }

        //if player meets death from touching poison then true, otherwise false
        public bool PlayerAndPoison(Player player)
        {
            return player.PlayerPositionX <= Position.X && 
                (player.PlayerPositionY + (player.Size / 2) <= Position.Y);
        }


    }
}
