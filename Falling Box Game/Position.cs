using System;

namespace Falling_Box_Game
{
    class Position
    {
        private int x, y;

        public int X
        {
            get => x;
        }
        public int Y
        {
            get => y;
        }

        //initializes poison to be on the board at x, y position
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //default point if no x, y coordinates are given
        public Position() => new Position(0,0);

        public void setPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public String toString()
        {
            String res = "Point is (" + x + "," + y + ")";
            return res;
        }

    }
}
