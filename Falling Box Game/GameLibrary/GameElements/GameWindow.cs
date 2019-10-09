using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.GameElements
{
    class GameWindow
    {
        int WindowHeightTop {get; set;}
        int WindowHeightBottom {get; set;}
        //Add methods to set a view window 100px in height with player location at center
        public void  trackPlayerHeight(IBoardObject player)
        {
            WindowHeightTop = player.getY;
            WindowHeightBottom = width;
        }
    }
}
