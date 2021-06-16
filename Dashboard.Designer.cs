﻿
namespace BankAccounts
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnEveryday = new System.Windows.Forms.Button();
            this.btnOmni = new System.Windows.Forms.Button();
            this.btnInvestment = new System.Windows.Forms.Button();
            this.lblCheckAcc = new System.Windows.Forms.Label();
            this.lblBalEvery = new System.Windows.Forms.Label();
            this.lblEvery = new System.Windows.Forms.Label();
            this.lblInvestment = new System.Windows.Forms.Label();
            this.lblBalInv = new System.Windows.Forms.Label();
            this.lblOmni = new System.Windows.Forms.Label();
            this.lblBalOmni = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(162, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 152);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(311, 128);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(431, 42);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to BitBank!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(1064, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(521, 691);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(86, 31);
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "Logout!";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // btnEveryday
            // 
            this.btnEveryday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEveryday.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEveryday.ForeColor = System.Drawing.Color.White;
            this.btnEveryday.Location = new System.Drawing.Point(162, 445);
            this.btnEveryday.Name = "btnEveryday";
            this.btnEveryday.Size = new System.Drawing.Size(190, 98);
            this.btnEveryday.TabIndex = 8;
            this.btnEveryday.Text = "Everyday";
            this.btnEveryday.UseVisualStyleBackColor = false;
            this.btnEveryday.Click += new System.EventHandler(this.btnEveryday_Click);
            // 
            // btnOmni
            // 
            this.btnOmni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOmni.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmni.ForeColor = System.Drawing.Color.White;
            this.btnOmni.Location = new System.Drawing.Point(740, 445);
            this.btnOmni.Name = "btnOmni";
            this.btnOmni.Size = new System.Drawing.Size(190, 98);
            this.btnOmni.TabIndex = 9;
            this.btnOmni.Text = "Omni";
            this.btnOmni.UseVisualStyleBackColor = false;
            this.btnOmni.Click += new System.EventHandler(this.btnOmni_Click);
            // 
            // btnInvestment
            // 
            this.btnInvestment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInvestment.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestment.ForeColor = System.Drawing.Color.White;
            this.btnInvestment.Location = new System.Drawing.Point(455, 445);
            this.btnInvestment.Name = "btnInvestment";
            this.btnInvestment.Size = new System.Drawing.Size(190, 98);
            this.btnInvestment.TabIndex = 10;
            this.btnInvestment.Text = "Investment";
            this.btnInvestment.UseVisualStyleBackColor = false;
            this.btnInvestment.Click += new System.EventHandler(this.btnInvestment_Click);
            // 
            // lblCheckAcc
            // 
            this.lblCheckAcc.AutoSize = true;
            this.lblCheckAcc.Font = new System.Drawing.Font("Adobe Garamond Pro", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAcc.ForeColor = System.Drawing.Color.White;
            this.lblCheckAcc.Location = new System.Drawing.Point(414, 301);
            this.lblCheckAcc.Name = "lblCheckAcc";
            this.lblCheckAcc.Size = new System.Drawing.Size(335, 48);
            this.lblCheckAcc.TabIndex = 11;
            this.lblCheckAcc.Text = "Check your accounts!";
            // 
            // lblBalEvery
            // 
            this.lblBalEvery.AutoSize = true;
            this.lblBalEvery.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalEvery.ForeColor = System.Drawing.Color.White;
            this.lblBalEvery.Location = new System.Drawing.Point(176, 550);
            this.lblBalEvery.Name = "lblBalEvery";
            this.lblBalEvery.Size = new System.Drawing.Size(94, 31);
            this.lblBalEvery.TabIndex = 12;
            this.lblBalEvery.Text = "Balance:";
            // 
            // lblEvery
            // 
            this.lblEvery.AutoSize = true;
            this.lblEvery.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvery.ForeColor = System.Drawing.Color.White;
            this.lblEvery.Location = new System.Drawing.Point(269, 550);
            this.lblEvery.Name = "lblEvery";
            this.lblEvery.Size = new System.Drawing.Size(0, 31);
            this.lblEvery.TabIndex = 13;
            // 
            // lblInvestment
            // 
            this.lblInvestment.AutoSize = true;
            this.lblInvestment.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestment.ForeColor = System.Drawing.Color.White;
            this.lblInvestment.Location = new System.Drawing.Point(585, 550);
            this.lblInvestment.Name = "lblInvestment";
            this.lblInvestment.Size = new System.Drawing.Size(0, 31);
            this.lblInvestment.TabIndex = 15;
            // 
            // lblBalInv
            // 
            this.lblBalInv.AutoSize = true;
            this.lblBalInv.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalInv.ForeColor = System.Drawing.Color.White;
            this.lblBalInv.Location = new System.Drawing.Point(469, 550);
            this.lblBalInv.Name = "lblBalInv";
            this.lblBalInv.Size = new System.Drawing.Size(94, 31);
            this.lblBalInv.TabIndex = 14;
            this.lblBalInv.Text = "Balance:";
            // 
            // lblOmni
            // 
            this.lblOmni.AutoSize = true;
            this.lblOmni.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmni.ForeColor = System.Drawing.Color.White;
            this.lblOmni.Location = new System.Drawing.Point(847, 550);
            this.lblOmni.Name = "lblOmni";
            this.lblOmni.Size = new System.Drawing.Size(0, 31);
            this.lblOmni.TabIndex = 17;
            // 
            // lblBalOmni
            // 
            this.lblBalOmni.AutoSize = true;
            this.lblBalOmni.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalOmni.ForeColor = System.Drawing.Color.White;
            this.lblBalOmni.Location = new System.Drawing.Point(754, 550);
            this.lblBalOmni.Name = "lblBalOmni";
            this.lblBalOmni.Size = new System.Drawing.Size(94, 31);
            this.lblBalOmni.TabIndex = 16;
            this.lblBalOmni.Text = "Balance:";
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(991, 151);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(139, 34);
            this.lblClock.TabIndex = 18;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextChanged += new System.EventHandler(this.timer_tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTop.Controls.Add(this.lblClock);
            this.pnlTop.Controls.Add(this.pictureBox2);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Location = new System.Drawing.Point(-6, -4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1128, 223);
            this.pnlTop.TabIndex = 19;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1120, 759);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblOmni);
            this.Controls.Add(this.lblBalOmni);
            this.Controls.Add(this.lblInvestment);
            this.Controls.Add(this.lblBalInv);
            this.Controls.Add(this.lblEvery);
            this.Controls.Add(this.lblBalEvery);
            this.Controls.Add(this.lblCheckAcc);
            this.Controls.Add(this.btnInvestment);
            this.Controls.Add(this.btnOmni);
            this.Controls.Add(this.btnEveryday);
            this.Controls.Add(this.lblLogOut);
            this.Font = new System.Drawing.Font("Adobe Garamond Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1120, 759);
            this.MinimumSize = new System.Drawing.Size(1120, 759);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Button btnEveryday;
        private System.Windows.Forms.Button btnOmni;
        private System.Windows.Forms.Button btnInvestment;
        private System.Windows.Forms.Label lblCheckAcc;
        private System.Windows.Forms.Label lblBalEvery;
        private System.Windows.Forms.Label lblEvery;
        private System.Windows.Forms.Label lblInvestment;
        private System.Windows.Forms.Label lblBalInv;
        private System.Windows.Forms.Label lblOmni;
        private System.Windows.Forms.Label lblBalOmni;
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTop;
    }
}