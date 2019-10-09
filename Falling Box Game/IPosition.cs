using System;

namespace Falling_Box_Game
{
    interface IPosition
    {
        Position Position
        { get; set; }

        void PlacePoision(int x, int y);

        Boolean PlayerAndPoison(Player player);

        void Grow(int growRate);

    }
}
