using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_Tac_Toe
{
    class ChessBoard
    {
        private char[,] board = new char[3, 3];
        public char[,] Board
        {
            get
            {
                return board;
            }
            set
            {
                board = value;
            }
        }
        public ChessBoard()
        {
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    board[i, j] = '?';
                }
            }
        }

        public string WriteBoard()
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j != 2)
                        result += board[i, j] + " ";
                    else
                        result += board[i, j];
                }
                result += "\n";
            }
            return result;
        }

    }
}
