namespace Falling_Box_Game.GameInterfaces
{
    public interface IGameBoard
    {
        int BoardHeight { get; set; }
        int BoardWidth { get; set; }
        
        bool GameOver { get; set; }
    }
}