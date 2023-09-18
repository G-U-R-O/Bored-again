namespace Uttråkad_igen
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
            this.components = new System.ComponentModel.Container();
            this.BQ = new System.Windows.Forms.Button();
            this.BW = new System.Windows.Forms.Button();
            this.BE = new System.Windows.Forms.Button();
            this.BAR = new System.Windows.Forms.Button();
            this.BAD = new System.Windows.Forms.Button();
            this.BAL = new System.Windows.Forms.Button();
            this.Flor = new System.Windows.Forms.Button();
            this.BtnKör = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.Timer4 = new System.Windows.Forms.Timer(this.components);
            this.SLOW = new System.Windows.Forms.Button();
            this.FAST = new System.Windows.Forms.Button();
            this.LblSlow = new System.Windows.Forms.Label();
            this.LblFast = new System.Windows.Forms.Label();
            this.Victory = new System.Windows.Forms.Button();
            this.Mål = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mål)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BQ
            // 
            this.BQ.BackColor = System.Drawing.Color.White;
            this.BQ.Enabled = false;
            this.BQ.Location = new System.Drawing.Point(12, 378);
            this.BQ.Name = "BQ";
            this.BQ.Size = new System.Drawing.Size(60, 60);
            this.BQ.TabIndex = 0;
            this.BQ.Text = "Q";
            this.BQ.UseVisualStyleBackColor = false;
            this.BQ.Click += new System.EventHandler(this.BQ_Click);
            // 
            // BW
            // 
            this.BW.BackColor = System.Drawing.Color.White;
            this.BW.Enabled = false;
            this.BW.Location = new System.Drawing.Point(78, 378);
            this.BW.Name = "BW";
            this.BW.Size = new System.Drawing.Size(60, 60);
            this.BW.TabIndex = 1;
            this.BW.Text = "W";
            this.BW.UseVisualStyleBackColor = false;
            this.BW.Click += new System.EventHandler(this.BW_Click);
            // 
            // BE
            // 
            this.BE.BackColor = System.Drawing.Color.White;
            this.BE.Enabled = false;
            this.BE.Location = new System.Drawing.Point(144, 378);
            this.BE.Name = "BE";
            this.BE.Size = new System.Drawing.Size(60, 60);
            this.BE.TabIndex = 2;
            this.BE.Text = "E";
            this.BE.UseVisualStyleBackColor = false;
            this.BE.Click += new System.EventHandler(this.BE_Click);
            // 
            // BAR
            // 
            this.BAR.BackColor = System.Drawing.Color.White;
            this.BAR.Enabled = false;
            this.BAR.Location = new System.Drawing.Point(728, 378);
            this.BAR.Name = "BAR";
            this.BAR.Size = new System.Drawing.Size(60, 60);
            this.BAR.TabIndex = 5;
            this.BAR.Text = "->";
            this.BAR.UseVisualStyleBackColor = false;
            this.BAR.Click += new System.EventHandler(this.BAR_Click);
            // 
            // BAD
            // 
            this.BAD.BackColor = System.Drawing.Color.White;
            this.BAD.Enabled = false;
            this.BAD.Location = new System.Drawing.Point(662, 378);
            this.BAD.Name = "BAD";
            this.BAD.Size = new System.Drawing.Size(60, 60);
            this.BAD.TabIndex = 4;
            this.BAD.Text = " |\r\n\\/";
            this.BAD.UseVisualStyleBackColor = false;
            this.BAD.Click += new System.EventHandler(this.BAD_Click);
            // 
            // BAL
            // 
            this.BAL.BackColor = System.Drawing.Color.White;
            this.BAL.Enabled = false;
            this.BAL.Location = new System.Drawing.Point(596, 378);
            this.BAL.Name = "BAL";
            this.BAL.Size = new System.Drawing.Size(60, 60);
            this.BAL.TabIndex = 3;
            this.BAL.Text = "<-";
            this.BAL.UseVisualStyleBackColor = false;
            this.BAL.Click += new System.EventHandler(this.BAL_Click);
            // 
            // Flor
            // 
            this.Flor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Flor.Location = new System.Drawing.Point(-7, 207);
            this.Flor.Name = "Flor";
            this.Flor.Size = new System.Drawing.Size(818, 23);
            this.Flor.TabIndex = 6;
            this.Flor.UseVisualStyleBackColor = false;
            // 
            // BtnKör
            // 
            this.BtnKör.BackColor = System.Drawing.Color.Lime;
            this.BtnKör.Enabled = false;
            this.BtnKör.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKör.Location = new System.Drawing.Point(350, 170);
            this.BtnKör.Name = "BtnKör";
            this.BtnKör.Size = new System.Drawing.Size(75, 75);
            this.BtnKör.TabIndex = 9;
            this.BtnKör.Text = "Play";
            this.BtnKör.UseVisualStyleBackColor = false;
            this.BtnKör.Click += new System.EventHandler(this.BtnKör_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 700;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 700;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Timer3
            // 
            this.Timer3.Interval = 700;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // Timer4
            // 
            this.Timer4.Interval = 700;
            this.Timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // SLOW
            // 
            this.SLOW.BackColor = System.Drawing.Color.White;
            this.SLOW.ForeColor = System.Drawing.Color.White;
            this.SLOW.Location = new System.Drawing.Point(350, 71);
            this.SLOW.Name = "SLOW";
            this.SLOW.Size = new System.Drawing.Size(75, 23);
            this.SLOW.TabIndex = 10;
            this.SLOW.Text = "10";
            this.SLOW.UseVisualStyleBackColor = false;
            this.SLOW.Click += new System.EventHandler(this.SLOW_Click);
            // 
            // FAST
            // 
            this.FAST.BackColor = System.Drawing.Color.White;
            this.FAST.ForeColor = System.Drawing.Color.White;
            this.FAST.Location = new System.Drawing.Point(350, 123);
            this.FAST.Name = "FAST";
            this.FAST.Size = new System.Drawing.Size(75, 23);
            this.FAST.TabIndex = 11;
            this.FAST.Text = "20";
            this.FAST.UseVisualStyleBackColor = false;
            this.FAST.Click += new System.EventHandler(this.FAST_Click);
            // 
            // LblSlow
            // 
            this.LblSlow.AutoSize = true;
            this.LblSlow.Location = new System.Drawing.Point(285, 76);
            this.LblSlow.Name = "LblSlow";
            this.LblSlow.Size = new System.Drawing.Size(59, 13);
            this.LblSlow.TabIndex = 12;
            this.LblSlow.Text = "Slow Race";
            // 
            // LblFast
            // 
            this.LblFast.AutoSize = true;
            this.LblFast.Location = new System.Drawing.Point(288, 128);
            this.LblFast.Name = "LblFast";
            this.LblFast.Size = new System.Drawing.Size(56, 13);
            this.LblFast.TabIndex = 13;
            this.LblFast.Text = "Fast Race";
            // 
            // Victory
            // 
            this.Victory.Location = new System.Drawing.Point(309, 92);
            this.Victory.Name = "Victory";
            this.Victory.Size = new System.Drawing.Size(150, 150);
            this.Victory.TabIndex = 15;
            this.Victory.UseVisualStyleBackColor = true;
            this.Victory.Visible = false;
            this.Victory.Click += new System.EventHandler(this.Victory_Click);
            // 
            // Mål
            // 
            this.Mål.Image = global::Uttråkad_igen.Properties.Resources.istockphoto_183598463_612x612;
            this.Mål.Location = new System.Drawing.Point(728, 0);
            this.Mål.Name = "Mål";
            this.Mål.Size = new System.Drawing.Size(25, 209);
            this.Mål.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mål.TabIndex = 14;
            this.Mål.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.Image = global::Uttråkad_igen.Properties.Resources.images2;
            this.Player2.Location = new System.Drawing.Point(12, 151);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(100, 50);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 8;
            this.Player2.TabStop = false;
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Green;
            this.Player1.Image = global::Uttråkad_igen.Properties.Resources.images1;
            this.Player1.Location = new System.Drawing.Point(12, 12);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(100, 50);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 7;
            this.Player1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Uttråkad_igen.Properties.Resources.istockphoto_506692747_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Uttråkad_igen.Properties.Resources._05A_sweet_green_hay_premium_hay;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(818, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.White;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Location = new System.Drawing.Point(350, 397);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 18;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.LblFast);
            this.Controls.Add(this.LblSlow);
            this.Controls.Add(this.FAST);
            this.Controls.Add(this.SLOW);
            this.Controls.Add(this.BtnKör);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.BAR);
            this.Controls.Add(this.BAD);
            this.Controls.Add(this.BAL);
            this.Controls.Add(this.BE);
            this.Controls.Add(this.BW);
            this.Controls.Add(this.BQ);
            this.Controls.Add(this.Victory);
            this.Controls.Add(this.Flor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Mål);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mål)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BQ;
        private System.Windows.Forms.Button BW;
        private System.Windows.Forms.Button BE;
        private System.Windows.Forms.Button BAR;
        private System.Windows.Forms.Button BAD;
        private System.Windows.Forms.Button BAL;
        private System.Windows.Forms.Button Flor;
        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.Button BtnKör;
        private System.Windows.Forms.Timer Timer1;
        public System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Timer Timer3;
        private System.Windows.Forms.Timer Timer4;
        private System.Windows.Forms.Button SLOW;
        private System.Windows.Forms.Button FAST;
        private System.Windows.Forms.Label LblSlow;
        private System.Windows.Forms.Label LblFast;
        private System.Windows.Forms.PictureBox Mål;
        private System.Windows.Forms.Button Victory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Restart;
    }
}

