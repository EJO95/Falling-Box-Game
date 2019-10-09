using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Interfaces
{
    interface IGameWindow
    {
        void trackPlayer(IBoardObject player){set; }
    }
}
