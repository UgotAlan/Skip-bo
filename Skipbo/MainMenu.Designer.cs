﻿namespace Skipbo
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.singlePlayer = new System.Windows.Forms.Label();
            this.multiPlayer = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // singlePlayer
            // 
            this.singlePlayer.AutoSize = true;
            this.singlePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singlePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayer.Location = new System.Drawing.Point(192, 144);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(191, 36);
            this.singlePlayer.TabIndex = 1;
            this.singlePlayer.Text = "Single Player";
            this.singlePlayer.Click += new System.EventHandler(this.singlePlayer_Click);
            // 
            // multiPlayer
            // 
            this.multiPlayer.AutoSize = true;
            this.multiPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiPlayer.Location = new System.Drawing.Point(203, 201);
            this.multiPlayer.Name = "multiPlayer";
            this.multiPlayer.Size = new System.Drawing.Size(171, 36);
            this.multiPlayer.TabIndex = 2;
            this.multiPlayer.Text = "Multi Player";
            this.multiPlayer.Click += new System.EventHandler(this.multiPlayer_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(236, 256);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(91, 36);
            this.close.TabIndex = 10;
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.close);
            this.Controls.Add(this.multiPlayer);
            this.Controls.Add(this.singlePlayer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(615, 450);
            this.MinimumSize = new System.Drawing.Size(615, 450);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skip-Bo Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label singlePlayer;
        private System.Windows.Forms.Label multiPlayer;
        private System.Windows.Forms.Label close;
    }
}

