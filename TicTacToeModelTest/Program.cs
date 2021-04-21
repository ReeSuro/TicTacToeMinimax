using System;

namespace TicTacToeModelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanPlayer player1 = new HumanPlayer(true);
            HumanPlayer player2 = new HumanPlayer(false);

            TicTacToeGame game = new TicTacToeGame(player1, player2);
        }
    }
}
