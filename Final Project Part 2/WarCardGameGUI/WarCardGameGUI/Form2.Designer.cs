
namespace WarCardGameGUI
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.LbDeal = new System.Windows.Forms.Label();
            this.BtnDeal = new System.Windows.Forms.Button();
            this.LbPlay = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.TxtGame = new System.Windows.Forms.TextBox();
            this.LbEnd = new System.Windows.Forms.Label();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbDeal
            // 
            this.LbDeal.AutoSize = true;
            this.LbDeal.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDeal.Location = new System.Drawing.Point(421, 42);
            this.LbDeal.Name = "LbDeal";
            this.LbDeal.Size = new System.Drawing.Size(121, 25);
            this.LbDeal.TabIndex = 0;
            this.LbDeal.Text = "Click to deal";
            // 
            // BtnDeal
            // 
            this.BtnDeal.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeal.Location = new System.Drawing.Point(440, 92);
            this.BtnDeal.Name = "BtnDeal";
            this.BtnDeal.Size = new System.Drawing.Size(90, 40);
            this.BtnDeal.TabIndex = 1;
            this.BtnDeal.Text = "Deal";
            this.BtnDeal.UseVisualStyleBackColor = true;
            this.BtnDeal.Click += new System.EventHandler(this.BtnDeal_Click);
            // 
            // LbPlay
            // 
            this.LbPlay.AutoSize = true;
            this.LbPlay.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlay.Location = new System.Drawing.Point(393, 170);
            this.LbPlay.Name = "LbPlay";
            this.LbPlay.Size = new System.Drawing.Size(190, 25);
            this.LbPlay.TabIndex = 2;
            this.LbPlay.Text = "Click to play a hand";
            this.LbPlay.Visible = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlay.Location = new System.Drawing.Point(440, 215);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(90, 40);
            this.BtnPlay.TabIndex = 3;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Visible = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // TxtGame
            // 
            this.TxtGame.AcceptsReturn = true;
            this.TxtGame.BackColor = System.Drawing.Color.LightYellow;
            this.TxtGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtGame.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGame.Location = new System.Drawing.Point(21, 25);
            this.TxtGame.Multiline = true;
            this.TxtGame.Name = "TxtGame";
            this.TxtGame.Size = new System.Drawing.Size(321, 500);
            this.TxtGame.TabIndex = 4;
            // 
            // LbEnd
            // 
            this.LbEnd.AutoSize = true;
            this.LbEnd.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEnd.Location = new System.Drawing.Point(15, 541);
            this.LbEnd.Name = "LbEnd";
            this.LbEnd.Size = new System.Drawing.Size(330, 31);
            this.LbEnd.TabIndex = 5;
            this.LbEnd.Text = "Click END to end the game";
            this.LbEnd.Visible = false;
            // 
            // BtnEnd
            // 
            this.BtnEnd.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnd.Location = new System.Drawing.Point(440, 532);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(90, 40);
            this.BtnEnd.TabIndex = 6;
            this.BtnEnd.Text = "End";
            this.BtnEnd.UseVisualStyleBackColor = true;
            this.BtnEnd.Visible = false;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(614, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.LbEnd);
            this.Controls.Add(this.TxtGame);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.LbPlay);
            this.Controls.Add(this.BtnDeal);
            this.Controls.Add(this.LbDeal);
            this.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GameWindow";
            this.Text = "War Card Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbDeal;
        private System.Windows.Forms.Button BtnDeal;
        private System.Windows.Forms.Label LbPlay;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.TextBox TxtGame;
        private System.Windows.Forms.Label LbEnd;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}