using System;
using Falling_Box_Game.GameHandlers;
using Falling_Box_Game.GameElements; 

namespace Falling_Box_Game.GameInterfaces
{
    interface IPoison
    {
        Position Position
        { get; set; }

        void PlacePoision(int x, int y);

        Boolean PlayerAndPoison(Player player);

        void Grow(int growRate);

    }
}
