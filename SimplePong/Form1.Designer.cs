namespace SimplePong
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
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Computer = new System.Windows.Forms.PictureBox();
            this.lblScoreComp = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(0, 0);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Yellow;
            this.Player.Location = new System.Drawing.Point(16, 132);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(10, 127);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Computer
            // 
            this.Computer.BackColor = System.Drawing.Color.Fuchsia;
            this.Computer.Location = new System.Drawing.Point(764, 132);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(10, 127);
            this.Computer.TabIndex = 1;
            this.Computer.TabStop = false;
            // 
            // lblScoreComp
            // 
            this.lblScoreComp.AutoSize = true;
            this.lblScoreComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreComp.Location = new System.Drawing.Point(667, 11);
            this.lblScoreComp.Name = "lblScoreComp";
            this.lblScoreComp.Size = new System.Drawing.Size(107, 20);
            this.lblScoreComp.TabIndex = 2;
            this.lblScoreComp.Text = "Computer: 0";
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer.Location = new System.Drawing.Point(12, 9);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(78, 20);
            this.lblScorePlayer.TabIndex = 2;
            this.lblScorePlayer.Text = "Player: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblScoreComp);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Ball);
            this.Name = "Form1";
            this.Text = "Simple Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Computer;
        private System.Windows.Forms.Label lblScoreComp;
        private System.Windows.Forms.Label lblScorePlayer;
    }
}

