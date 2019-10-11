using System;
using System.Collections.Generic;
using System.Text;
using Falling_Box_Game.GameHandlers;
using Falling_Box_Game.GameInterfaces;

namespace Falling_Box_Game.GameElements
{ 

    class Poison : IPoison
    {
        private Position position;

        public Poison(int X, int Y)
        {
            position = new Position();
            position.setPoint(X, Y);
        }

        public Position Position
        {
            get => position;
            set => new Position();
        }

        public void Grow(int growRate)
        {
            position.setPoint(position.X, position.Y + growRate);
        }

        public void PlacePoision(int x, int y)
        {
            position.setPoint(x, y);
        }

        //if player meets death from touching poison then true, otherwise false
        public bool PlayerAndPoison(Player player)
        {
            return player.PlayerPositionX <= position.X && 
                (player.PlayerPositionY + (player.Size / 2) <= position.Y);
        }


    }
}
