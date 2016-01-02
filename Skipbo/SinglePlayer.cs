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
    public partial class SinglePlayer : Form
    {
        public SinglePlayer()
        {
            InitializeComponent();
            numPlayers.SelectedIndex = 0;
            difficultyLevel.SelectedIndex = 1;
        }
    }
}
