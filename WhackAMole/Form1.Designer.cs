﻿namespace WhackAMole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.plr1Misses1 = new System.Windows.Forms.PictureBox();
            this.plr1Misses2 = new System.Windows.Forms.PictureBox();
            this.plr1Misses3 = new System.Windows.Forms.PictureBox();
            this.plr2Misses3 = new System.Windows.Forms.PictureBox();
            this.plr2Misses2 = new System.Windows.Forms.PictureBox();
            this.plr2Misses1 = new System.Windows.Forms.PictureBox();
            this.gameOverBox = new System.Windows.Forms.PictureBox();
            this.continueBox = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.endGameTimer = new System.Windows.Forms.Timer(this.components);
            this.yellowMole = new System.Windows.Forms.PictureBox();
            this.redMole = new System.Windows.Forms.PictureBox();
            this.greenMole = new System.Windows.Forms.PictureBox();
            this.blueMole = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr1Misses1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr1Misses2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr1Misses3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr2Misses3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr2Misses2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr2Misses1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.continueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowMole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redMole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenMole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueMole)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 17;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(810, 587);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 80);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(875, 587);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 80);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(82, 587);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 80);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(149, 587);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 80);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(462, 165);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(90, 150);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // plr1Misses1
            // 
            this.plr1Misses1.BackColor = System.Drawing.Color.Transparent;
            this.plr1Misses1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plr1Misses1.BackgroundImage")));
            this.plr1Misses1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plr1Misses1.Location = new System.Drawing.Point(12, 468);
            this.plr1Misses1.Name = "plr1Misses1";
            this.plr1Misses1.Size = new System.Drawing.Size(60, 60);
            this.plr1Misses1.TabIndex = 13;
            this.plr1Misses1.TabStop = false;
            this.plr1Misses1.Visible = false;
            // 
            // plr1Misses2
            // 
            this.plr1Misses2.BackColor = System.Drawing.Color.Transparent;
            this.plr1Misses2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plr1Misses2.BackgroundImage")));
            this.plr1Misses2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plr1Misses2.Location = new System.Drawing.Point(82, 468);
            this.plr1Misses2.Name = "plr1Misses2";
            this.plr1Misses2.Size = new System.Drawing.Size(60, 60);
            this.plr1Misses2.TabIndex = 14;
            this.plr1Misses2.TabStop = false;
            this.plr1Misses2.Visible = false;
            // 
            // plr1Misses3
            // 
            this.plr1Misses3.BackColor = System.Drawing.Color.Transparent;
            this.plr1Misses3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plr1Misses3.BackgroundImage")));
            this.plr1Misses3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plr1Misses3.Location = new System.Drawing.Point(149, 468);
            this.plr1Misses3.Name = "plr1Misses3";
            this.plr1Misses3.Size = new System.Drawing.Size(60, 60);
            this.plr1Misses3.TabIndex = 15;
            this.plr1Misses3.TabStop = false;
            this.plr1Misses3.Visible = false;
            // 
            // plr2Misses3
            // 
            this.plr2Misses3.BackColor = System.Drawing.Color.Transparent;
            this.plr2Misses3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plr2Misses3.BackgroundImage")));
            this.plr2Misses3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plr2Misses3.Location = new System.Drawing.Point(928, 468);
            this.plr2Misses3.Name = "plr2Misses3";
            this.plr2Misses3.Size = new System.Drawing.Size(60, 60);
            this.plr2Misses3.TabIndex = 16;
            this.plr2Misses3.TabStop = false;
            this.plr2Misses3.Visible = false;
            // 
            // plr2Misses2
            // 
            this.plr2Misses2.BackColor = System.Drawing.Color.Transparent;
            this.plr2Misses2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plr2Misses2.BackgroundImage")));
            this.plr2Misses2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plr2Misses2.Location = new System.Drawing.Point(862, 468);
            this.plr2Misses2.Name = "plr2Misses2";
            this.plr2Misses2.Size = new System.Drawing.Size(60, 60);
            this.plr2Misses2.TabIndex = 17;
            this.plr2Misses2.TabStop = false;
            this.plr2Misses2.Visible = false;
            // 
            // plr2Misses1
            // 
            this.plr2Misses1.BackColor = System.Drawing.Color.Transparent;
            this.plr2Misses1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plr2Misses1.BackgroundImage")));
            this.plr2Misses1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plr2Misses1.Location = new System.Drawing.Point(796, 468);
            this.plr2Misses1.Name = "plr2Misses1";
            this.plr2Misses1.Size = new System.Drawing.Size(60, 60);
            this.plr2Misses1.TabIndex = 18;
            this.plr2Misses1.TabStop = false;
            this.plr2Misses1.Visible = false;
            // 
            // gameOverBox
            // 
            this.gameOverBox.BackColor = System.Drawing.Color.Transparent;
            this.gameOverBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameOverBox.BackgroundImage")));
            this.gameOverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameOverBox.Location = new System.Drawing.Point(339, 101);
            this.gameOverBox.Name = "gameOverBox";
            this.gameOverBox.Size = new System.Drawing.Size(340, 60);
            this.gameOverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameOverBox.TabIndex = 20;
            this.gameOverBox.TabStop = false;
            this.gameOverBox.Visible = false;
            // 
            // continueBox
            // 
            this.continueBox.BackColor = System.Drawing.Color.Transparent;
            this.continueBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("continueBox.BackgroundImage")));
            this.continueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continueBox.Location = new System.Drawing.Point(131, 321);
            this.continueBox.Name = "continueBox";
            this.continueBox.Size = new System.Drawing.Size(750, 60);
            this.continueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.continueBox.TabIndex = 21;
            this.continueBox.TabStop = false;
            this.continueBox.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(12, 402);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(350, 60);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(641, 402);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(350, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // endGameTimer
            // 
            this.endGameTimer.Interval = 1000;
            this.endGameTimer.Tick += new System.EventHandler(this.endGameTimer_Tick);
            // 
            // yellowMole
            // 
            this.yellowMole.BackColor = System.Drawing.Color.Transparent;
            this.yellowMole.BackgroundImage = global::WhackAMole.Properties.Resources.Diglett;
            this.yellowMole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yellowMole.Location = new System.Drawing.Point(404, 48);
            this.yellowMole.Name = "yellowMole";
            this.yellowMole.Size = new System.Drawing.Size(214, 161);
            this.yellowMole.TabIndex = 24;
            this.yellowMole.TabStop = false;
            this.yellowMole.Visible = false;
            // 
            // redMole
            // 
            this.redMole.BackColor = System.Drawing.Color.Transparent;
            this.redMole.BackgroundImage = global::WhackAMole.Properties.Resources.Diglett;
            this.redMole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redMole.Location = new System.Drawing.Point(610, 119);
            this.redMole.Name = "redMole";
            this.redMole.Size = new System.Drawing.Size(214, 161);
            this.redMole.TabIndex = 25;
            this.redMole.TabStop = false;
            this.redMole.Visible = false;
            // 
            // greenMole
            // 
            this.greenMole.BackColor = System.Drawing.Color.Transparent;
            this.greenMole.BackgroundImage = global::WhackAMole.Properties.Resources.Diglett;
            this.greenMole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.greenMole.Location = new System.Drawing.Point(390, 220);
            this.greenMole.Name = "greenMole";
            this.greenMole.Size = new System.Drawing.Size(214, 161);
            this.greenMole.TabIndex = 26;
            this.greenMole.TabStop = false;
            this.greenMole.Visible = false;
            // 
            // blueMole
            // 
            this.blueMole.BackColor = System.Drawing.Color.Transparent;
            this.blueMole.BackgroundImage = global::WhackAMole.Properties.Resources.Diglett;
            this.blueMole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueMole.Location = new System.Drawing.Point(184, 129);
            this.blueMole.Name = "blueMole";
            this.blueMole.Size = new System.Drawing.Size(214, 161);
            this.blueMole.TabIndex = 27;
            this.blueMole.TabStop = false;
            this.blueMole.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.blueMole);
            this.Controls.Add(this.greenMole);
            this.Controls.Add(this.redMole);
            this.Controls.Add(this.yellowMole);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.continueBox);
            this.Controls.Add(this.gameOverBox);
            this.Controls.Add(this.plr2Misses1);
            this.Controls.Add(this.plr2Misses2);
            this.Controls.Add(this.plr2Misses3);
            this.Controls.Add(this.plr1Misses3);
            this.Controls.Add(this.plr1Misses2);
            this.Controls.Add(this.plr1Misses1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whack A Mole";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr1Misses1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr1Misses2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr1Misses3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr2Misses3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr2Misses2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plr2Misses1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.continueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowMole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redMole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenMole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueMole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox plr1Misses1;
        private System.Windows.Forms.PictureBox plr1Misses2;
        private System.Windows.Forms.PictureBox plr1Misses3;
        private System.Windows.Forms.PictureBox plr2Misses3;
        private System.Windows.Forms.PictureBox plr2Misses2;
        private System.Windows.Forms.PictureBox plr2Misses1;
        private System.Windows.Forms.PictureBox gameOverBox;
        private System.Windows.Forms.PictureBox continueBox;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer endGameTimer;
        private System.Windows.Forms.PictureBox yellowMole;
        private System.Windows.Forms.PictureBox redMole;
        private System.Windows.Forms.PictureBox greenMole;
        private System.Windows.Forms.PictureBox blueMole;
    }
}

