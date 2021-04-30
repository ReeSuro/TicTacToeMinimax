using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    class DepthLimitedTreeNode
    {
        public int Score;
        public char[,] GameBoard;
        public List<DepthLimitedTreeNode> ChildNodes;
        public bool isPlayer1Turn;
        public bool player1Tree;
        public int maxTreeDepth;
        public int currentDepth;

        public DepthLimitedTreeNode(char[,] gameBoard, bool isP1, bool p1tree, int maxTreeDepth, int currentDepth)
        {
            Score = 0;
            GameBoard = gameBoard;
            ChildNodes = new List<DepthLimitedTreeNode>();
            isPlayer1Turn = isP1;
            player1Tree = p1tree;
            this.maxTreeDepth = maxTreeDepth;
            this.currentDepth = currentDepth;
            ConstructLevel(isPlayer1Turn);
        }

        public void ConstructLevel(bool isPlayer1Turn)
        {

            //Check if it is a terminal state
            if (BoardResult() != -1)
                return;

            //Check if the required depth has been reached
            if (currentDepth >= maxTreeDepth)
                return;

            //if not then add another layer 
            Stack<int> rowStack = new Stack<int>();//holds the empty row indices
            Stack<int> colStack = new Stack<int>();//holds the empty column indices

            //1. Loops through the gameboard and determine which slots are empty
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {

                    if (GameBoard[row, col] == ' ')
                    {
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
                DepthLimitedTreeNode newNode;
                int loopIndex = rowStack.Count;
                for (int i = 0; i < loopIndex; i++)
                {
                    char[,] newBoard = new char[3, 3];
                    newRowIndex = rowStack.Pop();
                    newColIndex = colStack.Pop();
                    //Copy board 
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            newBoard[row, col] = GameBoard[row, col];
                        }
                    }
                    if (isPlayer1Turn)
                        newBoard[newRowIndex, newColIndex] = 'X';
                    else
                        newBoard[newRowIndex, newColIndex] = 'O';

                    newNode = new DepthLimitedTreeNode(newBoard, !isPlayer1Turn, player1Tree, maxTreeDepth, currentDepth+1);
                    ChildNodes.Add(newNode);
                }
            }
        }

        public void Minimax(bool isMaximising)
        {

            //If there are no child nodes (The game is finished), return the result of the gameboard
            if (ChildNodes.Count == 0)
            {
                Score = TerminalResult();
                return;
            }

            //Call minimax on children
            foreach (DepthLimitedTreeNode child in ChildNodes)
            {
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
        public int TerminalResult()
        {

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
            else {
                //Calculate board score using the evaluation function 
                return EvaluationFunction();
            }
        }


        private int EvaluationFunction() {

            int X2 = 0;
            int X1 = 0;
            int O2 = 0;
            int O1 = 0;

            //Count how many rows have one or two X 
            int xCount;
            int oCount; 
            for (int row = 0; row < 3; row++) {
                xCount = 0;
                oCount = 0;
                if (GameBoard[row, 0] == 'X')
                    xCount++;
                else if (GameBoard[row, 0] == 'O')
                    oCount++;

                if (GameBoard[row, 1] == 'X')
                    xCount++;
                else if (GameBoard[row, 1] == 'O')
                    oCount++;

                if (GameBoard[row, 2] == 'X')
                    xCount++;
                else if (GameBoard[row, 2] == 'O')
                    oCount++;
                //Evaluate rows
                if (xCount == 2 && oCount == 0)
                    X2++;
                else if (xCount == 1 && oCount == 0)
                    X1++;
                else if (xCount == 0 && oCount == 2)
                    O2++;
                else if (xCount == 0 && oCount == 1)
                    O1++;
            }

            //count how many columns have one or two X or Os
            for (int col = 0; col < 3; col++)
            {
                xCount = 0;
                oCount = 0;
                if (GameBoard[0, col] == 'X')
                    xCount++;
                else if (GameBoard[0, col] == 'O')
                    oCount++;

                if (GameBoard[1, col] == 'X')
                    xCount++;
                else if (GameBoard[1, col] == 'O')
                    oCount++;

                if (GameBoard[2, col] == 'X')
                    xCount++;
                else if (GameBoard[2, col] == 'O')
                    oCount++;
                //Evaluate rows
                if (xCount == 2 && oCount == 0)
                    X2++;
                else if (xCount == 1 && oCount == 0)
                    X1++;
                else if (xCount == 0 && oCount == 2)
                    O2++;
                else if (xCount == 0 && oCount == 1)
                    O1++;
            }

            //count how many diagonals have X and Os
            xCount = 0;
            oCount = 0;

            if (GameBoard[0, 0] == 'X')
                xCount++;
            else if (GameBoard[0, 0] == 'O')
                oCount++;

            if (GameBoard[1, 1] == 'X')
                xCount++;
            else if (GameBoard[1, 1] == 'O')
                oCount++;

            if (GameBoard[2, 2] == 'X')
                xCount++;
            else if (GameBoard[2, 2] == 'O')
                oCount++;

            if (xCount == 2 && oCount == 0)
                X2++;
            else if (xCount == 1 && oCount == 0)
                X1++;
            else if (xCount == 0 && oCount == 2)
                O2++;
            else if (xCount == 0 && oCount == 1)
                O1++;

            xCount = 0;
            oCount = 0;

            if (GameBoard[0, 2] == 'X')
                xCount++;
            else if (GameBoard[0, 2] == 'O')
                oCount++;

            if (GameBoard[1, 1] == 'X')
                xCount++;
            else if (GameBoard[1, 1] == 'O')
                oCount++;

            if (GameBoard[2, 0] == 'X')
                xCount++;
            else if (GameBoard[2, 0] == 'O')
                oCount++;

            if (xCount == 2 && oCount == 0)
                X2++;
            else if (xCount == 1 && oCount == 0)
                X1++;
            else if (xCount == 0 && oCount == 2)
                O2++;
            else if (xCount == 0 && oCount == 1)
                O1++;

            //Return the evaluated score 
            return ((3 * X2 + X1) - (3 * O2 + O1));
        }
    }
}
