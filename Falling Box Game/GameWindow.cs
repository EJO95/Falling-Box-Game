using System;
using System.Collections.Generic;
using System.Text;
using Falling_Box_Game;

namespace Falling_Box_Game
{
    class GameWindow : IGameWindow
    {
        int WindowHeight { get; set; }
        int WindowHeightTop { get; set; }
        int WindowHeightBottom { get; set; }

        public void TrackPlayerHeight(Player player)
        {
            if (player.PlayerPositionY <= WindowHeight / 2)
            {
                WindowHeightTop = WindowHeight;
            }
            else
            {
                WindowHeightTop = player.PlayerPositionY + WindowHeight / 2;
            }
            WindowHeightBottom = WindowHeightTop - WindowHeight;
        }
        public GameWindow(GameBoard gameBoard, Player player)
        {
            WindowHeight = gameBoard.BoardHeight / 3;
            TrackPlayerHeight(player);
        }
    }
}
