using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    class TicTacToeGame
    {
        public char[,] _GameBoard; // Represents the game as a 3x3 Matrix of characters, X , O and " ".
        public IPlayer _Player1;    // The player objects represent one of the three player options
        public IPlayer _Player2;

        public TicTacToeGame(IPlayer player1, IPlayer player2) {

            _Player1 = player1;
            _Player2 = player2;
            _GameBoard = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        }


        //Returns 0 if the game has not finished
        //Returns 1 if the game has been won by player 1
        //Returns 2 if the game has been won by player 2
        //Returns 3 if the game has been drawn 
        public Int16 IsGameFinished() {

            //Check if player 1 has won
            bool oneWon = false;

            //check rows and columns
            for (int ind = 0; ind < 3; ind++) {

                if (_GameBoard[ind,0] == 'X' && _GameBoard[ind, 1] == 'X' && _GameBoard[ind, 2] == 'X') {
                    oneWon = true;
                }
                else if(_GameBoard[0,ind] == 'X' && _GameBoard[1,ind] == 'X' && _GameBoard[2,ind] == 'X') {
                    oneWon = true;
                }
            }
            //Check diagonals
            if (_GameBoard[0, 0] == 'X' && _GameBoard[1, 1] == 'X' && _GameBoard[2, 2] == 'X')
            {
                oneWon = true;
            }
            else if(_GameBoard[0, 2] == 'X' && _GameBoard[1, 1] == 'X' && _GameBoard[2, 0] == 'X')
            {
                oneWon = true;
            }

            //return if true
            if (oneWon)
                return 1;

            //Check if player 2 has won
            bool twoWon = false;

            //check rows and columns
            for (int ind = 0; ind < 3; ind++)
            {

                if (_GameBoard[ind, 0] == 'O' && _GameBoard[ind, 1] == 'O' && _GameBoard[ind, 2] == 'O')
                {
                    twoWon = true;
                }
                else if (_GameBoard[0, ind] == 'O' && _GameBoard[1, ind] == 'O' && _GameBoard[2, ind] == 'O')
                {
                    twoWon = true;
                }
            }
            //Check diagonals
            if (_GameBoard[0, 0] == 'O' && _GameBoard[1, 1] == 'O' && _GameBoard[2, 2] == 'O')
            {
                twoWon = true;
            }
            else if (_GameBoard[0, 2] == 'O' && _GameBoard[1, 1] == 'O' && _GameBoard[2, 0] == 'O')
            {
                twoWon = true;
            }

            //return if true
            if (twoWon)
                return 2;

            //Check for draw - if all spots are full
            int spaceCount = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (_GameBoard[row, col] == ' ')
                        spaceCount++;
                }

            }
            if (spaceCount == 0)
                return 3;

            return 0;
        }

        private void EndGame() { }
    }
}
