using System;

namespace Falling_Box_Game
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
