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
            this.lbSingleplayerModeTitle = new System.Windows.Forms.Label();
            this.pnStats = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPairs = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).BeginInit();
            this.pnStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // lbSingleplayerModeTitle
            // 
            this.lbSingleplayerModeTitle.AutoSize = true;
            this.lbSingleplayerModeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbSingleplayerModeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbSingleplayerModeTitle.ForeColor = System.Drawing.Color.White;
            this.lbSingleplayerModeTitle.Location = new System.Drawing.Point(190, 26);
            this.lbSingleplayerModeTitle.Name = "lbSingleplayerModeTitle";
            this.lbSingleplayerModeTitle.Size = new System.Drawing.Size(407, 58);
            this.lbSingleplayerModeTitle.TabIndex = 6;
            this.lbSingleplayerModeTitle.Text = "Multiplayer mode";
            // 
            // pnStats
            // 
            this.pnStats.BackColor = System.Drawing.Color.Transparent;
            this.pnStats.Controls.Add(this.label1);
            this.pnStats.Controls.Add(this.lbPairs);
            this.pnStats.Controls.Add(this.pictureBox2);
            this.pnStats.Location = new System.Drawing.Point(40, 310);
            this.pnStats.Name = "pnStats";
            this.pnStats.Size = new System.Drawing.Size(252, 185);
            this.pnStats.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // lbPairs
            // 
            this.lbPairs.AutoSize = true;
            this.lbPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbPairs.ForeColor = System.Drawing.Color.White;
            this.lbPairs.Location = new System.Drawing.Point(129, 106);
            this.lbPairs.Name = "lbPairs";
            this.lbPairs.Size = new System.Drawing.Size(97, 46);
            this.lbPairs.TabIndex = 2;
            this.lbPairs.Text = "2/12";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MemoryGame.Properties.Resources._checked;
            this.pictureBox2.Location = new System.Drawing.Point(26, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(493, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 185);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "2/12";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MemoryGame.Properties.Resources._checked;
            this.pictureBox1.Location = new System.Drawing.Point(26, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MultiplayerScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(806, 548);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnStats);
            this.Controls.Add(this.lbSingleplayerModeTitle);
            this.Controls.Add(this.pbBackArrow);
            this.DoubleBuffered = true;
            this.Name = "MultiplayerScene";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).EndInit();
            this.pnStats.ResumeLayout(false);
            this.pnStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackArrow;
        private System.Windows.Forms.Label lbSingleplayerModeTitle;
        private System.Windows.Forms.Panel pnStats;
        private System.Windows.Forms.Label lbPairs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}