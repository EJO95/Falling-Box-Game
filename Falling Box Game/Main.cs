using System.Collections.Generic;
using System.Threading;
using Falling_Box_Game.GameElements;

namespace Falling_Box_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>Location of game logic constants</summary>
            ///Player_Size, Board height and width, starting box interval
            ///
            #region constant game settings
            const int PLAYER_SIZE = 22;
            const int BOARD_WIDTH = 100;
            const int BOARD_HEIGHT = 600;
            const int START_INTERVAL = 500; //in miliseconds
            const int POISON_GROWTH_RATE = 4;
            const int POISON_Y_POSITION = 0;
            #endregion

            int delayTimer = START_INTERVAL;

            List<Box> boxGroup = new List<Box>();


            GameBoard gameBoard = new GameBoard(BOARD_HEIGHT, BOARD_WIDTH);
            Player player = new Player(PLAYER_SIZE, BOARD_WIDTH/2);
            GameWindow gameWindow = new GameWindow(gameBoard, player);
            Poison poison = new Poison(BOARD_WIDTH, POISON_Y_POSITION);

            while (player.IsAlive)
            {
                boxGroup.Add(new Box());
                //spawn new box
                //handle checking
                Thread.Sleep(delayTimer);
                poison.Grow(POISON_GROWTH_RATE);
                player.IsAlive = poison.PlayerAndPoison(player);
            }
        }
    }
}
