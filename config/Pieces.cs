using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
   abstract class Pieces
    {
       public int X_Postion;
       public int Y_Postion;
       public char Piece_Color;
       public Pieces(int X_Postion, int Y_Postion, char Piece_Color)
       {
           this.X_Postion = X_Postion;
           this.Y_Postion = Y_Postion;
           this.Piece_Color = Piece_Color;
       }
    //  public abstract void move(Pieces p, int x, int y);
     // public abstract void Available_Moves();
    }
    class Rook :Pieces
    {
        public Rook(int X_Postion, int Y_Postion, char Piece_Color):base( X_Postion, Y_Postion,  Piece_Color)
        {

        }

    }
    class Knight : Pieces
    {
        public Knight(int X_Postion, int Y_Postion, char Piece_Color):base(X_Postion, Y_Postion, Piece_Color)
        {

        }

    }
    class Bishop : Pieces
    {
        public Bishop(int X_Postion, int Y_Postion, char Piece_Color):base(X_Postion, Y_Postion, Piece_Color)
        {

        }

    }
    class Pawn : Pieces
    {
        public Pawn(int X_Postion, int Y_Postion, char Piece_Color)
            : base(X_Postion, Y_Postion, Piece_Color)
        {

        }

    }
    class King : Pieces
    {
        public King(int X_Postion, int Y_Postion, char Piece_Color)
            : base(X_Postion, Y_Postion, Piece_Color)
        {

        }

    }
    class Queen : Pieces
    {
        public Queen(int X_Postion, int Y_Postion, char Piece_Color)
            : base(X_Postion, Y_Postion, Piece_Color)
        {

        }

    }
}
