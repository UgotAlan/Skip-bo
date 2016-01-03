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
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Gray;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void stock_MouseDown(object sender, MouseEventArgs e)
        {
            stock.DoDragDrop(stock.BackgroundImage, DragDropEffects.Copy);
        }

        private void play_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void play1_DragDrop(object sender, DragEventArgs e)
        {
            play1.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            play1.AllowDrop = true;
            play2.AllowDrop = true;
            play3.AllowDrop = true;
            play4.AllowDrop = true;
            discard1.AllowDrop = true;
            discard2.AllowDrop = true;
            discard3.AllowDrop = true;
            discard4.AllowDrop = true;
        }

        private void hand1_MouseDown(object sender, MouseEventArgs e)
        {
            hand1.DoDragDrop(hand1.BackgroundImage, DragDropEffects.Copy);
        }

        private void hand2_MouseDown(object sender, MouseEventArgs e)
        {
            hand2.DoDragDrop(hand2.BackgroundImage, DragDropEffects.Copy);
        }

        private void hand3_MouseDown(object sender, MouseEventArgs e)
        {
            hand3.DoDragDrop(hand3.BackgroundImage, DragDropEffects.Copy);
        }

        private void hand4_MouseDown(object sender, MouseEventArgs e)
        {
            hand4.DoDragDrop(hand4.BackgroundImage, DragDropEffects.Copy);
        }

        private void hand5_MouseDown(object sender, MouseEventArgs e)
        {
            hand5.DoDragDrop(hand5.BackgroundImage, DragDropEffects.Copy);
        }

        private void discard1_MouseDown(object sender, MouseEventArgs e)
        {
            if(discard1.BackgroundImage != null)
            {
                discard1.DoDragDrop(discard1.BackgroundImage, DragDropEffects.Copy);
            }
            
        }

        private void discard2_MouseDown(object sender, MouseEventArgs e)
        {
            if (discard2.BackgroundImage != null)
            {
                discard2.DoDragDrop(discard2.BackgroundImage, DragDropEffects.Copy);
            }
        }

        private void discard3_MouseDown(object sender, MouseEventArgs e)
        {
            if (discard3.BackgroundImage != null)
            {
                discard3.DoDragDrop(discard3.BackgroundImage, DragDropEffects.Copy);
            }
        }

        private void discard4_MouseDown(object sender, MouseEventArgs e)
        {
            if (discard4.BackgroundImage != null)
            {
                discard4.DoDragDrop(discard4.BackgroundImage, DragDropEffects.Copy);
            }
        }

        private void play2_DragDrop(object sender, DragEventArgs e)
        {
            play2.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void play3_DragDrop(object sender, DragEventArgs e)
        {
            play3.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void play4_DragDrop(object sender, DragEventArgs e)
        {
            play4.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void discard_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void discard1_DragDrop(object sender, DragEventArgs e)
        {
            discard1.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void discard2_DragDrop(object sender, DragEventArgs e)
        {
            discard2.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void discard3_DragDrop(object sender, DragEventArgs e)
        {
            discard3.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void discard4_DragDrop(object sender, DragEventArgs e)
        {
            discard4.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
    }
}
