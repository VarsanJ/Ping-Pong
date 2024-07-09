namespace PingPongSmart___VJ
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
            this.pblComputerPaddle = new System.Windows.Forms.PictureBox();
            this.pblUserPaddle = new System.Windows.Forms.PictureBox();
            this.pblBadZone = new System.Windows.Forms.PictureBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.pblBall = new System.Windows.Forms.PictureBox();
            this.tmrOne = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHigh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pblComputerPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblUserPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblBadZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pblComputerPaddle
            // 
            this.pblComputerPaddle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pblComputerPaddle.Location = new System.Drawing.Point(468, 22);
            this.pblComputerPaddle.Margin = new System.Windows.Forms.Padding(4);
            this.pblComputerPaddle.Name = "pblComputerPaddle";
            this.pblComputerPaddle.Size = new System.Drawing.Size(187, 18);
            this.pblComputerPaddle.TabIndex = 0;
            this.pblComputerPaddle.TabStop = false;
            // 
            // pblUserPaddle
            // 
            this.pblUserPaddle.BackColor = System.Drawing.Color.Lime;
            this.pblUserPaddle.Location = new System.Drawing.Point(468, 436);
            this.pblUserPaddle.Margin = new System.Windows.Forms.Padding(4);
            this.pblUserPaddle.Name = "pblUserPaddle";
            this.pblUserPaddle.Size = new System.Drawing.Size(187, 18);
            this.pblUserPaddle.TabIndex = 1;
            this.pblUserPaddle.TabStop = false;
            // 
            // pblBadZone
            // 
            this.pblBadZone.BackColor = System.Drawing.Color.Red;
            this.pblBadZone.Location = new System.Drawing.Point(0, 472);
            this.pblBadZone.Margin = new System.Windows.Forms.Padding(4);
            this.pblBadZone.Name = "pblBadZone";
            this.pblBadZone.Size = new System.Drawing.Size(1104, 140);
            this.pblBadZone.TabIndex = 2;
            this.pblBadZone.TabStop = false;
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBegin.Location = new System.Drawing.Point(988, 472);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(4);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(100, 28);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "BEGIN";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(988, 543);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhelp.Location = new System.Drawing.Point(988, 508);
            this.btnhelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(100, 28);
            this.btnhelp.TabIndex = 6;
            this.btnhelp.Text = "HELP";
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // lblGameScore
            // 
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.BackColor = System.Drawing.Color.Red;
            this.lblGameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameScore.Location = new System.Drawing.Point(7, 473);
            this.lblGameScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(282, 29);
            this.lblGameScore.TabIndex = 7;
            this.lblGameScore.Text = "# of Paddle Bounces: 0";
            // 
            // pblBall
            // 
            this.pblBall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pblBall.Location = new System.Drawing.Point(539, 222);
            this.pblBall.Name = "pblBall";
            this.pblBall.Size = new System.Drawing.Size(33, 31);
            this.pblBall.TabIndex = 9;
            this.pblBall.TabStop = false;
            // 
            // tmrOne
            // 
            this.tmrOne.Tick += new System.EventHandler(this.tmrOne_Tick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(988, 579);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.BackColor = System.Drawing.Color.Red;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(7, 508);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(200, 29);
            this.lblHigh.TabIndex = 11;
            this.lblHigh.Text = "HIGH SCORE: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1099, 609);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pblBall);
            this.Controls.Add(this.lblGameScore);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.pblBadZone);
            this.Controls.Add(this.pblUserPaddle);
            this.Controls.Add(this.pblComputerPaddle);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pblComputerPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblUserPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblBadZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pblComputerPaddle;
        private System.Windows.Forms.PictureBox pblUserPaddle;
        private System.Windows.Forms.PictureBox pblBadZone;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.PictureBox pblBall;
        private System.Windows.Forms.Timer tmrOne;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHigh;
    }
}

