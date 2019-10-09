using System;
using System.Collections.Generic;
using System.Text;

namespace Falling_Box_Game
{
    interface PoisInterface
    {
        Position Position
        { get; set; }

        void PlacePoision(double x, double y);

        Boolean PlayerAndPoison(Player player);

        void Grow(double growRate);

    }
}
