using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    class HumanPlayer : IPlayer
    {
        bool _IsFirstPlayer;

        public HumanPlayer(bool isFirstPlayer) {
            _IsFirstPlayer = isFirstPlayer;
        }

        public char[,] Decision(char[,] gameBoard)
        {
            throw new NotImplementedException();
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
