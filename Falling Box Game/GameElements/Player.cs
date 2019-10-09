namespace Falling_Box_Game.GameElements
{
    class Player
    {
        public int Size { get; set; }
        public bool IsAlive { get; set; }
        public bool IsAirborne { get; set; }
        public bool IsOnSideOfBox { get; set; }
        public int PlayerPositionX { get; set; }
        public int PlayerPositionY { get; set; }
        public Player(int sizeOfCharacter, int startX)
        {
            Size = sizeOfCharacter;
            IsAlive = true;
            IsAirborne = false;
            IsOnSideOfBox = false;
            PlayerPositionX = startX;
            PlayerPositionY = 0;
        }

        /* Method that crushes the player. When this method is called, player.IsAlive = false
         and updateGameBoard is called so that the the screen will tell the player the game 
         is over and let them know their score */
        
        public void Crush(Player player)
        {
            player.IsAlive = false; 

        }
    }
}
