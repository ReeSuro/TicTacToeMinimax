using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeModelTest
{
    class HumanPlayer : IPlayer
    {
        bool _IsFirstPlayer;

        public HumanPlayer(bool isFirstPlayer) {
            _IsFirstPlayer = isFirstPlayer;
        }


        public char[,] Move(char[,] gameBoard) {
            //Print the game board
            PrintBoard(gameBoard);
            //Receive player input 
            String row;
            int rowInt;
            String col;
            int colInt;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Select row to play: ");
                   
                    row = Console.ReadLine();
                    rowInt = Convert.ToInt32(row);
                    if (rowInt > 0 && rowInt < 4)
                        break;
                    else
                        Console.WriteLine("Invalid row");
                }
                while (true)
                {
                    Console.WriteLine("Select column to play: ");
                    col = Console.ReadLine();
                    colInt = Convert.ToInt32(col);
                    if (colInt > 0 && colInt < 4)
                        break;
                    else
                        Console.WriteLine("Invalid column");
                }

                if (gameBoard[rowInt-1, colInt-1] != ' ')
                    Console.WriteLine("Space already occupied, try again");
                else
                    break;
            }
            //Add move to the game board and return
            if (_IsFirstPlayer)
                gameBoard[rowInt-1, colInt-1] = 'X';
            else
                gameBoard[rowInt-1, colInt-1] = 'O';
            return gameBoard;
        }

        private void PrintBoard(char[,] gameBoard) {

            String str = " ";
            str += gameBoard[0, 0] + "|" + gameBoard[0, 1] + "|" + gameBoard[0, 2] + "\n";
            str += "--------\n";
            str += " " + gameBoard[1, 0] + "|" + gameBoard[1, 1] + "|" + gameBoard[1, 2] + "\n";
            str += "--------\n";
            str += " " + gameBoard[2, 0] + "|" + gameBoard[2, 1] + "|" + gameBoard[2, 2] + "\n";

            Console.WriteLine(str);
        }

    }
}
