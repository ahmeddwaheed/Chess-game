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
    public partial class chess : Form
    {
        public chess()
        {
            InitializeComponent();
        }
       

       

        private void chess_Load(object sender, EventArgs e)
        {

        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            this.Hide();
           Chess_Game c = new Chess_Game();
            c.ShowDialog();
            this.Close();
        }

       
    }
}
