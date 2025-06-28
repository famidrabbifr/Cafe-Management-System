namespace WindowsFormsApp2
{
    partial class Change_Password
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
            this.show_curr_Pass = new System.Windows.Forms.CheckBox();
            this.textBox_new_pass = new System.Windows.Forms.TextBox();
            this.textBox_current_pass = new System.Windows.Forms.TextBox();
            this.lbl_new_pass = new System.Windows.Forms.Label();
            this.lbl_Current_pass = new System.Windows.Forms.Label();
            this.show_new_pass = new System.Windows.Forms.CheckBox();
            this.lbl_confirm_pass = new System.Windows.Forms.Label();
            this.textBox_confirm_pass = new System.Windows.Forms.TextBox();
            this.show_confirm_pass = new System.Windows.Forms.CheckBox();
            this.btn_chnage_pass_clear = new System.Windows.Forms.Button();
            this.btn_change_pass_confirm = new System.Windows.Forms.Button();
            this.btn_change_pass_back = new System.Windows.Forms.Button();
            this.Need_Curr_pass = new System.Windows.Forms.Label();
            this.need_new_pass = new System.Windows.Forms.Label();
            this.need_confirm_pass = new System.Windows.Forms.Label();
            this.New_passErrorText1 = new System.Windows.Forms.Label();
            this.lbl_Confirm_passErorr = new System.Windows.Forms.Label();
            this.lbl_curr_pass_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // show_curr_Pass
            // 
            this.show_curr_Pass.AutoSize = true;
            this.show_curr_Pass.Location = new System.Drawing.Point(671, 167);
            this.show_curr_Pass.Name = "show_curr_Pass";
            this.show_curr_Pass.Size = new System.Drawing.Size(125, 20);
            this.show_curr_Pass.TabIndex = 29;
            this.show_curr_Pass.Text = "Show Password";
            this.show_curr_Pass.UseVisualStyleBackColor = true;
            this.show_curr_Pass.CheckedChanged += new System.EventHandler(this.show_curr_Pass_CheckedChanged);
            // 
            // textBox_new_pass
            // 
            this.textBox_new_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_new_pass.Location = new System.Drawing.Point(605, 212);
            this.textBox_new_pass.Name = "textBox_new_pass";
            this.textBox_new_pass.Size = new System.Drawing.Size(191, 27);
            this.textBox_new_pass.TabIndex = 28;
            this.textBox_new_pass.UseSystemPasswordChar = true;
            this.textBox_new_pass.TextChanged += new System.EventHandler(this.textBox_new_pass_TextChanged);
            // 
            // textBox_current_pass
            // 
            this.textBox_current_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_current_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_current_pass.Location = new System.Drawing.Point(605, 134);
            this.textBox_current_pass.Name = "textBox_current_pass";
            this.textBox_current_pass.Size = new System.Drawing.Size(191, 27);
            this.textBox_current_pass.TabIndex = 27;
            this.textBox_current_pass.UseSystemPasswordChar = true;
            this.textBox_current_pass.TextChanged += new System.EventHandler(this.textBox_current_pass_TextChanged);
            // 
            // lbl_new_pass
            // 
            this.lbl_new_pass.AutoSize = true;
            this.lbl_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_pass.Location = new System.Drawing.Point(331, 218);
            this.lbl_new_pass.Name = "lbl_new_pass";
            this.lbl_new_pass.Size = new System.Drawing.Size(156, 20);
            this.lbl_new_pass.TabIndex = 26;
            this.lbl_new_pass.Text = "NEW PASSWORD:";
            // 
            // lbl_Current_pass
            // 
            this.lbl_Current_pass.AutoSize = true;
            this.lbl_Current_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_pass.Location = new System.Drawing.Point(331, 136);
            this.lbl_Current_pass.Name = "lbl_Current_pass";
            this.lbl_Current_pass.Size = new System.Drawing.Size(250, 20);
            this.lbl_Current_pass.TabIndex = 25;
            this.lbl_Current_pass.Text = "YOUR CURRENT PASSWORD:";
            // 
            // show_new_pass
            // 
            this.show_new_pass.AutoSize = true;
            this.show_new_pass.Location = new System.Drawing.Point(671, 245);
            this.show_new_pass.Name = "show_new_pass";
            this.show_new_pass.Size = new System.Drawing.Size(125, 20);
            this.show_new_pass.TabIndex = 30;
            this.show_new_pass.Text = "Show Password";
            this.show_new_pass.UseVisualStyleBackColor = true;
            this.show_new_pass.CheckedChanged += new System.EventHandler(this.show_new_pass_CheckedChanged);
            // 
            // lbl_confirm_pass
            // 
            this.lbl_confirm_pass.AutoSize = true;
            this.lbl_confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm_pass.Location = new System.Drawing.Point(331, 285);
            this.lbl_confirm_pass.Name = "lbl_confirm_pass";
            this.lbl_confirm_pass.Size = new System.Drawing.Size(194, 20);
            this.lbl_confirm_pass.TabIndex = 31;
            this.lbl_confirm_pass.Text = "CONFIRM PASSWORD:";
            this.lbl_confirm_pass.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_confirm_pass
            // 
            this.textBox_confirm_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirm_pass.Location = new System.Drawing.Point(605, 283);
            this.textBox_confirm_pass.Name = "textBox_confirm_pass";
            this.textBox_confirm_pass.Size = new System.Drawing.Size(191, 27);
            this.textBox_confirm_pass.TabIndex = 32;
            this.textBox_confirm_pass.UseSystemPasswordChar = true;
            this.textBox_confirm_pass.TextChanged += new System.EventHandler(this.textBox_confirm_pass_TextChanged);
            // 
            // show_confirm_pass
            // 
            this.show_confirm_pass.AutoSize = true;
            this.show_confirm_pass.Location = new System.Drawing.Point(671, 316);
            this.show_confirm_pass.Name = "show_confirm_pass";
            this.show_confirm_pass.Size = new System.Drawing.Size(125, 20);
            this.show_confirm_pass.TabIndex = 33;
            this.show_confirm_pass.Text = "Show Password";
            this.show_confirm_pass.UseVisualStyleBackColor = true;
            this.show_confirm_pass.CheckedChanged += new System.EventHandler(this.show_confirm_pass_CheckedChanged);
            // 
            // btn_chnage_pass_clear
            // 
            this.btn_chnage_pass_clear.BackColor = System.Drawing.Color.Salmon;
            this.btn_chnage_pass_clear.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chnage_pass_clear.Location = new System.Drawing.Point(569, 358);
            this.btn_chnage_pass_clear.Name = "btn_chnage_pass_clear";
            this.btn_chnage_pass_clear.Size = new System.Drawing.Size(72, 37);
            this.btn_chnage_pass_clear.TabIndex = 34;
            this.btn_chnage_pass_clear.Text = "Clear";
            this.btn_chnage_pass_clear.UseVisualStyleBackColor = false;
            this.btn_chnage_pass_clear.Click += new System.EventHandler(this.btn_chnage_pass_clear_Click);
            // 
            // btn_change_pass_confirm
            // 
            this.btn_change_pass_confirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_change_pass_confirm.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_pass_confirm.Location = new System.Drawing.Point(615, 421);
            this.btn_change_pass_confirm.Name = "btn_change_pass_confirm";
            this.btn_change_pass_confirm.Size = new System.Drawing.Size(112, 37);
            this.btn_change_pass_confirm.TabIndex = 35;
            this.btn_change_pass_confirm.Text = "Confirm";
            this.btn_change_pass_confirm.UseVisualStyleBackColor = false;
            this.btn_change_pass_confirm.Click += new System.EventHandler(this.btn_change_pass_confirm_Click);
            // 
            // btn_change_pass_back
            // 
            this.btn_change_pass_back.BackColor = System.Drawing.Color.Salmon;
            this.btn_change_pass_back.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_pass_back.Location = new System.Drawing.Point(497, 421);
            this.btn_change_pass_back.Name = "btn_change_pass_back";
            this.btn_change_pass_back.Size = new System.Drawing.Size(112, 37);
            this.btn_change_pass_back.TabIndex = 36;
            this.btn_change_pass_back.Text = "Back";
            this.btn_change_pass_back.UseVisualStyleBackColor = false;
            this.btn_change_pass_back.Click += new System.EventHandler(this.btn_change_pass_back_Click);
            // 
            // Need_Curr_pass
            // 
            this.Need_Curr_pass.AutoSize = true;
            this.Need_Curr_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need_Curr_pass.ForeColor = System.Drawing.Color.Red;
            this.Need_Curr_pass.Location = new System.Drawing.Point(802, 136);
            this.Need_Curr_pass.Name = "Need_Curr_pass";
            this.Need_Curr_pass.Size = new System.Drawing.Size(0, 25);
            this.Need_Curr_pass.TabIndex = 37;
            // 
            // need_new_pass
            // 
            this.need_new_pass.AutoSize = true;
            this.need_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.need_new_pass.ForeColor = System.Drawing.Color.Red;
            this.need_new_pass.Location = new System.Drawing.Point(802, 214);
            this.need_new_pass.Name = "need_new_pass";
            this.need_new_pass.Size = new System.Drawing.Size(0, 25);
            this.need_new_pass.TabIndex = 38;
            // 
            // need_confirm_pass
            // 
            this.need_confirm_pass.AutoSize = true;
            this.need_confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.need_confirm_pass.ForeColor = System.Drawing.Color.Red;
            this.need_confirm_pass.Location = new System.Drawing.Point(802, 283);
            this.need_confirm_pass.Name = "need_confirm_pass";
            this.need_confirm_pass.Size = new System.Drawing.Size(0, 25);
            this.need_confirm_pass.TabIndex = 39;
            // 
            // New_passErrorText1
            // 
            this.New_passErrorText1.AutoSize = true;
            this.New_passErrorText1.ForeColor = System.Drawing.Color.Red;
            this.New_passErrorText1.Location = new System.Drawing.Point(394, 248);
            this.New_passErrorText1.Name = "New_passErrorText1";
            this.New_passErrorText1.Size = new System.Drawing.Size(0, 16);
            this.New_passErrorText1.TabIndex = 40;
            // 
            // lbl_Confirm_passErorr
            // 
            this.lbl_Confirm_passErorr.AutoSize = true;
            this.lbl_Confirm_passErorr.ForeColor = System.Drawing.Color.Red;
            this.lbl_Confirm_passErorr.Location = new System.Drawing.Point(423, 313);
            this.lbl_Confirm_passErorr.Name = "lbl_Confirm_passErorr";
            this.lbl_Confirm_passErorr.Size = new System.Drawing.Size(0, 16);
            this.lbl_Confirm_passErorr.TabIndex = 41;
            // 
            // lbl_curr_pass_error
            // 
            this.lbl_curr_pass_error.AutoSize = true;
            this.lbl_curr_pass_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_curr_pass_error.Location = new System.Drawing.Point(397, 166);
            this.lbl_curr_pass_error.Name = "lbl_curr_pass_error";
            this.lbl_curr_pass_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_curr_pass_error.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "\"Logged in as STAFF\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Design_picture_4;
            this.pictureBox1.Location = new System.Drawing.Point(37, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "CHANGE PASSWORD";
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(846, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_curr_pass_error);
            this.Controls.Add(this.lbl_Confirm_passErorr);
            this.Controls.Add(this.New_passErrorText1);
            this.Controls.Add(this.need_confirm_pass);
            this.Controls.Add(this.need_new_pass);
            this.Controls.Add(this.Need_Curr_pass);
            this.Controls.Add(this.btn_change_pass_back);
            this.Controls.Add(this.btn_change_pass_confirm);
            this.Controls.Add(this.btn_chnage_pass_clear);
            this.Controls.Add(this.show_confirm_pass);
            this.Controls.Add(this.textBox_confirm_pass);
            this.Controls.Add(this.lbl_confirm_pass);
            this.Controls.Add(this.show_new_pass);
            this.Controls.Add(this.show_curr_Pass);
            this.Controls.Add(this.textBox_new_pass);
            this.Controls.Add(this.textBox_current_pass);
            this.Controls.Add(this.lbl_new_pass);
            this.Controls.Add(this.lbl_Current_pass);
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox show_curr_Pass;
        private System.Windows.Forms.TextBox textBox_new_pass;
        private System.Windows.Forms.TextBox textBox_current_pass;
        private System.Windows.Forms.Label lbl_new_pass;
        private System.Windows.Forms.Label lbl_Current_pass;
        private System.Windows.Forms.CheckBox show_new_pass;
        private System.Windows.Forms.Label lbl_confirm_pass;
        private System.Windows.Forms.TextBox textBox_confirm_pass;
        private System.Windows.Forms.CheckBox show_confirm_pass;
        private System.Windows.Forms.Button btn_chnage_pass_clear;
        private System.Windows.Forms.Button btn_change_pass_confirm;
        private System.Windows.Forms.Button btn_change_pass_back;
        private System.Windows.Forms.Label Need_Curr_pass;
        private System.Windows.Forms.Label need_new_pass;
        private System.Windows.Forms.Label need_confirm_pass;
        private System.Windows.Forms.Label New_passErrorText1;
        private System.Windows.Forms.Label lbl_Confirm_passErorr;
        private System.Windows.Forms.Label lbl_curr_pass_error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}