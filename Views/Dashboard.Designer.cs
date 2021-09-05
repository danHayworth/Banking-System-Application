
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
            this.lblCheckAcc = new System.Windows.Forms.Label();
            this.lblBalEvery = new System.Windows.Forms.Label();
            this.lblEvery = new System.Windows.Forms.Label();
            this.lblOmni = new System.Windows.Forms.Label();
            this.lblBalOmni = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCustomerLogged = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.aFooter = new System.Windows.Forms.LinkLabel();
            this.btnAddAccounts = new System.Windows.Forms.Button();
            this.btnInvestment = new System.Windows.Forms.Button();
            this.lblBalInv = new System.Windows.Forms.Label();
            this.lblInvestment = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlInvestment = new System.Windows.Forms.Panel();
            this.pnlEveryday = new System.Windows.Forms.Panel();
            this.pnlOmni = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlInvestment.SuspendLayout();
            this.pnlEveryday.SuspendLayout();
            this.pnlOmni.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(29, 37);
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
            this.lblWelcome.Location = new System.Drawing.Point(178, 128);
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
            this.lblLogOut.Location = new System.Drawing.Point(1026, 76);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(86, 31);
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "Logout!";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // btnEveryday
            // 
            this.btnEveryday.AccessibleName = "";
            this.btnEveryday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEveryday.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEveryday.ForeColor = System.Drawing.Color.White;
            this.btnEveryday.Location = new System.Drawing.Point(48, 40);
            this.btnEveryday.Name = "btnEveryday";
            this.btnEveryday.Size = new System.Drawing.Size(190, 98);
            this.btnEveryday.TabIndex = 8;
            this.btnEveryday.Text = "Everyday";
            this.btnEveryday.UseVisualStyleBackColor = false;
            this.btnEveryday.Click += new System.EventHandler(this.btnEveryday_Click);
            // 
            // btnOmni
            // 
            this.btnOmni.AccessibleName = "";
            this.btnOmni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOmni.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOmni.ForeColor = System.Drawing.Color.White;
            this.btnOmni.Location = new System.Drawing.Point(40, 39);
            this.btnOmni.Name = "btnOmni";
            this.btnOmni.Size = new System.Drawing.Size(190, 98);
            this.btnOmni.TabIndex = 9;
            this.btnOmni.Text = "Omni";
            this.btnOmni.UseVisualStyleBackColor = false;
            this.btnOmni.Click += new System.EventHandler(this.btnOmni_Click);
            // 
            // lblCheckAcc
            // 
            this.lblCheckAcc.AutoSize = true;
            this.lblCheckAcc.Font = new System.Drawing.Font("Adobe Garamond Pro", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAcc.ForeColor = System.Drawing.Color.White;
            this.lblCheckAcc.Location = new System.Drawing.Point(159, 351);
            this.lblCheckAcc.Name = "lblCheckAcc";
            this.lblCheckAcc.Size = new System.Drawing.Size(318, 42);
            this.lblCheckAcc.TabIndex = 11;
            this.lblCheckAcc.Text = "Here are your accounts:";
            // 
            // lblBalEvery
            // 
            this.lblBalEvery.AccessibleName = "";
            this.lblBalEvery.AutoSize = true;
            this.lblBalEvery.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalEvery.ForeColor = System.Drawing.Color.White;
            this.lblBalEvery.Location = new System.Drawing.Point(42, 160);
            this.lblBalEvery.Name = "lblBalEvery";
            this.lblBalEvery.Size = new System.Drawing.Size(94, 31);
            this.lblBalEvery.TabIndex = 12;
            this.lblBalEvery.Text = "Balance:";
            // 
            // lblEvery
            // 
            this.lblEvery.AccessibleName = "";
            this.lblEvery.AutoSize = true;
            this.lblEvery.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvery.ForeColor = System.Drawing.Color.White;
            this.lblEvery.Location = new System.Drawing.Point(176, 160);
            this.lblEvery.Name = "lblEvery";
            this.lblEvery.Size = new System.Drawing.Size(26, 31);
            this.lblEvery.TabIndex = 13;
            this.lblEvery.Text = "0";
            this.lblEvery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOmni
            // 
            this.lblOmni.AccessibleName = "";
            this.lblOmni.AutoSize = true;
            this.lblOmni.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmni.ForeColor = System.Drawing.Color.White;
            this.lblOmni.Location = new System.Drawing.Point(166, 159);
            this.lblOmni.Name = "lblOmni";
            this.lblOmni.Size = new System.Drawing.Size(26, 31);
            this.lblOmni.TabIndex = 17;
            this.lblOmni.Text = "0";
            this.lblOmni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalOmni
            // 
            this.lblBalOmni.AccessibleName = "";
            this.lblBalOmni.AutoSize = true;
            this.lblBalOmni.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalOmni.ForeColor = System.Drawing.Color.White;
            this.lblBalOmni.Location = new System.Drawing.Point(34, 159);
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
            this.pnlTop.Controls.Add(this.lblCustomerLogged);
            this.pnlTop.Controls.Add(this.lblClock);
            this.pnlTop.Controls.Add(this.pictureBox2);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblLogOut);
            this.pnlTop.Location = new System.Drawing.Point(-6, -4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1128, 223);
            this.pnlTop.TabIndex = 19;
            // 
            // lblCustomerLogged
            // 
            this.lblCustomerLogged.AutoSize = true;
            this.lblCustomerLogged.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLogged.ForeColor = System.Drawing.Color.White;
            this.lblCustomerLogged.Location = new System.Drawing.Point(179, 76);
            this.lblCustomerLogged.Name = "lblCustomerLogged";
            this.lblCustomerLogged.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomerLogged.Size = new System.Drawing.Size(152, 42);
            this.lblCustomerLogged.TabIndex = 19;
            this.lblCustomerLogged.Text = "Hello  ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.AccessibleName = "";
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(125, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 43);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.AccessibleName = "";
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(115, 148);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 44);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // aFooter
            // 
            this.aFooter.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.aFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aFooter.AutoSize = true;
            this.aFooter.Font = new System.Drawing.Font("Adobe Garamond Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aFooter.LinkColor = System.Drawing.Color.Snow;
            this.aFooter.Location = new System.Drawing.Point(390, 712);
            this.aFooter.Name = "aFooter";
            this.aFooter.Size = new System.Drawing.Size(366, 22);
            this.aFooter.TabIndex = 33;
            this.aFooter.TabStop = true;
            this.aFooter.Text = "© 2021 Banking System developed by Dan Hayworth";
            this.aFooter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.aFooter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aFooter_LinkClicked);
            // 
            // btnAddAccounts
            // 
            this.btnAddAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAccounts.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccounts.ForeColor = System.Drawing.Color.White;
            this.btnAddAccounts.Location = new System.Drawing.Point(918, 260);
            this.btnAddAccounts.Name = "btnAddAccounts";
            this.btnAddAccounts.Size = new System.Drawing.Size(187, 57);
            this.btnAddAccounts.TabIndex = 49;
            this.btnAddAccounts.Text = "Add account";
            this.btnAddAccounts.UseVisualStyleBackColor = false;
            this.btnAddAccounts.Visible = false;
            this.btnAddAccounts.Click += new System.EventHandler(this.btnAddAccounts_Click);
            // 
            // btnInvestment
            // 
            this.btnInvestment.AccessibleName = "";
            this.btnInvestment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInvestment.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestment.ForeColor = System.Drawing.Color.White;
            this.btnInvestment.Location = new System.Drawing.Point(40, 40);
            this.btnInvestment.Name = "btnInvestment";
            this.btnInvestment.Size = new System.Drawing.Size(190, 98);
            this.btnInvestment.TabIndex = 10;
            this.btnInvestment.Text = "Investment";
            this.btnInvestment.UseVisualStyleBackColor = false;
            this.btnInvestment.Click += new System.EventHandler(this.btnInvestment_Click);
            // 
            // lblBalInv
            // 
            this.lblBalInv.AccessibleName = "";
            this.lblBalInv.AutoSize = true;
            this.lblBalInv.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalInv.ForeColor = System.Drawing.Color.White;
            this.lblBalInv.Location = new System.Drawing.Point(34, 160);
            this.lblBalInv.Name = "lblBalInv";
            this.lblBalInv.Size = new System.Drawing.Size(94, 31);
            this.lblBalInv.TabIndex = 14;
            this.lblBalInv.Text = "Balance:";
            // 
            // lblInvestment
            // 
            this.lblInvestment.AccessibleName = "";
            this.lblInvestment.AutoSize = true;
            this.lblInvestment.Font = new System.Drawing.Font("Adobe Garamond Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestment.ForeColor = System.Drawing.Color.White;
            this.lblInvestment.Location = new System.Drawing.Point(169, 160);
            this.lblInvestment.Name = "lblInvestment";
            this.lblInvestment.Size = new System.Drawing.Size(26, 31);
            this.lblInvestment.TabIndex = 15;
            this.lblInvestment.Text = "0";
            this.lblInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.AccessibleName = "";
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(118, 149);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 44);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pnlInvestment
            // 
            this.pnlInvestment.Controls.Add(this.pictureBox5);
            this.pnlInvestment.Controls.Add(this.lblInvestment);
            this.pnlInvestment.Controls.Add(this.lblBalInv);
            this.pnlInvestment.Controls.Add(this.btnInvestment);
            this.pnlInvestment.Location = new System.Drawing.Point(440, 405);
            this.pnlInvestment.Name = "pnlInvestment";
            this.pnlInvestment.Size = new System.Drawing.Size(267, 225);
            this.pnlInvestment.TabIndex = 50;
            this.pnlInvestment.Visible = false;
            // 
            // pnlEveryday
            // 
            this.pnlEveryday.Controls.Add(this.pictureBox3);
            this.pnlEveryday.Controls.Add(this.lblEvery);
            this.pnlEveryday.Controls.Add(this.lblBalEvery);
            this.pnlEveryday.Controls.Add(this.btnEveryday);
            this.pnlEveryday.Location = new System.Drawing.Point(118, 405);
            this.pnlEveryday.Name = "pnlEveryday";
            this.pnlEveryday.Size = new System.Drawing.Size(276, 224);
            this.pnlEveryday.TabIndex = 51;
            this.pnlEveryday.Visible = false;
            // 
            // pnlOmni
            // 
            this.pnlOmni.Controls.Add(this.pictureBox4);
            this.pnlOmni.Controls.Add(this.lblOmni);
            this.pnlOmni.Controls.Add(this.lblBalOmni);
            this.pnlOmni.Controls.Add(this.btnOmni);
            this.pnlOmni.Location = new System.Drawing.Point(751, 406);
            this.pnlOmni.Name = "pnlOmni";
            this.pnlOmni.Size = new System.Drawing.Size(277, 223);
            this.pnlOmni.TabIndex = 52;
            this.pnlOmni.Visible = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1120, 759);
            this.Controls.Add(this.pnlOmni);
            this.Controls.Add(this.pnlEveryday);
            this.Controls.Add(this.pnlInvestment);
            this.Controls.Add(this.btnAddAccounts);
            this.Controls.Add(this.aFooter);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblCheckAcc);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlInvestment.ResumeLayout(false);
            this.pnlInvestment.PerformLayout();
            this.pnlEveryday.ResumeLayout(false);
            this.pnlEveryday.PerformLayout();
            this.pnlOmni.ResumeLayout(false);
            this.pnlOmni.PerformLayout();
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
        private System.Windows.Forms.Label lblCheckAcc;
        private System.Windows.Forms.Label lblBalEvery;
        private System.Windows.Forms.Label lblEvery;
        private System.Windows.Forms.Label lblOmni;
        private System.Windows.Forms.Label lblBalOmni;
        private System.Windows.Forms.Label lblClock;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.LinkLabel aFooter;
        private System.Windows.Forms.Label lblCustomerLogged;
        private System.Windows.Forms.Button btnAddAccounts;
        private System.Windows.Forms.Button btnInvestment;
        private System.Windows.Forms.Label lblBalInv;
        private System.Windows.Forms.Label lblInvestment;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlInvestment;
        private System.Windows.Forms.Panel pnlEveryday;
        private System.Windows.Forms.Panel pnlOmni;
    }
}