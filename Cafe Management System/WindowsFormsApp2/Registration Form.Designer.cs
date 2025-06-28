namespace WindowsFormsApp2
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            this.textboxmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblpass_reg = new System.Windows.Forms.Label();
            this.lbl_un_reg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.textBox_UN = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxPassRetype = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.passErrorText1 = new System.Windows.Forms.Label();
            this.lblRetypepassErorr = new System.Windows.Forms.Label();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Need_name = new System.Windows.Forms.Label();
            this.Mail_need = new System.Windows.Forms.Label();
            this.Phone_need = new System.Windows.Forms.Label();
            this.Gender_need = new System.Windows.Forms.Label();
            this.Need_username = new System.Windows.Forms.Label();
            this.Need_pass = new System.Windows.Forms.Label();
            this.Need_RetypePass = new System.Windows.Forms.Label();
            this.Need_Role = new System.Windows.Forms.Label();
            this.lbl_username_error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxmail
            // 
            this.textboxmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textboxmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxmail.Location = new System.Drawing.Point(465, 132);
            this.textboxmail.Name = "textboxmail";
            this.textboxmail.Size = new System.Drawing.Size(299, 30);
            this.textboxmail.TabIndex = 10;
            this.textboxmail.TextChanged += new System.EventHandler(this.textboxmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(460, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // textBoxN
            // 
            this.textBoxN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxN.Location = new System.Drawing.Point(465, 65);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(299, 30);
            this.textBoxN.TabIndex = 8;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(460, 37);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 25);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(460, 174);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 25);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(460, 252);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // lblpass_reg
            // 
            this.lblpass_reg.AutoSize = true;
            this.lblpass_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass_reg.Location = new System.Drawing.Point(460, 353);
            this.lblpass_reg.Name = "lblpass_reg";
            this.lblpass_reg.Size = new System.Drawing.Size(104, 25);
            this.lblpass_reg.TabIndex = 14;
            this.lblpass_reg.Text = "Password:";
            // 
            // lbl_un_reg
            // 
            this.lbl_un_reg.AutoSize = true;
            this.lbl_un_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_un_reg.Location = new System.Drawing.Point(460, 282);
            this.lbl_un_reg.Name = "lbl_un_reg";
            this.lbl_un_reg.Size = new System.Drawing.Size(108, 25);
            this.lbl_un_reg.TabIndex = 13;
            this.lbl_un_reg.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Re-type Password:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(465, 202);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(299, 30);
            this.textBoxPhone.TabIndex = 16;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.Location = new System.Drawing.Point(563, 255);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(66, 24);
            this.radioButton_male.TabIndex = 17;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            this.radioButton_male.CheckedChanged += new System.EventHandler(this.radioButton_male_CheckedChanged);
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.Location = new System.Drawing.Point(679, 255);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(85, 24);
            this.radioButton_female.TabIndex = 18;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // textBox_UN
            // 
            this.textBox_UN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_UN.Location = new System.Drawing.Point(465, 314);
            this.textBox_UN.Name = "textBox_UN";
            this.textBox_UN.Size = new System.Drawing.Size(299, 30);
            this.textBox_UN.TabIndex = 19;
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(465, 381);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(299, 30);
            this.textBoxPass.TabIndex = 20;
            this.textBoxPass.UseSystemPasswordChar = true;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // textBoxPassRetype
            // 
            this.textBoxPassRetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassRetype.Location = new System.Drawing.Point(465, 458);
            this.textBoxPassRetype.Name = "textBoxPassRetype";
            this.textBoxPassRetype.Size = new System.Drawing.Size(299, 30);
            this.textBoxPassRetype.TabIndex = 21;
            this.textBoxPassRetype.UseSystemPasswordChar = true;
            this.textBoxPassRetype.TextChanged += new System.EventHandler(this.textBoxPassRetype_TextChanged);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Customer"});
            this.comboBoxRole.Location = new System.Drawing.Point(465, 536);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(299, 30);
            this.comboBoxRole.TabIndex = 22;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Create an account as:";
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(645, 492);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(125, 20);
            this.showPass.TabIndex = 24;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateAccountBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountBtn.Location = new System.Drawing.Point(585, 585);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(179, 36);
            this.CreateAccountBtn.TabIndex = 25;
            this.CreateAccountBtn.Text = "Create Account";
            this.CreateAccountBtn.UseVisualStyleBackColor = false;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(464, 236);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(0, 16);
            this.lblPhoneError.TabIndex = 26;
            // 
            // passErrorText1
            // 
            this.passErrorText1.AutoSize = true;
            this.passErrorText1.ForeColor = System.Drawing.Color.Red;
            this.passErrorText1.Location = new System.Drawing.Point(528, 415);
            this.passErrorText1.Name = "passErrorText1";
            this.passErrorText1.Size = new System.Drawing.Size(0, 16);
            this.passErrorText1.TabIndex = 27;
            // 
            // lblRetypepassErorr
            // 
            this.lblRetypepassErorr.AutoSize = true;
            this.lblRetypepassErorr.ForeColor = System.Drawing.Color.Red;
            this.lblRetypepassErorr.Location = new System.Drawing.Point(464, 491);
            this.lblRetypepassErorr.Name = "lblRetypepassErorr";
            this.lblRetypepassErorr.Size = new System.Drawing.Size(0, 16);
            this.lblRetypepassErorr.TabIndex = 28;
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Salmon;
            this.Btn_Back.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.Location = new System.Drawing.Point(40, 584);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(72, 37);
            this.Btn_Back.TabIndex = 29;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Need_name
            // 
            this.Need_name.AutoSize = true;
            this.Need_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need_name.ForeColor = System.Drawing.Color.Red;
            this.Need_name.Location = new System.Drawing.Point(770, 67);
            this.Need_name.Name = "Need_name";
            this.Need_name.Size = new System.Drawing.Size(0, 25);
            this.Need_name.TabIndex = 30;
            // 
            // Mail_need
            // 
            this.Mail_need.AutoSize = true;
            this.Mail_need.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_need.ForeColor = System.Drawing.Color.Red;
            this.Mail_need.Location = new System.Drawing.Point(770, 137);
            this.Mail_need.Name = "Mail_need";
            this.Mail_need.Size = new System.Drawing.Size(0, 25);
            this.Mail_need.TabIndex = 31;
            // 
            // Phone_need
            // 
            this.Phone_need.AutoSize = true;
            this.Phone_need.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_need.ForeColor = System.Drawing.Color.Red;
            this.Phone_need.Location = new System.Drawing.Point(770, 207);
            this.Phone_need.Name = "Phone_need";
            this.Phone_need.Size = new System.Drawing.Size(0, 25);
            this.Phone_need.TabIndex = 32;
            // 
            // Gender_need
            // 
            this.Gender_need.AutoSize = true;
            this.Gender_need.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_need.ForeColor = System.Drawing.Color.Red;
            this.Gender_need.Location = new System.Drawing.Point(770, 255);
            this.Gender_need.Name = "Gender_need";
            this.Gender_need.Size = new System.Drawing.Size(0, 25);
            this.Gender_need.TabIndex = 33;
            // 
            // Need_username
            // 
            this.Need_username.AutoSize = true;
            this.Need_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need_username.ForeColor = System.Drawing.Color.Red;
            this.Need_username.Location = new System.Drawing.Point(770, 316);
            this.Need_username.Name = "Need_username";
            this.Need_username.Size = new System.Drawing.Size(0, 25);
            this.Need_username.TabIndex = 34;
            // 
            // Need_pass
            // 
            this.Need_pass.AutoSize = true;
            this.Need_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need_pass.ForeColor = System.Drawing.Color.Red;
            this.Need_pass.Location = new System.Drawing.Point(770, 383);
            this.Need_pass.Name = "Need_pass";
            this.Need_pass.Size = new System.Drawing.Size(0, 25);
            this.Need_pass.TabIndex = 35;
            // 
            // Need_RetypePass
            // 
            this.Need_RetypePass.AutoSize = true;
            this.Need_RetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need_RetypePass.ForeColor = System.Drawing.Color.Red;
            this.Need_RetypePass.Location = new System.Drawing.Point(770, 463);
            this.Need_RetypePass.Name = "Need_RetypePass";
            this.Need_RetypePass.Size = new System.Drawing.Size(0, 25);
            this.Need_RetypePass.TabIndex = 36;
            // 
            // Need_Role
            // 
            this.Need_Role.AutoSize = true;
            this.Need_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need_Role.ForeColor = System.Drawing.Color.Red;
            this.Need_Role.Location = new System.Drawing.Point(770, 541);
            this.Need_Role.Name = "Need_Role";
            this.Need_Role.Size = new System.Drawing.Size(0, 25);
            this.Need_Role.TabIndex = 37;
            // 
            // lbl_username_error
            // 
            this.lbl_username_error.AutoSize = true;
            this.lbl_username_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_username_error.Location = new System.Drawing.Point(582, 347);
            this.lbl_username_error.Name = "lbl_username_error";
            this.lbl_username_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_username_error.TabIndex = 38;
            this.lbl_username_error.Visible = false;
            this.lbl_username_error.Click += new System.EventHandler(this.lbl_username_error_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Good_food_good_life_text_image2;
            this.pictureBox1.Location = new System.Drawing.Point(72, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApp2.Properties.Resources.logo2;
            this.logo.Location = new System.Drawing.Point(40, 50);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(372, 343);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(842, 643);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_username_error);
            this.Controls.Add(this.Need_Role);
            this.Controls.Add(this.Need_RetypePass);
            this.Controls.Add(this.Need_pass);
            this.Controls.Add(this.Need_username);
            this.Controls.Add(this.Gender_need);
            this.Controls.Add(this.Phone_need);
            this.Controls.Add(this.Mail_need);
            this.Controls.Add(this.Need_name);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.lblRetypepassErorr);
            this.Controls.Add(this.passErrorText1);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxPassRetype);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBox_UN);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpass_reg);
            this.Controls.Add(this.lbl_un_reg);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textboxmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration_Form";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox textboxmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblpass_reg;
        private System.Windows.Forms.Label lbl_un_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_UN;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxPassRetype;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button CreateAccountBtn;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label passErrorText1;
        private System.Windows.Forms.Label lblRetypepassErorr;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label Need_name;
        private System.Windows.Forms.Label Mail_need;
        private System.Windows.Forms.Label Phone_need;
        private System.Windows.Forms.Label Gender_need;
        private System.Windows.Forms.Label Need_username;
        private System.Windows.Forms.Label Need_pass;
        private System.Windows.Forms.Label Need_RetypePass;
        private System.Windows.Forms.Label Need_Role;
        private System.Windows.Forms.Label lbl_username_error;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}