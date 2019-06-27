namespace MemoryGame
{
    partial class EnterScore
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
            this.lbEnterYourNameTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.lbOK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEnterYourNameTitle
            // 
            this.lbEnterYourNameTitle.AutoSize = true;
            this.lbEnterYourNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbEnterYourNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbEnterYourNameTitle.ForeColor = System.Drawing.Color.White;
            this.lbEnterYourNameTitle.Location = new System.Drawing.Point(134, 25);
            this.lbEnterYourNameTitle.Name = "lbEnterYourNameTitle";
            this.lbEnterYourNameTitle.Size = new System.Drawing.Size(395, 58);
            this.lbEnterYourNameTitle.TabIndex = 0;
            this.lbEnterYourNameTitle.Text = "Enter your name";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(118, 129);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(112, 37);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(118, 204);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(97, 37);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Time:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.tbName.Location = new System.Drawing.Point(272, 126);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 43);
            this.tbName.TabIndex = 3;
            // 
            // tbTime
            // 
            this.tbTime.Enabled = false;
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.tbTime.Location = new System.Drawing.Point(272, 201);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(224, 43);
            this.tbTime.TabIndex = 4;
            // 
            // lbOK
            // 
            this.lbOK.AutoSize = true;
            this.lbOK.BackColor = System.Drawing.Color.Transparent;
            this.lbOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbOK.ForeColor = System.Drawing.Color.White;
            this.lbOK.Location = new System.Drawing.Point(556, 282);
            this.lbOK.Name = "lbOK";
            this.lbOK.Size = new System.Drawing.Size(63, 37);
            this.lbOK.TabIndex = 5;
            this.lbOK.Text = "OK";
            this.lbOK.Click += new System.EventHandler(this.lbOK_Click);
            // 
            // EnterScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(652, 340);
            this.Controls.Add(this.lbOK);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbEnterYourNameTitle);
            this.DoubleBuffered = true;
            this.Name = "EnterScore";
            this.Text = "EnterScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterYourNameTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label lbOK;
    }
}