namespace Falling_Box_Game
{
    public class Score
    {
        public int ScoreBoard { get; private set; }
        public Score()
        {
            ScoreBoard = 0;
        }
        public int UpdateScore(int newScore)
        {
            if (newScore > ScoreBoard)
            {
                ScoreBoard = newScore;
            }
            return ScoreBoard;
        }

    }
}
