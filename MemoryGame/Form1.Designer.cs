using System.Drawing;

namespace MemoryGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbPlay = new System.Windows.Forms.Label();
            this.lbBestScores = new System.Windows.Forms.Label();
            this.rbSinglePlayer = new System.Windows.Forms.RadioButton();
            this.rbMultiPlayer = new System.Windows.Forms.RadioButton();
            this.gbChooseGameMode = new System.Windows.Forms.GroupBox();
            this.gbChooseGameCategory = new System.Windows.Forms.GroupBox();
            this.rb4x6 = new System.Windows.Forms.RadioButton();
            this.rb4x4 = new System.Windows.Forms.RadioButton();
            this.rb4x5 = new System.Windows.Forms.RadioButton();
            this.lbOptions = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbChooseGameMode.SuspendLayout();
            this.gbChooseGameCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlay
            // 
            this.lbPlay.AutoSize = true;
            this.lbPlay.BackColor = System.Drawing.Color.Transparent;
            this.lbPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPlay.Location = new System.Drawing.Point(325, 110);
            this.lbPlay.Name = "lbPlay";
            this.lbPlay.Size = new System.Drawing.Size(78, 37);
            this.lbPlay.TabIndex = 0;
            this.lbPlay.Text = "Play";
            this.lbPlay.MouseEnter += new System.EventHandler(this.lbPlay_MouseEnter);
            this.lbPlay.MouseLeave += new System.EventHandler(this.lbPlay_MouseLeave);
            // 
            // lbBestScores
            // 
            this.lbBestScores.AutoSize = true;
            this.lbBestScores.BackColor = System.Drawing.Color.Transparent;
            this.lbBestScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbBestScores.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBestScores.Location = new System.Drawing.Point(274, 399);
            this.lbBestScores.Name = "lbBestScores";
            this.lbBestScores.Size = new System.Drawing.Size(183, 37);
            this.lbBestScores.TabIndex = 3;
            this.lbBestScores.Text = "Best scores";
            this.lbBestScores.MouseEnter += new System.EventHandler(this.lbBestScores_MouseEnter);
            this.lbBestScores.MouseLeave += new System.EventHandler(this.lbBestScores_MouseLeave);
            // 
            // rbSinglePlayer
            // 
            this.rbSinglePlayer.AutoSize = true;
            this.rbSinglePlayer.Checked = true;
            this.rbSinglePlayer.Location = new System.Drawing.Point(37, 36);
            this.rbSinglePlayer.Name = "rbSinglePlayer";
            this.rbSinglePlayer.Size = new System.Drawing.Size(221, 41);
            this.rbSinglePlayer.TabIndex = 4;
            this.rbSinglePlayer.TabStop = true;
            this.rbSinglePlayer.Text = "Single player";
            this.rbSinglePlayer.UseVisualStyleBackColor = true;
            this.rbSinglePlayer.MouseEnter += new System.EventHandler(this.rbSinglePlayer_MouseEnter);
            this.rbSinglePlayer.MouseLeave += new System.EventHandler(this.rbSinglePlayer_MouseLeave);
            // 
            // rbMultiPlayer
            // 
            this.rbMultiPlayer.AutoSize = true;
            this.rbMultiPlayer.Location = new System.Drawing.Point(322, 36);
            this.rbMultiPlayer.Name = "rbMultiPlayer";
            this.rbMultiPlayer.Size = new System.Drawing.Size(200, 41);
            this.rbMultiPlayer.TabIndex = 5;
            this.rbMultiPlayer.Text = "Multi player";
            this.rbMultiPlayer.UseVisualStyleBackColor = true;
            this.rbMultiPlayer.MouseEnter += new System.EventHandler(this.rbMultiPlayer_MouseEnter);
            this.rbMultiPlayer.MouseLeave += new System.EventHandler(this.rbMultiPlayer_MouseLeave);
            // 
            // gbChooseGameMode
            // 
            this.gbChooseGameMode.BackColor = System.Drawing.Color.Transparent;
            this.gbChooseGameMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbChooseGameMode.Controls.Add(this.rbSinglePlayer);
            this.gbChooseGameMode.Controls.Add(this.rbMultiPlayer);
            this.gbChooseGameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.gbChooseGameMode.ForeColor = System.Drawing.Color.White;
            this.gbChooseGameMode.Location = new System.Drawing.Point(87, 170);
            this.gbChooseGameMode.Name = "gbChooseGameMode";
            this.gbChooseGameMode.Size = new System.Drawing.Size(560, 91);
            this.gbChooseGameMode.TabIndex = 7;
            this.gbChooseGameMode.TabStop = false;
            this.gbChooseGameMode.Text = "Choose game mode";
            // 
            // gbChooseGameCategory
            // 
            this.gbChooseGameCategory.BackColor = System.Drawing.Color.Transparent;
            this.gbChooseGameCategory.Controls.Add(this.rb4x6);
            this.gbChooseGameCategory.Controls.Add(this.rb4x4);
            this.gbChooseGameCategory.Controls.Add(this.rb4x5);
            this.gbChooseGameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.gbChooseGameCategory.ForeColor = System.Drawing.Color.White;
            this.gbChooseGameCategory.Location = new System.Drawing.Point(110, 286);
            this.gbChooseGameCategory.Name = "gbChooseGameCategory";
            this.gbChooseGameCategory.Size = new System.Drawing.Size(522, 91);
            this.gbChooseGameCategory.TabIndex = 8;
            this.gbChooseGameCategory.TabStop = false;
            this.gbChooseGameCategory.Text = "Choose game category";
            // 
            // rb4x6
            // 
            this.rb4x6.AutoSize = true;
            this.rb4x6.Location = new System.Drawing.Point(389, 42);
            this.rb4x6.Name = "rb4x6";
            this.rb4x6.Size = new System.Drawing.Size(89, 41);
            this.rb4x6.TabIndex = 6;
            this.rb4x6.Text = "4x6";
            this.rb4x6.UseVisualStyleBackColor = true;
            this.rb4x6.MouseEnter += new System.EventHandler(this.rb4x6_MouseEnter);
            this.rb4x6.MouseLeave += new System.EventHandler(this.rb4x6_MouseLeave);
            // 
            // rb4x4
            // 
            this.rb4x4.AutoSize = true;
            this.rb4x4.Checked = true;
            this.rb4x4.Location = new System.Drawing.Point(49, 42);
            this.rb4x4.Name = "rb4x4";
            this.rb4x4.Size = new System.Drawing.Size(89, 41);
            this.rb4x4.TabIndex = 4;
            this.rb4x4.TabStop = true;
            this.rb4x4.Text = "4x4";
            this.rb4x4.UseVisualStyleBackColor = true;
            this.rb4x4.MouseEnter += new System.EventHandler(this.rb4x4_MouseEnter);
            this.rb4x4.MouseLeave += new System.EventHandler(this.rb4x4_MouseLeave);
            // 
            // rb4x5
            // 
            this.rb4x5.AutoSize = true;
            this.rb4x5.Location = new System.Drawing.Point(210, 42);
            this.rb4x5.Name = "rb4x5";
            this.rb4x5.Size = new System.Drawing.Size(89, 41);
            this.rb4x5.TabIndex = 5;
            this.rb4x5.Text = "4x5";
            this.rb4x5.UseVisualStyleBackColor = true;
            this.rb4x5.MouseEnter += new System.EventHandler(this.rb4x5_MouseEnter);
            this.rb4x5.MouseLeave += new System.EventHandler(this.rb4x5_MouseLeave);
            // 
            // lbOptions
            // 
            this.lbOptions.AutoSize = true;
            this.lbOptions.BackColor = System.Drawing.Color.Transparent;
            this.lbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbOptions.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOptions.Location = new System.Drawing.Point(300, 451);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(128, 37);
            this.lbOptions.TabIndex = 9;
            this.lbOptions.Text = "Options";
            this.lbOptions.MouseEnter += new System.EventHandler(this.lbOptions_MouseEnter);
            this.lbOptions.MouseLeave += new System.EventHandler(this.lbOptions_MouseLeave);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.BackColor = System.Drawing.Color.Transparent;
            this.lbAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.lbAbout.Location = new System.Drawing.Point(313, 506);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(102, 37);
            this.lbAbout.TabIndex = 10;
            this.lbAbout.Text = "About";
            this.lbAbout.MouseEnter += new System.EventHandler(this.lbAbout_MouseEnter);
            this.lbAbout.MouseLeave += new System.EventHandler(this.lbAbout_MouseLeave);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbExit.ForeColor = System.Drawing.SystemColors.Control;
            this.lbExit.Location = new System.Drawing.Point(325, 560);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(69, 37);
            this.lbExit.TabIndex = 11;
            this.lbExit.Text = "Exit";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            this.lbExit.MouseEnter += new System.EventHandler(this.lbExit_MouseEnter);
            this.lbExit.MouseLeave += new System.EventHandler(this.lbExit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(186, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "Memory Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(713, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlay);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbOptions);
            this.Controls.Add(this.gbChooseGameCategory);
            this.Controls.Add(this.gbChooseGameMode);
            this.Controls.Add(this.lbBestScores);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.gbChooseGameMode.ResumeLayout(false);
            this.gbChooseGameMode.PerformLayout();
            this.gbChooseGameCategory.ResumeLayout(false);
            this.gbChooseGameCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlay;
        private System.Windows.Forms.Label lbBestScores;
        private System.Windows.Forms.RadioButton rbSinglePlayer;
        private System.Windows.Forms.RadioButton rbMultiPlayer;
        private System.Windows.Forms.GroupBox gbChooseGameMode;
        private System.Windows.Forms.GroupBox gbChooseGameCategory;
        private System.Windows.Forms.RadioButton rb4x6;
        private System.Windows.Forms.RadioButton rb4x4;
        private System.Windows.Forms.RadioButton rb4x5;
        private System.Windows.Forms.Label lbOptions;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label label1;
    }
}

