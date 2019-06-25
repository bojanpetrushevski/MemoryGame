namespace MemoryGame
{
    partial class Exit
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
            this.lbSureQuit = new System.Windows.Forms.Label();
            this.lbYes = new System.Windows.Forms.Label();
            this.lbNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSureQuit
            // 
            this.lbSureQuit.AutoSize = true;
            this.lbSureQuit.BackColor = System.Drawing.Color.Transparent;
            this.lbSureQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbSureQuit.ForeColor = System.Drawing.Color.White;
            this.lbSureQuit.Location = new System.Drawing.Point(66, 54);
            this.lbSureQuit.Name = "lbSureQuit";
            this.lbSureQuit.Size = new System.Drawing.Size(445, 37);
            this.lbSureQuit.TabIndex = 0;
            this.lbSureQuit.Text = "Are you sure you want to exit?";
            // 
            // lbYes
            // 
            this.lbYes.AutoSize = true;
            this.lbYes.BackColor = System.Drawing.Color.Transparent;
            this.lbYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbYes.ForeColor = System.Drawing.Color.White;
            this.lbYes.Location = new System.Drawing.Point(189, 146);
            this.lbYes.Name = "lbYes";
            this.lbYes.Size = new System.Drawing.Size(72, 37);
            this.lbYes.TabIndex = 1;
            this.lbYes.Text = "Yes";
            this.lbYes.Click += new System.EventHandler(this.lbYes_Click);
            this.lbYes.MouseEnter += new System.EventHandler(this.lbYes_MouseEnter);
            this.lbYes.MouseLeave += new System.EventHandler(this.lbYes_MouseLeave);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.BackColor = System.Drawing.Color.Transparent;
            this.lbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbNo.ForeColor = System.Drawing.Color.White;
            this.lbNo.Location = new System.Drawing.Point(303, 146);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(59, 37);
            this.lbNo.TabIndex = 2;
            this.lbNo.Text = "No";
            this.lbNo.Click += new System.EventHandler(this.lbNo_Click);
            this.lbNo.MouseEnter += new System.EventHandler(this.lbNo_MouseEnter);
            this.lbNo.MouseLeave += new System.EventHandler(this.lbNo_MouseLeave);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(556, 235);
            this.ControlBox = false;
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.lbYes);
            this.Controls.Add(this.lbSureQuit);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSureQuit;
        private System.Windows.Forms.Label lbYes;
        private System.Windows.Forms.Label lbNo;
    }
}