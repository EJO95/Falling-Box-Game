using System;
using System.Collections.Generic;
using System.Text;

namespace Falling_Box_Game
{
    public class playerHandlerClass
    {
        public playerHandlerClass()
        {
            KeyDown += new KeyEventHandler(Player_KeyDown);
        }
        //public event EventHandler KeyPressed;
        public void Player_KeyDown(object sender, KeyEventArgs key)
        {
            switch (key.KeyCode)
            {
                case Keys.Up:
                    Console.WriteLine("Up Key Pressed");
                    break;
                case Keys.Down:
                    Console.WriteLine("Down Key Pressed");
                    break;
            }
        }
    }
}
