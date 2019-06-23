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
            this.lbChooseGameCateogryTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lbChooseGameCateogryTitle.Text = "Choose game cateogry ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "4 x 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "4 x 6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(332, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "4 x 5";
            // 
            // ChooseGameCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.mainmenu_wallpaper;
            this.ClientSize = new System.Drawing.Size(786, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbChooseGameCateogryTitle);
            this.Name = "ChooseGameCategory";
            this.Text = "ChooseGameCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChooseGameCateogryTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}