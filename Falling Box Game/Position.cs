using System;

namespace Falling_Box_Game
{
    class Position
    {
        private double x, y;

        public double X
        {
            get => x;
        }
        public double Y
        {
            get => y;
        }

        //initializes poison to be on the board at x, y position
        public Position(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //default point if no x, y coordinates are given
        public Position()
        {
            this.x = 0;
            this.y = 0;
        }

        public void setPoint(double x, double y)
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
