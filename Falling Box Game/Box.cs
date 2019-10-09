using System;

namespace Falling_Box_Game
{

    public class Box
    {
        public int size { get; private set; }
        public bool isFalling { get; private set; }

        public Box ()
        {
            Random rand = new Random();
            size = rand.Next(1000); // This will need to be adusted 
            isFalling = true; 
        }

    }

}
