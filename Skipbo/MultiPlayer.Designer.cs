namespace Skipbo
{
    partial class MultiPlayer
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numPlayers = new System.Windows.Forms.ComboBox();
            this.difficultyLevel = new System.Windows.Forms.ComboBox();
            this.stockPile = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(74, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(373, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Single Player Game Option";
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel.Location = new System.Drawing.Point(50, 64);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(435, 17);
            this.explanationLabel.TabIndex = 1;
            this.explanationLabel.Text = "In this version of the game you will be playing against AI oponent(s).";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "# of Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Pile Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Difficulty:";
            // 
            // numPlayers
            // 
            this.numPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlayers.FormattingEnabled = true;
            this.numPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.numPlayers.Location = new System.Drawing.Point(253, 101);
            this.numPlayers.Name = "numPlayers";
            this.numPlayers.Size = new System.Drawing.Size(40, 28);
            this.numPlayers.TabIndex = 5;
            // 
            // difficultyLevel
            // 
            this.difficultyLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difficultyLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLevel.FormattingEnabled = true;
            this.difficultyLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.difficultyLevel.Location = new System.Drawing.Point(253, 205);
            this.difficultyLevel.Name = "difficultyLevel";
            this.difficultyLevel.Size = new System.Drawing.Size(86, 28);
            this.difficultyLevel.TabIndex = 6;
            // 
            // stockPile
            // 
            this.stockPile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockPile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stockPile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockPile.FormattingEnabled = true;
            this.stockPile.Items.AddRange(new object[] {
            "Standard",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.stockPile.Location = new System.Drawing.Point(253, 154);
            this.stockPile.Name = "stockPile";
            this.stockPile.Size = new System.Drawing.Size(95, 28);
            this.stockPile.TabIndex = 7;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(74, 275);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(77, 36);
            this.start.TabIndex = 8;
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(356, 275);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(91, 36);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // MultiPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.close);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stockPile);
            this.Controls.Add(this.difficultyLevel);
            this.Controls.Add(this.numPlayers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MultiPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Single Player Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox numPlayers;
        private System.Windows.Forms.ComboBox difficultyLevel;
        private System.Windows.Forms.ComboBox stockPile;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label close;
    }
}