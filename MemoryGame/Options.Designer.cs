namespace MemoryGame
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.lbOptionsTitle = new System.Windows.Forms.Label();
            this.lbSound = new System.Windows.Forms.Label();
            this.lbCardColor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.pbBackArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOptionsTitle
            // 
            this.lbOptionsTitle.AutoSize = true;
            this.lbOptionsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbOptionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbOptionsTitle.ForeColor = System.Drawing.Color.White;
            this.lbOptionsTitle.Location = new System.Drawing.Point(214, 31);
            this.lbOptionsTitle.Name = "lbOptionsTitle";
            this.lbOptionsTitle.Size = new System.Drawing.Size(198, 58);
            this.lbOptionsTitle.TabIndex = 0;
            this.lbOptionsTitle.Text = "Options";
            // 
            // lbSound
            // 
            this.lbSound.AutoSize = true;
            this.lbSound.BackColor = System.Drawing.Color.Transparent;
            this.lbSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbSound.ForeColor = System.Drawing.Color.White;
            this.lbSound.Location = new System.Drawing.Point(162, 139);
            this.lbSound.Name = "lbSound";
            this.lbSound.Size = new System.Drawing.Size(110, 37);
            this.lbSound.TabIndex = 1;
            this.lbSound.Text = "Sound";
            // 
            // lbCardColor
            // 
            this.lbCardColor.AutoSize = true;
            this.lbCardColor.BackColor = System.Drawing.Color.Transparent;
            this.lbCardColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F);
            this.lbCardColor.ForeColor = System.Drawing.Color.White;
            this.lbCardColor.Location = new System.Drawing.Point(127, 231);
            this.lbCardColor.Name = "lbCardColor";
            this.lbCardColor.Size = new System.Drawing.Size(166, 37);
            this.lbCardColor.TabIndex = 3;
            this.lbCardColor.Text = "Card color";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 37);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.White;
            this.btnOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.btnOnOff.Location = new System.Drawing.Point(378, 135);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(92, 47);
            this.btnOnOff.TabIndex = 5;
            this.btnOnOff.Text = "ON";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // pbBackArrow
            // 
            this.pbBackArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbBackArrow.Image")));
            this.pbBackArrow.Location = new System.Drawing.Point(25, 12);
            this.pbBackArrow.Name = "pbBackArrow";
            this.pbBackArrow.Size = new System.Drawing.Size(41, 35);
            this.pbBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackArrow.TabIndex = 6;
            this.pbBackArrow.TabStop = false;
            this.pbBackArrow.Click += new System.EventHandler(this.pbBackArrow_Click);
            this.pbBackArrow.MouseEnter += new System.EventHandler(this.pbBackArrow_MouseEnter);
            this.pbBackArrow.MouseLeave += new System.EventHandler(this.pbBackArrow_MouseLeave);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(636, 350);
            this.Controls.Add(this.pbBackArrow);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbCardColor);
            this.Controls.Add(this.lbSound);
            this.Controls.Add(this.lbOptionsTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOptionsTitle;
        private System.Windows.Forms.Label lbSound;
        private System.Windows.Forms.Label lbCardColor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.PictureBox pbBackArrow;
    }
}