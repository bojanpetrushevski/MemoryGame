namespace MemoryGame
{
    partial class BackToMainMenu
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
            this.lbYes = new System.Windows.Forms.Label();
            this.lbNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to go back to main menu?";
            // 
            // lbYes
            // 
            this.lbYes.AutoSize = true;
            this.lbYes.BackColor = System.Drawing.Color.Transparent;
            this.lbYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbYes.ForeColor = System.Drawing.Color.White;
            this.lbYes.Location = new System.Drawing.Point(268, 118);
            this.lbYes.Name = "lbYes";
            this.lbYes.Size = new System.Drawing.Size(72, 37);
            this.lbYes.TabIndex = 3;
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
            this.lbNo.Location = new System.Drawing.Point(412, 118);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(59, 37);
            this.lbNo.TabIndex = 4;
            this.lbNo.Text = "No";
            this.lbNo.Click += new System.EventHandler(this.lbNo_Click);
            this.lbNo.MouseEnter += new System.EventHandler(this.lbNo_MouseEnter);
            this.lbNo.MouseLeave += new System.EventHandler(this.lbNo_MouseLeave);
            // 
            // BackToMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(795, 183);
            this.ControlBox = false;
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.lbYes);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BackToMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbYes;
        private System.Windows.Forms.Label lbNo;
    }
}