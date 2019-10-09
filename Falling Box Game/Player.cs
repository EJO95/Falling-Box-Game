namespace Falling_Box_Game
{
    class Player
    {
        public int Size { get; set; }
        public bool IsAlive { get; set; }
        public bool IsAirborne { get; set; }
        public bool IsOnSideOfBox { get; set; }
        public int PlayerPositionX { get; set; }
        public int PlayerPositionY { get; set; }
        public Player(int sizeOfCharacter)
        {
            Size = sizeOfCharacter;
            IsAlive = true;
            IsAirborne = false;
            IsOnSideOfBox = false;
            PlayerPositionX = 0;
            PlayerPositionY = 0;
        }
    }
}
