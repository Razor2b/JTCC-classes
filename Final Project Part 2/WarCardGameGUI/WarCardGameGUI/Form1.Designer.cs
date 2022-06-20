
namespace WarCardGameGUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.DoYouLb = new System.Windows.Forms.Label();
            this.RBtnYes = new System.Windows.Forms.RadioButton();
            this.RBtnNo = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DoYouLb
            // 
            this.DoYouLb.AutoSize = true;
            this.DoYouLb.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoYouLb.Location = new System.Drawing.Point(126, 82);
            this.DoYouLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoYouLb.Name = "DoYouLb";
            this.DoYouLb.Size = new System.Drawing.Size(284, 138);
            this.DoYouLb.TabIndex = 0;
            this.DoYouLb.Text = "Do you want \r\nto play a \r\nWar card game?";
            this.DoYouLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RBtnYes
            // 
            this.RBtnYes.AutoSize = true;
            this.RBtnYes.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnYes.Location = new System.Drawing.Point(134, 276);
            this.RBtnYes.Name = "RBtnYes";
            this.RBtnYes.Size = new System.Drawing.Size(49, 43);
            this.RBtnYes.TabIndex = 1;
            this.RBtnYes.Text = " ";
            this.RBtnYes.UseVisualStyleBackColor = true;
            this.RBtnYes.CheckedChanged += new System.EventHandler(this.RBtnYes_CheckedChanged);
            // 
            // RBtnNo
            // 
            this.RBtnNo.AutoSize = true;
            this.RBtnNo.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnNo.Location = new System.Drawing.Point(337, 276);
            this.RBtnNo.Name = "RBtnNo";
            this.RBtnNo.Size = new System.Drawing.Size(73, 43);
            this.RBtnNo.TabIndex = 2;
            this.RBtnNo.Text = "No";
            this.RBtnNo.UseVisualStyleBackColor = true;
            this.RBtnNo.CheckedChanged += new System.EventHandler(this.RBtnNo_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(530, 448);
            this.Controls.Add(this.RBtnNo);
            this.Controls.Add(this.RBtnYes);
            this.Controls.Add(this.DoYouLb);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Do want want to play War?";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DoYouLb;
        private System.Windows.Forms.RadioButton RBtnYes;
        private System.Windows.Forms.RadioButton RBtnNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

