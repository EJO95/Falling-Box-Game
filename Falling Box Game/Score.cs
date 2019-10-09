using System;
using System.Collections.Generic;
using System.Text;

namespace Falling_Box_Game
{
    public class Score
    {
        public int score { get; private set; }
        public Score()
        {
            score = 0; 
        }
        public int updateScore(int newScore)
        {
            if(newScore > score)
            {
                score = newScore; 
            }
            return score; 
        }
        
    }
}
