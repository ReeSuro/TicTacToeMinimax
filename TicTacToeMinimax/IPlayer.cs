using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMinimax
{
    interface IPlayer
    {
       char[,] Decision(char[,] gameBoard);
    }
}
