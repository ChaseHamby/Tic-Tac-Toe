using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class WinChecker
    {
        public State Check(Board board)
        {
            if (CheckForWin(board, State.X)) return State.X;
            if (CheckForWin(board, State.O)) return State.O;
            return State.Undecided;
        }

        private bool CheckForWin(Board board, State player)
        {
            for (int row = 0; row < 3; row++)
                if (AreAll(board, new Position[]
                {
                    new Position(row, 0),
                    new Position(row, 1),
                    new Position(row, 2) }, player))
                    return true;

            for (int column = 0; column < 3; column++)
                if (AreAll(board, new Position[]
                {
                    new Position(0, column),
                    new Position(1, column),
                    new Position(2, column) }, player))
                    return true;

            if (AreAll(board, new Position[]
            {
                new Position(0, 0),
                new Position(1, 1),
                new Position(2, 2) }, player))
                return true;
        }
    }
}
