namespace MemoryGame
{
    partial class EnterNames
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
            this.lbEnterYourNamesTitle = new System.Windows.Forms.Label();
            this.lbPlayer1Name = new System.Windows.Forms.Label();
            this.lbPlayer2Name = new System.Windows.Forms.Label();
            this.tbPlayer1Name = new System.Windows.Forms.TextBox();
            this.tbPlayer2Name = new System.Windows.Forms.TextBox();
            this.lbStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEnterYourNamesTitle
            // 
            this.lbEnterYourNamesTitle.AutoSize = true;
            this.lbEnterYourNamesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbEnterYourNamesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbEnterYourNamesTitle.ForeColor = System.Drawing.Color.White;
            this.lbEnterYourNamesTitle.Location = new System.Drawing.Point(109, 30);
            this.lbEnterYourNamesTitle.Name = "lbEnterYourNamesTitle";
            this.lbEnterYourNamesTitle.Size = new System.Drawing.Size(420, 58);
            this.lbEnterYourNamesTitle.TabIndex = 0;
            this.lbEnterYourNamesTitle.Text = "Enter your names";
            // 
            // lbPlayer1Name
            // 
            this.lbPlayer1Name.AutoSize = true;
            this.lbPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.lbPlayer1Name.Location = new System.Drawing.Point(48, 137);
            this.lbPlayer1Name.Name = "lbPlayer1Name";
            this.lbPlayer1Name.Size = new System.Drawing.Size(220, 37);
            this.lbPlayer1Name.TabIndex = 1;
            this.lbPlayer1Name.Text = "Player1 name:";
            // 
            // lbPlayer2Name
            // 
            this.lbPlayer2Name.AutoSize = true;
            this.lbPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.lbPlayer2Name.Location = new System.Drawing.Point(48, 231);
            this.lbPlayer2Name.Name = "lbPlayer2Name";
            this.lbPlayer2Name.Size = new System.Drawing.Size(222, 37);
            this.lbPlayer2Name.TabIndex = 2;
            this.lbPlayer2Name.Text = "Player2 name:";
            // 
            // tbPlayer1Name
            // 
            this.tbPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.tbPlayer1Name.Location = new System.Drawing.Point(295, 134);
            this.tbPlayer1Name.Name = "tbPlayer1Name";
            this.tbPlayer1Name.Size = new System.Drawing.Size(245, 43);
            this.tbPlayer1Name.TabIndex = 3;
            // 
            // tbPlayer2Name
            // 
            this.tbPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.tbPlayer2Name.Location = new System.Drawing.Point(295, 228);
            this.tbPlayer2Name.Name = "tbPlayer2Name";
            this.tbPlayer2Name.Size = new System.Drawing.Size(245, 43);
            this.tbPlayer2Name.TabIndex = 4;
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.BackColor = System.Drawing.Color.Transparent;
            this.lbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbStart.ForeColor = System.Drawing.Color.White;
            this.lbStart.Location = new System.Drawing.Point(538, 317);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(85, 37);
            this.lbStart.TabIndex = 5;
            this.lbStart.Text = "Start";
            this.lbStart.Click += new System.EventHandler(this.lbStart_Click);
            // 
            // EnterNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(653, 373);
            this.ControlBox = false;
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.tbPlayer2Name);
            this.Controls.Add(this.tbPlayer1Name);
            this.Controls.Add(this.lbPlayer2Name);
            this.Controls.Add(this.lbPlayer1Name);
            this.Controls.Add(this.lbEnterYourNamesTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EnterNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterYourNamesTitle;
        private System.Windows.Forms.Label lbPlayer1Name;
        private System.Windows.Forms.Label lbPlayer2Name;
        private System.Windows.Forms.TextBox tbPlayer1Name;
        private System.Windows.Forms.TextBox tbPlayer2Name;
        private System.Windows.Forms.Label lbStart;
    }
}