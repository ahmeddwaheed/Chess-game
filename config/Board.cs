using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Board
    {
        public Pieces[,] ChessBoard = new Pieces[8, 8];
        public Board()
        { 
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                    ChessBoard[0, i] = new Rook(0, i, 'W');
                else if (i == 1)
                    ChessBoard[0, i] = new Knight(0, i, 'W');
                else if (i == 2)
                    ChessBoard[0, i] = new Bishop(0, i, 'W');
                else if (i == 3)
                    ChessBoard[0, i] = new King(0, i, 'W');
                else if (i == 4)
                    ChessBoard[0, i] = new Queen(0, i, 'W');
                else if (i == 5)
                    ChessBoard[0, i] = new Bishop(0, i, 'W');
                else if (i == 6)
                    ChessBoard[0, i] = new Knight(0, i, 'W');
                else if (i == 7)
                    ChessBoard[0, i] = new Rook(0, i, 'W');

            }
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                    ChessBoard[7, i] = new Rook(7, i, 'B');
                else if (i == 1)
                    ChessBoard[7, i] = new Knight(7, i, 'B');
                else if (i == 2)
                    ChessBoard[7, i] = new Bishop(7, i, 'B');
                else if (i == 3)
                    ChessBoard[7, i] = new King(7, i, 'B');
                else if (i == 4)
                    ChessBoard[7, i] = new Queen(7, i, 'B');
                else if (i == 5)
                    ChessBoard[7, i] = new Bishop(7, i, 'B');
                else if (i == 6)
                    ChessBoard[7, i] = new Knight(7, i, 'B');
                else if (i == 7)
                    ChessBoard[7, i] = new Rook(7, i, 'B');


            }
            for (int i = 0; i < 8; i++)
            {
                ChessBoard[1, i] = new Pawn(1, i, 'W');
            }
            for (int i = 0; i < 8; i++)
            {
                ChessBoard[6, i] = new Pawn(1, i, 'B');
            }
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                    ChessBoard[i, j] = null;
            }

        }
    }
}