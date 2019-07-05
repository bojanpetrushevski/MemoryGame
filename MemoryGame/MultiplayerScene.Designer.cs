namespace MemoryGame
{
    partial class MultiplayerScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiplayerScene));
            this.pbBackArrow = new System.Windows.Forms.PictureBox();
            this.lbMultiplayerModeTitle = new System.Windows.Forms.Label();
            this.pnPlayer1 = new System.Windows.Forms.Panel();
            this.lbPlayer1Name = new System.Windows.Forms.Label();
            this.lbPlayer1Pairs = new System.Windows.Forms.Label();
            this.pbPlayer1Pairs = new System.Windows.Forms.PictureBox();
            this.pnPlayer2 = new System.Windows.Forms.Panel();
            this.lbPlayer2Name = new System.Windows.Forms.Label();
            this.lbPlayer2Pairs = new System.Windows.Forms.Label();
            this.pbPlayer2Pairs = new System.Windows.Forms.PictureBox();
            this.pbFinger = new System.Windows.Forms.PictureBox();
            this.lbOnTurn = new System.Windows.Forms.Label();
            this.pnGameStats = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).BeginInit();
            this.pnPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Pairs)).BeginInit();
            this.pnPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Pairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinger)).BeginInit();
            this.pnGameStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBackArrow
            // 
            this.pbBackArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbBackArrow.Image")));
            this.pbBackArrow.Location = new System.Drawing.Point(40, 26);
            this.pbBackArrow.Name = "pbBackArrow";
            this.pbBackArrow.Size = new System.Drawing.Size(42, 41);
            this.pbBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackArrow.TabIndex = 5;
            this.pbBackArrow.TabStop = false;
            this.pbBackArrow.Click += new System.EventHandler(this.pbBackArrow_Click);
            this.pbBackArrow.MouseEnter += new System.EventHandler(this.pbBackArrow_MouseEnter);
            this.pbBackArrow.MouseLeave += new System.EventHandler(this.pbBackArrow_MouseLeave);
            // 
            // lbMultiplayerModeTitle
            // 
            this.lbMultiplayerModeTitle.AutoSize = true;
            this.lbMultiplayerModeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbMultiplayerModeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbMultiplayerModeTitle.ForeColor = System.Drawing.Color.White;
            this.lbMultiplayerModeTitle.Location = new System.Drawing.Point(239, 26);
            this.lbMultiplayerModeTitle.Name = "lbMultiplayerModeTitle";
            this.lbMultiplayerModeTitle.Size = new System.Drawing.Size(407, 58);
            this.lbMultiplayerModeTitle.TabIndex = 6;
            this.lbMultiplayerModeTitle.Text = "Multiplayer mode";
            // 
            // pnPlayer1
            // 
            this.pnPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pnPlayer1.Controls.Add(this.lbPlayer1Name);
            this.pnPlayer1.Controls.Add(this.lbPlayer1Pairs);
            this.pnPlayer1.Controls.Add(this.pbPlayer1Pairs);
            this.pnPlayer1.Location = new System.Drawing.Point(3, 3);
            this.pnPlayer1.Name = "pnPlayer1";
            this.pnPlayer1.Size = new System.Drawing.Size(294, 185);
            this.pnPlayer1.TabIndex = 7;
            // 
            // lbPlayer1Name
            // 
            this.lbPlayer1Name.AutoSize = true;
            this.lbPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.lbPlayer1Name.Location = new System.Drawing.Point(40, 19);
            this.lbPlayer1Name.Name = "lbPlayer1Name";
            this.lbPlayer1Name.Size = new System.Drawing.Size(126, 46);
            this.lbPlayer1Name.TabIndex = 5;
            this.lbPlayer1Name.Text = "Name";
            // 
            // lbPlayer1Pairs
            // 
            this.lbPlayer1Pairs.AutoSize = true;
            this.lbPlayer1Pairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbPlayer1Pairs.ForeColor = System.Drawing.Color.White;
            this.lbPlayer1Pairs.Location = new System.Drawing.Point(186, 115);
            this.lbPlayer1Pairs.Name = "lbPlayer1Pairs";
            this.lbPlayer1Pairs.Size = new System.Drawing.Size(42, 46);
            this.lbPlayer1Pairs.TabIndex = 2;
            this.lbPlayer1Pairs.Text = "2";
            // 
            // pbPlayer1Pairs
            // 
            this.pbPlayer1Pairs.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer1Pairs.Image = global::MemoryGame.Properties.Resources._checked;
            this.pbPlayer1Pairs.Location = new System.Drawing.Point(48, 87);
            this.pbPlayer1Pairs.Name = "pbPlayer1Pairs";
            this.pbPlayer1Pairs.Size = new System.Drawing.Size(85, 95);
            this.pbPlayer1Pairs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPlayer1Pairs.TabIndex = 4;
            this.pbPlayer1Pairs.TabStop = false;
            // 
            // pnPlayer2
            // 
            this.pnPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pnPlayer2.Controls.Add(this.lbPlayer2Name);
            this.pnPlayer2.Controls.Add(this.lbPlayer2Pairs);
            this.pnPlayer2.Controls.Add(this.pbPlayer2Pairs);
            this.pnPlayer2.Location = new System.Drawing.Point(559, 3);
            this.pnPlayer2.Name = "pnPlayer2";
            this.pnPlayer2.Size = new System.Drawing.Size(294, 185);
            this.pnPlayer2.TabIndex = 8;
            // 
            // lbPlayer2Name
            // 
            this.lbPlayer2Name.AutoSize = true;
            this.lbPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.lbPlayer2Name.Location = new System.Drawing.Point(91, 19);
            this.lbPlayer2Name.Name = "lbPlayer2Name";
            this.lbPlayer2Name.Size = new System.Drawing.Size(126, 46);
            this.lbPlayer2Name.TabIndex = 5;
            this.lbPlayer2Name.Text = "Name";
            // 
            // lbPlayer2Pairs
            // 
            this.lbPlayer2Pairs.AutoSize = true;
            this.lbPlayer2Pairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbPlayer2Pairs.ForeColor = System.Drawing.Color.White;
            this.lbPlayer2Pairs.Location = new System.Drawing.Point(82, 115);
            this.lbPlayer2Pairs.Name = "lbPlayer2Pairs";
            this.lbPlayer2Pairs.Size = new System.Drawing.Size(42, 46);
            this.lbPlayer2Pairs.TabIndex = 2;
            this.lbPlayer2Pairs.Text = "3";
            // 
            // pbPlayer2Pairs
            // 
            this.pbPlayer2Pairs.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer2Pairs.Image = global::MemoryGame.Properties.Resources._checked;
            this.pbPlayer2Pairs.Location = new System.Drawing.Point(171, 87);
            this.pbPlayer2Pairs.Name = "pbPlayer2Pairs";
            this.pbPlayer2Pairs.Size = new System.Drawing.Size(85, 95);
            this.pbPlayer2Pairs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPlayer2Pairs.TabIndex = 4;
            this.pbPlayer2Pairs.TabStop = false;
            // 
            // pbFinger
            // 
            this.pbFinger.BackColor = System.Drawing.Color.Transparent;
            this.pbFinger.Location = new System.Drawing.Point(349, 86);
            this.pbFinger.Name = "pbFinger";
            this.pbFinger.Size = new System.Drawing.Size(175, 99);
            this.pbFinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFinger.TabIndex = 9;
            this.pbFinger.TabStop = false;
            // 
            // lbOnTurn
            // 
            this.lbOnTurn.AutoSize = true;
            this.lbOnTurn.BackColor = System.Drawing.Color.Transparent;
            this.lbOnTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbOnTurn.ForeColor = System.Drawing.Color.White;
            this.lbOnTurn.Location = new System.Drawing.Point(341, 22);
            this.lbOnTurn.Name = "lbOnTurn";
            this.lbOnTurn.Size = new System.Drawing.Size(183, 46);
            this.lbOnTurn.TabIndex = 6;
            this.lbOnTurn.Text = "Your turn";
            // 
            // pnGameStats
            // 
            this.pnGameStats.BackColor = System.Drawing.Color.Transparent;
            this.pnGameStats.Controls.Add(this.pnPlayer1);
            this.pnGameStats.Controls.Add(this.pnPlayer2);
            this.pnGameStats.Controls.Add(this.lbOnTurn);
            this.pnGameStats.Controls.Add(this.pbFinger);
            this.pnGameStats.Location = new System.Drawing.Point(0, 346);
            this.pnGameStats.Name = "pnGameStats";
            this.pnGameStats.Size = new System.Drawing.Size(856, 212);
            this.pnGameStats.TabIndex = 0;
            // 
            // MultiplayerScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.ClientSize = new System.Drawing.Size(854, 551);
            this.Controls.Add(this.pnGameStats);
            this.Controls.Add(this.lbMultiplayerModeTitle);
            this.Controls.Add(this.pbBackArrow);
            this.Name = "MultiplayerScene";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MultiplayerScene_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).EndInit();
            this.pnPlayer1.ResumeLayout(false);
            this.pnPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1Pairs)).EndInit();
            this.pnPlayer2.ResumeLayout(false);
            this.pnPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2Pairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinger)).EndInit();
            this.pnGameStats.ResumeLayout(false);
            this.pnGameStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackArrow;
        private System.Windows.Forms.Label lbMultiplayerModeTitle;
        private System.Windows.Forms.Panel pnPlayer1;
        private System.Windows.Forms.Label lbPlayer1Pairs;
        private System.Windows.Forms.PictureBox pbPlayer1Pairs;
        private System.Windows.Forms.Label lbPlayer1Name;
        private System.Windows.Forms.Panel pnPlayer2;
        private System.Windows.Forms.Label lbPlayer2Name;
        private System.Windows.Forms.Label lbPlayer2Pairs;
        private System.Windows.Forms.PictureBox pbPlayer2Pairs;
        private System.Windows.Forms.PictureBox pbFinger;
        private System.Windows.Forms.Label lbOnTurn;
        private System.Windows.Forms.Panel pnGameStats;
    }
}