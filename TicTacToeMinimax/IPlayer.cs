using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    abstract class IPlayer
    {
        public double maxExecutionTime;
        public double averageExecutionTime;
        abstract public char[,] Decision(char[,] gameBoard);
    }
}
