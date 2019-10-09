using System;
using System.Collections.Generic;
using System.Threading;

namespace Falling_Box_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PLAYER_SIZE = 22;
            const int BOARD_WIDTH = 100;
            const int BOARD_HEIGHT = 600;
            const int START_INTERVAL = 500;

            int delayTimer = START_INTERVAL;

            List<Box> boxGroup = new List<Box>();

            Player player = new Player(PLAYER_SIZE);
            //GameBoard gameBoard = new GameBoard(BOARD_WIDTH, BOARD_HEIGHT);
            while(player.IsAlive)
            {
                boxGroup.Add(new Box());
                //spawn new box
                //handle checking
                Thread.Sleep(delayTimer);
            }
        }
    }
}
