using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Player
    {
        public string Name { get; set; }

        public PlayerSign Sign { get; private set; }

        public Player(PlayerSign sign)
        {
            Sign = sign;
        }
    }

    enum PlayerSign
    {
        X = 1,
        O = 0
    }
}
