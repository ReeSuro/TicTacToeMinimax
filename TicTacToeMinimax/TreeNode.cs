using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    class FullTreeNode
    {
        public int Score;
        public char[,] GameBoard;
        public List<FullTreeNode> ChildNodes;
        public bool isPlayer1Turn;
        public bool player1Tree;

        public FullTreeNode(char[,] gameBoard, bool isP1, bool p1tree)
        {
            Score = 0;
            GameBoard = gameBoard;
            ChildNodes = new List<FullTreeNode>();
            isPlayer1Turn = isP1;
            player1Tree = p1tree;
            ConstructLevel(isPlayer1Turn);       
        }

        public void ConstructLevel(bool isPlayer1Turn) {

            //Check if the current gameboard has won
            if (BoardResult() != -1)
                return;

            //if not then add another layer 
            Stack<int> rowStack = new Stack<int>();//holds the empty row indices
            Stack<int> colStack = new Stack<int>();//holds the empty column indices

            //1. Loops through the gameboard and determine which slots are empty
            for (int row = 0; row < 3; row++) {
                for (int col = 0; col < 3; col++) {

                    if (GameBoard[row, col] == ' ') {
                        rowStack.Push(row);
                        colStack.Push(col);
                    }
                }
            }

            //If the gameboard is empty then return else create a new Tree Node and add it to the list.
            if (rowStack.Count == 0)
            {
                return;
            }
            else 
            {
                int newRowIndex;
                int newColIndex;
                FullTreeNode newNode;
                int loopIndex = rowStack.Count;
                for (int i = 0; i < loopIndex; i++) {
                    char[,] newBoard = new char[3, 3];
                    newRowIndex = rowStack.Pop();
                    newColIndex = colStack.Pop();
                    //Copy board 
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            newBoard[row,col] = GameBoard[row,col];
                        }
                    }
                        if (isPlayer1Turn)
                            newBoard[newRowIndex, newColIndex] = 'X'; 
                        else
                            newBoard[newRowIndex, newColIndex] = 'O';

                    newNode = new FullTreeNode(newBoard, !isPlayer1Turn, player1Tree);
                    ChildNodes.Add(newNode);
                }
            }
        }

        public void Minimax(bool isMaximising) {

            //If there are no child nodes (The game is finished), return the result of the gameboard
            if (ChildNodes.Count == 0) {
                Score = BoardResult();
                return;
            }

            //Call minimax on children
            foreach (FullTreeNode child in ChildNodes) {
                child.Minimax(!isMaximising);
            }

            int scoreValue = 0;
            //Read the scores of the schild nodes and select min or max depending on isMaximising variable. 
            for (int i = 0; i < ChildNodes.Count; i++)
            {
                if (i == 0)
                {
                    scoreValue = ChildNodes[i].Score;
                }
                else
                {
                    if (isMaximising)
                    {
                        if (ChildNodes[i].Score > scoreValue)
                        {
                            scoreValue = ChildNodes[i].Score;
                        }
                    }
                    else 
                    {
                        if (ChildNodes[i].Score < scoreValue)
                        {
                            scoreValue = ChildNodes[i].Score;
                        }
                    }
                }
            }
            //set the nodes score and return
            Score = scoreValue;
            return;
    }

        public int BoardResult() {

            //Check if player 1 has won
            bool oneWon = false;

            //check rows and columns
            for (int ind = 0; ind < 3; ind++)
            {

                if (GameBoard[ind, 0] == 'X' && GameBoard[ind, 1] == 'X' && GameBoard[ind, 2] == 'X')
                {
                    oneWon = true;
                }
                else if (GameBoard[0, ind] == 'X' && GameBoard[1, ind] == 'X' && GameBoard[2, ind] == 'X')
                {
                    oneWon = true;
                }
            }
            //Check diagonals
            if (GameBoard[0, 0] == 'X' && GameBoard[1, 1] == 'X' && GameBoard[2, 2] == 'X')
            {
                oneWon = true;
            }
            else if (GameBoard[0, 2] == 'X' && GameBoard[1, 1] == 'X' && GameBoard[2, 0] == 'X')
            {
                oneWon = true;
            }

            //return if true
            if (oneWon)
            {
                if (player1Tree)
                    return 10;
                else
                    return -10;
            }
            //Check if player 2 has won
            bool twoWon = false;

            //check rows and columns
            for (int ind = 0; ind < 3; ind++)
            {

                if (GameBoard[ind, 0] == 'O' && GameBoard[ind, 1] == 'O' && GameBoard[ind, 2] == 'O')
                {
                    twoWon = true;
                }
                else if (GameBoard[0, ind] == 'O' && GameBoard[1, ind] == 'O' && GameBoard[2, ind] == 'O')
                {
                    twoWon = true;
                }
            }
            //Check diagonals
            if (GameBoard[0, 0] == 'O' && GameBoard[1, 1] == 'O' && GameBoard[2, 2] == 'O')
            {
                twoWon = true;
            }
            else if (GameBoard[0, 2] == 'O' && GameBoard[1, 1] == 'O' && GameBoard[2, 0] == 'O')
            {
                twoWon = true;
            }

            //return if true
            if (twoWon)
            {
                if (player1Tree)
                    return -10;
                else
                    return 10;
            }
            //Check for draw - if all spots are full
            int spaceCount = 0;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (GameBoard[row, col] == ' ')
                        spaceCount++;
                }

            }
            if (spaceCount == 0)
                return 0;

            return -1;
        }
      


}


}


