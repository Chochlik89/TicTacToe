using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerO = new Player(PlayerSign.O);
            Player playerX = new Player(PlayerSign.X);
            Board board = new Board();

            Console.WriteLine("Podaj imię pierwszego gracza:");
            playerO.Name = Console.ReadLine();

            Console.WriteLine("Podaj imię drugiego gracza:");
            playerX.Name = Console.ReadLine();

            Player currentPlayer = playerO;
            bool isAwinner = false;

            while (!board.IsBoardFull())
            {
                Console.WriteLine($"Gra {currentPlayer.Name}!");
                Console.WriteLine($"Podaj współrzędne X i Y odzielone spacją!");

                string stringCoordinates = Console.ReadLine();

                string[] coordinates = stringCoordinates.Trim().Split(' ');

                int x;
                int y;

                if (board.ValidatePosition(coordinates, out x, out y))
                {
                    board.SetPosition(x, y, currentPlayer.Sign);
                    if (isAwinner = Game.IsAWin(x, y, currentPlayer.Sign, board))
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine($"Niepoprawne współrzędne, podaj ponownie!");
                    continue;
                }

                //if (currentPlayer == playerO)
                //{
                //    currentPlayer = playerX;
                //}
                //else
                //{
                //    currentPlayer = playerO;
                //}

                currentPlayer = currentPlayer == playerO ? playerX : playerO;
            }

            if (isAwinner)
            {
                Console.WriteLine($"Wygrał {currentPlayer.Name}!");
            }
            else
            {
                Console.WriteLine("Remis!");
            }

            Console.ReadLine();
        }
    }
}
