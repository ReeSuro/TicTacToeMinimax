using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    class FullTreePlayer : IPlayer
    {
        public bool isFirstPlayer;
        public FullTreeNode topNode;

        public FullTreePlayer(bool isfirst) {

            isFirstPlayer = isfirst;
        }

        public void CreateTree(bool isFirstPlayer, char[,] currentBoard) {

            topNode = new FullTreeNode(currentBoard, isFirstPlayer, isFirstPlayer);
        } 

        public char[,] Decision(char[,] gameBoard) {

            //Create the tree structure 
            CreateTree(isFirstPlayer, gameBoard);

            //Call minimax on the top node
            topNode.Minimax(true);

            //Read child nodes' scores and select the maximum to play
            int maxScoreIndex = -1;
            int maxScore = -100;
            List<int> selectionNodes = new List<int>(topNode.ChildNodes.Count);
             for(int i = 0; i < topNode.ChildNodes.Count; i++){
                if (topNode.ChildNodes[i].Score > maxScore)
                {
                    selectionNodes.Clear();
                    selectionNodes.Add(i);
                    maxScore = topNode.ChildNodes[i].Score;
                }
                else if (topNode.ChildNodes[i].Score == maxScore) {
                    //To give variation, there is a random chance a different child with the same value will be chosen
                    selectionNodes.Add(i);
                }
             }
            //Pick random element from the list 
            Random random = new Random();
            maxScoreIndex = selectionNodes.ElementAt<int>(random.Next(selectionNodes.Count));

            //Return the board to be played.
            char[,] returnValue = topNode.ChildNodes.ElementAt<FullTreeNode>(maxScoreIndex).GameBoard;
            //Destroy tree
            topNode = null;
            return returnValue;
        }
    }
}
