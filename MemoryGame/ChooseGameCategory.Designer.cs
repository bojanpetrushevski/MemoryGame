namespace MemoryGame
{
    partial class ChooseGameCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseGameCategory));
            this.lbChooseGameCateogryTitle = new System.Windows.Forms.Label();
            this.lb4x6 = new System.Windows.Forms.Label();
            this.lb4x5 = new System.Windows.Forms.Label();
            this.lb4x4 = new System.Windows.Forms.Label();
            this.pbBackArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChooseGameCateogryTitle
            // 
            this.lbChooseGameCateogryTitle.AutoSize = true;
            this.lbChooseGameCateogryTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbChooseGameCateogryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.8F);
            this.lbChooseGameCateogryTitle.ForeColor = System.Drawing.Color.White;
            this.lbChooseGameCateogryTitle.Location = new System.Drawing.Point(125, 45);
            this.lbChooseGameCateogryTitle.Name = "lbChooseGameCateogryTitle";
            this.lbChooseGameCateogryTitle.Size = new System.Drawing.Size(556, 58);
            this.lbChooseGameCateogryTitle.TabIndex = 0;
            this.lbChooseGameCateogryTitle.Text = "Choose game category ";
            // 
            // lb4x6
            // 
            this.lb4x6.AutoSize = true;
            this.lb4x6.BackColor = System.Drawing.Color.Transparent;
            this.lb4x6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lb4x6.ForeColor = System.Drawing.Color.White;
            this.lb4x6.Location = new System.Drawing.Point(332, 327);
            this.lb4x6.Name = "lb4x6";
            this.lb4x6.Size = new System.Drawing.Size(107, 46);
            this.lb4x6.TabIndex = 2;
            this.lb4x6.Text = "4 x 6";
            this.lb4x6.Click += new System.EventHandler(this.lb4x6_Click);
            this.lb4x6.MouseEnter += new System.EventHandler(this.lb4x6_MouseEnter);
            this.lb4x6.MouseLeave += new System.EventHandler(this.lb4x6_MouseLeave);
            // 
            // lb4x5
            // 
            this.lb4x5.AutoSize = true;
            this.lb4x5.BackColor = System.Drawing.Color.Transparent;
            this.lb4x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lb4x5.ForeColor = System.Drawing.Color.White;
            this.lb4x5.Location = new System.Drawing.Point(332, 234);
            this.lb4x5.Name = "lb4x5";
            this.lb4x5.Size = new System.Drawing.Size(107, 46);
            this.lb4x5.TabIndex = 3;
            this.lb4x5.Text = "4 x 5";
            this.lb4x5.Click += new System.EventHandler(this.lb4x5_Click);
            this.lb4x5.MouseEnter += new System.EventHandler(this.lb4x5_MouseEnter);
            this.lb4x5.MouseLeave += new System.EventHandler(this.lb4x5_MouseLeave);
            // 
            // lb4x4
            // 
            this.lb4x4.AutoSize = true;
            this.lb4x4.BackColor = System.Drawing.Color.Transparent;
            this.lb4x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.lb4x4.ForeColor = System.Drawing.Color.White;
            this.lb4x4.Location = new System.Drawing.Point(332, 144);
            this.lb4x4.Name = "lb4x4";
            this.lb4x4.Size = new System.Drawing.Size(107, 46);
            this.lb4x4.TabIndex = 1;
            this.lb4x4.Text = "4 x 4";
            this.lb4x4.Click += new System.EventHandler(this.lb4x4_Click);
            this.lb4x4.MouseEnter += new System.EventHandler(this.lb4x4_MouseEnter);
            this.lb4x4.MouseLeave += new System.EventHandler(this.lb4x4_MouseLeave);
            // 
            // pbBackArrow
            // 
            this.pbBackArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbBackArrow.Image = ((System.Drawing.Image)(resources.GetObject("pbBackArrow.Image")));
            this.pbBackArrow.Location = new System.Drawing.Point(28, 45);
            this.pbBackArrow.Name = "pbBackArrow";
            this.pbBackArrow.Size = new System.Drawing.Size(44, 42);
            this.pbBackArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackArrow.TabIndex = 4;
            this.pbBackArrow.TabStop = false;
            this.pbBackArrow.Click += new System.EventHandler(this.pbBackArrow_Click);
            // 
            // ChooseGameCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 441);
            this.ControlBox = false;
            this.Controls.Add(this.pbBackArrow);
            this.Controls.Add(this.lb4x5);
            this.Controls.Add(this.lb4x6);
            this.Controls.Add(this.lb4x4);
            this.Controls.Add(this.lbChooseGameCateogryTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChooseGameCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbBackArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChooseGameCateogryTitle;
        private System.Windows.Forms.Label lb4x6;
        private System.Windows.Forms.Label lb4x5;
        private System.Windows.Forms.Label lb4x4;
        private System.Windows.Forms.PictureBox pbBackArrow;
    }
}