namespace WindowsFormsApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.welcometext1 = new System.Windows.Forms.Label();
            this.welcometext2 = new System.Windows.Forms.Label();
            this.lbl_un = new System.Windows.Forms.Label();
            this.textBoxUN = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.textboxpass = new System.Windows.Forms.TextBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.btnloginclear = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.lbldonotaccount = new System.Windows.Forms.Label();
            this.linklblCreateNow = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // welcometext1
            // 
            this.welcometext1.AutoSize = true;
            this.welcometext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometext1.Location = new System.Drawing.Point(562, 74);
            this.welcometext1.Name = "welcometext1";
            this.welcometext1.Size = new System.Drawing.Size(260, 51);
            this.welcometext1.TabIndex = 1;
            this.welcometext1.Text = "Welcome to";
            // 
            // welcometext2
            // 
            this.welcometext2.AutoSize = true;
            this.welcometext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometext2.Location = new System.Drawing.Point(484, 126);
            this.welcometext2.Name = "welcometext2";
            this.welcometext2.Size = new System.Drawing.Size(412, 51);
            this.welcometext2.TabIndex = 2;
            this.welcometext2.Text = "Bean and Bite Cafe";
            // 
            // lbl_un
            // 
            this.lbl_un.AutoSize = true;
            this.lbl_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_un.Location = new System.Drawing.Point(504, 225);
            this.lbl_un.Name = "lbl_un";
            this.lbl_un.Size = new System.Drawing.Size(130, 29);
            this.lbl_un.TabIndex = 3;
            this.lbl_un.Text = "Username:";
            // 
            // textBoxUN
            // 
            this.textBoxUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUN.Location = new System.Drawing.Point(640, 225);
            this.textBoxUN.Name = "textBoxUN";
            this.textBoxUN.Size = new System.Drawing.Size(229, 34);
            this.textBoxUN.TabIndex = 4;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(504, 283);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(126, 29);
            this.lblpass.TabIndex = 5;
            this.lblpass.Text = "Password:";
            // 
            // textboxpass
            // 
            this.textboxpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxpass.Location = new System.Drawing.Point(640, 283);
            this.textboxpass.Name = "textboxpass";
            this.textboxpass.Size = new System.Drawing.Size(229, 34);
            this.textboxpass.TabIndex = 6;
            this.textboxpass.UseSystemPasswordChar = true;
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(744, 334);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(125, 20);
            this.showPass.TabIndex = 7;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // btnloginclear
            // 
            this.btnloginclear.BackColor = System.Drawing.Color.Salmon;
            this.btnloginclear.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginclear.Location = new System.Drawing.Point(640, 324);
            this.btnloginclear.Name = "btnloginclear";
            this.btnloginclear.Size = new System.Drawing.Size(72, 37);
            this.btnloginclear.TabIndex = 8;
            this.btnloginclear.Text = "Clear";
            this.btnloginclear.UseVisualStyleBackColor = false;
            this.btnloginclear.Click += new System.EventHandler(this.btnloginclear_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(700, 387);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(79, 37);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // lbldonotaccount
            // 
            this.lbldonotaccount.AutoSize = true;
            this.lbldonotaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonotaccount.Location = new System.Drawing.Point(520, 468);
            this.lbldonotaccount.Name = "lbldonotaccount";
            this.lbldonotaccount.Size = new System.Drawing.Size(217, 25);
            this.lbldonotaccount.TabIndex = 10;
            this.lbldonotaccount.Text = "Don\'t have an account?";
            // 
            // linklblCreateNow
            // 
            this.linklblCreateNow.AutoSize = true;
            this.linklblCreateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblCreateNow.Location = new System.Drawing.Point(751, 468);
            this.linklblCreateNow.Name = "linklblCreateNow";
            this.linklblCreateNow.Size = new System.Drawing.Size(112, 25);
            this.linklblCreateNow.TabIndex = 11;
            this.linklblCreateNow.TabStop = true;
            this.linklblCreateNow.Text = "Create now";
            this.linklblCreateNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCreateNow_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Good_food_good_life_text_image1;
            this.pictureBox1.Location = new System.Drawing.Point(66, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApp2.Properties.Resources.logo2;
            this.logo.Location = new System.Drawing.Point(49, 71);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(366, 329);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(997, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linklblCreateNow);
            this.Controls.Add(this.lbldonotaccount);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.btnloginclear);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.textboxpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.textBoxUN);
            this.Controls.Add(this.lbl_un);
            this.Controls.Add(this.welcometext2);
            this.Controls.Add(this.welcometext1);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label welcometext1;
        private System.Windows.Forms.Label welcometext2;
        private System.Windows.Forms.Label lbl_un;
        private System.Windows.Forms.TextBox textBoxUN;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox textboxpass;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button btnloginclear;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label lbldonotaccount;
        private System.Windows.Forms.LinkLabel linklblCreateNow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

