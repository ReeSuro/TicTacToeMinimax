using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    class TicTacToeGame
    {
        public char[,] _GameBoard; // Represents the game as a 3x3 Matrix of characters, X , O and " ".
        public IPlayer _Player1;    // The player objects represent one of the three player options
        public IPlayer _Player2;
        public bool isPlayer1Turn;
        public IProgress<int> _progress;
        public CancellationToken _cancelToken;

        public TicTacToeGame(IPlayer player1, IPlayer player2, IProgress<int> progress, CancellationToken cancelToken) {

            _Player1 = player1;
            _Player2 = player2;
            _GameBoard = new char[3, 3] {{ ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' }};
            isPlayer1Turn = true;
            _progress = progress;
            _cancelToken = cancelToken;
        }

        public void Run() {

            while (true)
            {
                ///////////Player 1 moves/////////////
                if (_Player1.GetType().Name == "HumanPlayer")
                {
                    while (isPlayer1Turn) {
                        //If the game is cancelled then end the task
                        if (_cancelToken.IsCancellationRequested)
                            return;  
                    }
                    UpdateGUI();
                }
                else if (_Player1.GetType().Name == "FullTreePlayer" || _Player1.GetType().Name == "DepthSearchPlayer")
                {
                    //Bot makes decision
                    if (_cancelToken.IsCancellationRequested)
                        return;
                    _GameBoard = _Player1.Decision(_GameBoard);
                    //If the game is cancelled then end the task
                    isPlayer1Turn = !isPlayer1Turn;
                    if (_cancelToken.IsCancellationRequested)
                        return;
                    UpdateGUI();
                }

                //////////Player 2 moves////////////
                if (_Player2.GetType().Name == "HumanPlayer")
                {
                    while (!isPlayer1Turn) {
                        //If the game is cancelled then end the task
                        if (_cancelToken.IsCancellationRequested)
                            return;
                    }
                    UpdateGUI();
                }
                else if (_Player2.GetType().Name == "FullTreePlayer" || _Player2.GetType().Name == "DepthSearchPlayer")
                {
                    //Bot makes decision
                    if (_cancelToken.IsCancellationRequested)
                        return;
                    _GameBoard = _Player2.Decision(_GameBoard);
                    isPlayer1Turn = !isPlayer1Turn;
                    //If the game is cancelled then end the task
                    if (_cancelToken.IsCancellationRequested)
                        return;
                    UpdateGUI();
                }
            }
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
        private void UpdateGUI() {
            //Check the game state
            int state = IsGameFinished();
            //Update the GUI
            _progress.Report(state);
            if (state != 0)
            {
                //terminate task
                while (!_cancelToken.IsCancellationRequested) ;
                return;
            }
        }
    }
}
