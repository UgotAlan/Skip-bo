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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void singlePlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinglePlayer singlePlayer = new SinglePlayer();
            singlePlayer.ShowDialog();
            this.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void multiPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiPlayer multiPlayer = new MultiPlayer();
            multiPlayer.ShowDialog();
            this.Show();
        }
    }
}
