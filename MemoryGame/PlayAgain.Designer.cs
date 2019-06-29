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
            this.SuspendLayout();
            // 
            // lbStatusMessage
            // 
            this.lbStatusMessage.AutoSize = true;
            this.lbStatusMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbStatusMessage.ForeColor = System.Drawing.Color.White;
            this.lbStatusMessage.Location = new System.Drawing.Point(285, 49);
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
            this.lbPlayAgain.Location = new System.Drawing.Point(123, 195);
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
            this.lbBackToMainMenu.Location = new System.Drawing.Point(466, 195);
            this.lbBackToMainMenu.Name = "lbBackToMainMenu";
            this.lbBackToMainMenu.Size = new System.Drawing.Size(292, 37);
            this.lbBackToMainMenu.TabIndex = 2;
            this.lbBackToMainMenu.Text = "Back to main menu";
            this.lbBackToMainMenu.Click += new System.EventHandler(this.lbBackToMainMenu_Click);
            this.lbBackToMainMenu.MouseEnter += new System.EventHandler(this.lbBackToMainMenu_MouseEnter);
            this.lbBackToMainMenu.MouseLeave += new System.EventHandler(this.lbBackToMainMenu_MouseLeave);
            // 
            // PlayAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(820, 264);
            this.ControlBox = false;
            this.Controls.Add(this.lbBackToMainMenu);
            this.Controls.Add(this.lbPlayAgain);
            this.Controls.Add(this.lbStatusMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PlayAgain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatusMessage;
        private System.Windows.Forms.Label lbPlayAgain;
        private System.Windows.Forms.Label lbBackToMainMenu;
    }
}