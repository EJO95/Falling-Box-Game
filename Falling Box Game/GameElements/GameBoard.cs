using Falling_Box_Game.GameInterfaces;

namespace Falling_Box_Game.GameElements
{
    public class GameBoard : IGameBoard
    {
        public int BoardHeight { get; set; }
        public int BoardWidth { get; set; }
        //(0,0) Bottom left corner
        //(0,boardHeight) Bottom right corner
        //(BoardWidth, 0) Top left corner
        //(BoardWidth, boardHeight) Top Right Corner
        public GameBoard(int height, int width)
        {
            BoardHeight = height;
            BoardWidth = width;
        }

    }
}
