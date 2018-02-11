using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{     
    public partial class Chess_Game : Form
    {

        UC[,] b;
        Board board=new Board();
        public Chess_Game()
        {
            InitializeComponent();
            
        }
        public void Update_Board()
        {
            int i, j;
            for (i = 0; i < 8; i++)
                for (j = 0; j < 8; j++)
                { 
                    if(board.ChessBoard[i,j] is Rook&&board.ChessBoard[i,j].Piece_Color=='B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/RB.jpg"); 
                    else if(board.ChessBoard[i,j] is Knight&&board.ChessBoard[i,j].Piece_Color=='B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KB.jpg"); 
                    else if(board.ChessBoard[i,j] is Bishop&&board.ChessBoard[i,j].Piece_Color=='B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/BB.jpg"); 
                     else if(board.ChessBoard[i,j] is Queen&&board.ChessBoard[i,j].Piece_Color=='B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/QB.jpg"); 
                     else if(board.ChessBoard[i,j] is King&&board.ChessBoard[i,j].Piece_Color=='B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KGB.jpg"); 
                     else if(board.ChessBoard[i,j] is Pawn&&board.ChessBoard[i,j].Piece_Color=='B')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/PB.jpg"); 
                    else if(board.ChessBoard[i,j] is Rook&&board.ChessBoard[i,j].Piece_Color=='W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/RW.jpg"); 
                    else if(board.ChessBoard[i,j] is Knight&&board.ChessBoard[i,j].Piece_Color=='W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KW.jpg"); 
                    else if(board.ChessBoard[i,j] is Bishop&&board.ChessBoard[i,j].Piece_Color=='W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/BW.jpg"); 
                     else if(board.ChessBoard[i,j] is Queen&&board.ChessBoard[i,j].Piece_Color=='W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/QW.jpg"); 
                     else if(board.ChessBoard[i,j] is King&&board.ChessBoard[i,j].Piece_Color=='W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/KGW.jpg"); 
                     else if(board.ChessBoard[i,j] is Pawn&&board.ChessBoard[i,j].Piece_Color=='W')
                        b[i, j].BackgroundImage = System.Drawing.Image.FromFile("pic/PW.jpg"); 
                    
                         
                        
                       
                }
           
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                {
                   
                        if (i % 2 == 0)
                            if (j % 2 == 1)
                                b[i, j].BackColor = Color.Black;
                            else
                                b[i, j].BackColor = Color.White;
                        else
                            if (j % 2 == 1)
                                b[i, j].BackColor = Color.White;
                            else
                                b[i, j].BackColor = Color.Black;
                   
                }
               
            }
        }
       
        private void Chess_Game_Load(object sender, EventArgs e)
        {
            b = new UC[8, 8];
            board = new Board();
            int x = 250, y = -75;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    b[i, j] = new UC();
                    b[i, j].Parent = this;
                    b[i, j].Location = new Point(x+(j * 85+85) ,y+( i *85+85) );
                    b[i, j].X = j;
                    b[i, j].Y = i;
                    b[i, j].Size = new Size(85,90);
                    b[i, j].Click += new EventHandler(UC_Click);
                    if (i % 2 == 0)
                        if (j % 2 == 1)
                            b[i, j].BackColor = Color.Black;
                        else
                            b[i, j].BackColor = Color.White;
                    else
                        if (j % 2 == 1)
                            b[i, j].BackColor = Color.White;
                        else
                            b[i, j].BackColor = Color.Black;
                    b[i, j].BackgroundImageLayout = ImageLayout.Center;
                    
                }
                
            }
            Update_Board();
        }

        void UC_Click(object sender, EventArgs e)
        {
            int i, j;
            i = (sender as UC).Y;
            j = (sender as UC).X;
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
