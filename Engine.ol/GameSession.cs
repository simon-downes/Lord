using System;
using System.Collections.Generic;
using System.Text;

using Engine.Models;

namespace Engine
{
    public class GameSession
    {

        private Player _currentPlayer;

        public Player CurrentPlayer
        {
            get => _currentPlayer;
            private set
            {
                _currentPlayer = value;
            }
        }
        public GameSession()
        {
            CurrentPlayer = new Player("Commander Jameson");
        }


    }
}
