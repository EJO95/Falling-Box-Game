using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Interfaces
{
    public interface IBoardObject
    {
        void setX(int x) { set; }
        void setY(int y) { set; }

        int getX() { get; }

        int getY() { get; }

        //Add method to catch falling objects beyond the bottom boundry of board(this.y<0)

        //Add wrap method for when object moves beyond left(this.x<0) or right boundries(this.x>BoardWidth:500)
    }
}
