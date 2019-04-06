using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Position
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
