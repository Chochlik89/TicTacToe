using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public int[,] Current { get; set; }

        public Board()
        {
            Current = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Current[i, j] = -1;
                }
            }
        }

        public bool ValidatePosition(string[] coordinates, out int intX, out int intY)
        {
            if (coordinates.Length == 2)
            {
                int x;
                int y;

                if (int.TryParse(coordinates[0], out x) && int.TryParse(coordinates[1], out y))
                {
                    x--; y--;

                    if (x >= 0 && x <= 2 && y >= 0 && y <= 2)
                    {
                        if (Current[x, y] == -1)
                        {
                            intX = x;
                            intY = y;
                            return true;
                        }
                    }
                }
            }
            intX = -1;
            intY = -1;
            return false;
        }

        public void SetPosition(int x, int y, PlayerSign sign)
        {
            Current[x, y] = (int)sign;
        }

        public bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Current[i, j] == -1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
