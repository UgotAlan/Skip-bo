using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skipbo
{
    public partial class MultiPlayer : Form
    {
        public MultiPlayer()
        {
            InitializeComponent();
            numPlayers.SelectedIndex = 0;
            difficultyLevel.SelectedIndex = 1;
            stockPile.SelectedIndex = 0;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            // check for valid input from the various drop down menues
            this.Hide();
            this.Close();

            GameBoard gameboard = new GameBoard();
            gameboard.ShowDialog();
        }
    }
}
