using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    static class Game
    {
        public static bool IsAWin (int x, int y, PlayerSign sign, Board board)
        {
            bool isAWin = false;

            //Rows

            for (int i = 0; i < 3; i++)
            {
                if (board.Current[x, i] != (int)sign)
                {
                    isAWin = false;
                    break;
                }
                else
                {
                    isAWin = true;
                }
            }

            //Columns

            if (!isAWin) //if (isAWin != true) 
            {
                for (int i = 0; i < 3; i++)
                {
                    if (board.Current[i, y] != (int)sign)
                    {
                        isAWin = false;
                        break;
                    }
                    else
                    {
                        isAWin = true;
                    }
                }
            }

            //Diagonals

            if (!isAWin) //if (isAWin != true)
            {
                if (x == y)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (board.Current[i, i] != (int)sign)
                        {
                            isAWin = false;
                            break;
                        }
                        else
                        {
                            isAWin = true;
                        }
                    }
                }
            }

            if (!isAWin) //if (isAWin != true)
            {
                if (x == 1 && y == 1)
                {
                    if (board.Current[0, 2] == (int)sign && board.Current[2, 0] == (int)sign)
                    {
                        isAWin = true;
                    }
                }
            }
            
            if (!isAWin) //if (isAWin != true)
            {
                if ((x == 0 && y == 2) || (x == 2 && y == 0))
                {
                    if (board.Current[x, y] == (int)sign && board.Current[y, x] == (int)sign && board.Current[1, 1] == (int)sign)
                    {
                        isAWin = true;
                    }
                 }
            }

            return isAWin;
        }
    }
}
