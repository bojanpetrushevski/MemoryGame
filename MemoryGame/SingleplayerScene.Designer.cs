namespace MemoryGame
{
    partial class SingleplayerScene
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleplayerScene));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnStats = new System.Windows.Forms.Panel();
            this.lbPairs = new System.Windows.Forms.Label();
            this.lbTimeElapsed = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbSingleplayerModeTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnStats
            // 
            this.pnStats.BackColor = System.Drawing.Color.Transparent;
            this.pnStats.Controls.Add(this.lbPairs);
            this.pnStats.Controls.Add(this.lbTimeElapsed);
            this.pnStats.Controls.Add(this.pictureBox1);
            this.pnStats.Controls.Add(this.pictureBox2);
            this.pnStats.Location = new System.Drawing.Point(90, 680);
            this.pnStats.Name = "pnStats";
            this.pnStats.Size = new System.Drawing.Size(602, 119);
            this.pnStats.TabIndex = 1;
            // 
            // lbPairs
            // 
            this.lbPairs.AutoSize = true;
            this.lbPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbPairs.ForeColor = System.Drawing.Color.White;
            this.lbPairs.Location = new System.Drawing.Point(476, 46);
            this.lbPairs.Name = "lbPairs";
            this.lbPairs.Size = new System.Drawing.Size(97, 46);
            this.lbPairs.TabIndex = 2;
            this.lbPairs.Text = "2/12";
            // 
            // lbTimeElapsed
            // 
            this.lbTimeElapsed.AutoSize = true;
            this.lbTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbTimeElapsed.ForeColor = System.Drawing.Color.White;
            this.lbTimeElapsed.Location = new System.Drawing.Point(180, 46);
            this.lbTimeElapsed.Name = "lbTimeElapsed";
            this.lbTimeElapsed.Size = new System.Drawing.Size(130, 46);
            this.lbTimeElapsed.TabIndex = 1;
            this.lbTimeElapsed.Text = "02: 12";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MemoryGame.Properties.Resources._checked;
            this.pictureBox2.Location = new System.Drawing.Point(368, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lbSingleplayerModeTitle
            // 
            this.lbSingleplayerModeTitle.AutoSize = true;
            this.lbSingleplayerModeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbSingleplayerModeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lbSingleplayerModeTitle.ForeColor = System.Drawing.Color.White;
            this.lbSingleplayerModeTitle.Location = new System.Drawing.Point(229, 20);
            this.lbSingleplayerModeTitle.Name = "lbSingleplayerModeTitle";
            this.lbSingleplayerModeTitle.Size = new System.Drawing.Size(350, 46);
            this.lbSingleplayerModeTitle.TabIndex = 2;
            this.lbSingleplayerModeTitle.Text = "Singleplayer mode";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SingleplayerScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 764);
            this.Controls.Add(this.lbSingleplayerModeTitle);
            this.Controls.Add(this.pnStats);
            this.Name = "SingleplayerScene";
            this.Load += new System.EventHandler(this.SingleplayerScene_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SingleplayerScene_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SingleplayerScene_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnStats.ResumeLayout(false);
            this.pnStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnStats;
        private System.Windows.Forms.Label lbPairs;
        private System.Windows.Forms.Label lbTimeElapsed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbSingleplayerModeTitle;
        private System.Windows.Forms.Timer timer;
    }
}