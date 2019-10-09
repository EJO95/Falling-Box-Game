﻿using System;
using System.Collections.Generic;
using System.Threading;

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
            const int START_INTERVAL = 500;

            #endregion

            int delayTimer = START_INTERVAL;

            List<Box> boxGroup = new List<Box>();

            GameBoard gameBoard = new GameBoard(BOARD_HEIGHT, BOARD_WIDTH);
            Player player = new Player(PLAYER_SIZE);

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