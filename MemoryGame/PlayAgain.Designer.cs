namespace MemoryGame
{
    partial class PlayAgain
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
            this.lbStatusMessage = new System.Windows.Forms.Label();
            this.lbPlayAgain = new System.Windows.Forms.Label();
            this.lbBackToMainMenu = new System.Windows.Forms.Label();
            this.pbMedal1 = new System.Windows.Forms.PictureBox();
            this.pbMedal2 = new System.Windows.Forms.PictureBox();
            this.pbTrophy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrophy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatusMessage
            // 
            this.lbStatusMessage.AutoSize = true;
            this.lbStatusMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbStatusMessage.ForeColor = System.Drawing.Color.White;
            this.lbStatusMessage.Location = new System.Drawing.Point(305, 30);
            this.lbStatusMessage.Name = "lbStatusMessage";
            this.lbStatusMessage.Size = new System.Drawing.Size(246, 37);
            this.lbStatusMessage.TabIndex = 0;
            this.lbStatusMessage.Text = "Status message";
            // 
            // lbPlayAgain
            // 
            this.lbPlayAgain.AutoSize = true;
            this.lbPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbPlayAgain.ForeColor = System.Drawing.Color.White;
            this.lbPlayAgain.Location = new System.Drawing.Point(166, 195);
            this.lbPlayAgain.Name = "lbPlayAgain";
            this.lbPlayAgain.Size = new System.Drawing.Size(166, 37);
            this.lbPlayAgain.TabIndex = 1;
            this.lbPlayAgain.Text = "Play again";
            this.lbPlayAgain.Click += new System.EventHandler(this.lbPlayAgain_Click);
            this.lbPlayAgain.MouseEnter += new System.EventHandler(this.lbPlayAgain_MouseEnter);
            this.lbPlayAgain.MouseLeave += new System.EventHandler(this.lbPlayAgain_MouseLeave);
            // 
            // lbBackToMainMenu
            // 
            this.lbBackToMainMenu.AutoSize = true;
            this.lbBackToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lbBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbBackToMainMenu.ForeColor = System.Drawing.Color.White;
            this.lbBackToMainMenu.Location = new System.Drawing.Point(499, 195);
            this.lbBackToMainMenu.Name = "lbBackToMainMenu";
            this.lbBackToMainMenu.Size = new System.Drawing.Size(292, 37);
            this.lbBackToMainMenu.TabIndex = 2;
            this.lbBackToMainMenu.Text = "Back to main menu";
            this.lbBackToMainMenu.Click += new System.EventHandler(this.lbBackToMainMenu_Click);
            this.lbBackToMainMenu.MouseEnter += new System.EventHandler(this.lbBackToMainMenu_MouseEnter);
            this.lbBackToMainMenu.MouseLeave += new System.EventHandler(this.lbBackToMainMenu_MouseLeave);
            // 
            // pbMedal1
            // 
            this.pbMedal1.BackColor = System.Drawing.Color.Transparent;
            this.pbMedal1.Location = new System.Drawing.Point(213, 99);
            this.pbMedal1.Name = "pbMedal1";
            this.pbMedal1.Size = new System.Drawing.Size(148, 75);
            this.pbMedal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMedal1.TabIndex = 3;
            this.pbMedal1.TabStop = false;
            // 
            // pbMedal2
            // 
            this.pbMedal2.BackColor = System.Drawing.Color.Transparent;
            this.pbMedal2.Location = new System.Drawing.Point(530, 99);
            this.pbMedal2.Name = "pbMedal2";
            this.pbMedal2.Size = new System.Drawing.Size(148, 75);
            this.pbMedal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMedal2.TabIndex = 4;
            this.pbMedal2.TabStop = false;
            // 
            // pbTrophy
            // 
            this.pbTrophy.BackColor = System.Drawing.Color.Transparent;
            this.pbTrophy.Location = new System.Drawing.Point(367, 99);
            this.pbTrophy.Name = "pbTrophy";
            this.pbTrophy.Size = new System.Drawing.Size(157, 75);
            this.pbTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTrophy.TabIndex = 5;
            this.pbTrophy.TabStop = false;
            // 
            // PlayAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(903, 264);
            this.ControlBox = false;
            this.Controls.Add(this.pbTrophy);
            this.Controls.Add(this.pbMedal2);
            this.Controls.Add(this.pbMedal1);
            this.Controls.Add(this.lbBackToMainMenu);
            this.Controls.Add(this.lbPlayAgain);
            this.Controls.Add(this.lbStatusMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PlayAgain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbMedal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatusMessage;
        private System.Windows.Forms.Label lbPlayAgain;
        private System.Windows.Forms.Label lbBackToMainMenu;
        private System.Windows.Forms.PictureBox pbMedal1;
        private System.Windows.Forms.PictureBox pbMedal2;
        private System.Windows.Forms.PictureBox pbTrophy;
    }
}