using System;
using Falling_Box_Game.GameHandlers;
using Falling_Box_Game.GameElements;

namespace Falling_Box_Game.GameInterfaces
{
    interface IPosition
    {
        Position Position
        { get; set; }

        void PlacePoision(double x, double y);

        Boolean PlayerAndPoison(Player player);

        void Grow(double growRate);

    }
}
