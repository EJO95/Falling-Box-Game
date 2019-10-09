using System;

namespace Falling_Box_Game
{

    public class Box
    {
        public int Size { get; private set; }
        public bool IsFalling { get; private set; }

        public Box()
        {
            Random rand = new Random();
            Size = rand.Next(1000); // This will need to be adusted 
            IsFalling = true;
        }

    }

}
