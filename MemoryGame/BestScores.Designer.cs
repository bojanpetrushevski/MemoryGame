namespace MemoryGame
{
    partial class BestScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestScores));
            this.lbBestScoresTitle = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbGameCateogry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBestScoresTitle
            // 
            this.lbBestScoresTitle.AutoSize = true;
            this.lbBestScoresTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbBestScoresTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbBestScoresTitle.ForeColor = System.Drawing.Color.White;
            this.lbBestScoresTitle.Location = new System.Drawing.Point(330, 28);
            this.lbBestScoresTitle.Name = "lbBestScoresTitle";
            this.lbBestScoresTitle.Size = new System.Drawing.Size(286, 58);
            this.lbBestScoresTitle.TabIndex = 0;
            this.lbBestScoresTitle.Text = "Best scores";
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.BackColor = System.Drawing.Color.Transparent;
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbRank.ForeColor = System.Drawing.Color.White;
            this.lbRank.Location = new System.Drawing.Point(85, 171);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(91, 37);
            this.lbRank.TabIndex = 1;
            this.lbRank.Text = "Rank";
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbPlayerName.ForeColor = System.Drawing.Color.White;
            this.lbPlayerName.Location = new System.Drawing.Point(272, 171);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(201, 37);
            this.lbPlayerName.TabIndex = 2;
            this.lbPlayerName.Text = "Player Name";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(580, 171);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(84, 37);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(750, 171);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(88, 37);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbGameCateogry
            // 
            this.lbGameCateogry.AutoSize = true;
            this.lbGameCateogry.BackColor = System.Drawing.Color.Transparent;
            this.lbGameCateogry.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbGameCateogry.ForeColor = System.Drawing.Color.White;
            this.lbGameCateogry.Location = new System.Drawing.Point(284, 86);
            this.lbGameCateogry.Name = "lbGameCateogry";
            this.lbGameCateogry.Size = new System.Drawing.Size(368, 58);
            this.lbGameCateogry.TabIndex = 6;
            this.lbGameCateogry.Text = "Game cateogry";
            // 
            // BestScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.ClientSize = new System.Drawing.Size(943, 640);
            this.Controls.Add(this.lbGameCateogry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbPlayerName);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.lbBestScoresTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BestScores";
            this.Text = "BestScores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBestScoresTitle;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbGameCateogry;
    }
}