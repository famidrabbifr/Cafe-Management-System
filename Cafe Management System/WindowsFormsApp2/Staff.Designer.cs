namespace WindowsFormsApp2
{
    partial class Staff
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Log_out_staff = new System.Windows.Forms.Button();
            this.View_order_history = new System.Windows.Forms.Button();
            this.Btn_view_current_order = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_delete_account = new System.Windows.Forms.Button();
            this.Btn_view_menu = new System.Windows.Forms.Button();
            this.Btn_Update_Info = new System.Windows.Forms.Button();
            this.Btn_Change_Pass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(26, 17);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 29);
            this.lbl_welcome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "\"Logged in as STAFF\"";
            // 
            // Btn_Log_out_staff
            // 
            this.Btn_Log_out_staff.BackColor = System.Drawing.Color.Salmon;
            this.Btn_Log_out_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Log_out_staff.Location = new System.Drawing.Point(88, 459);
            this.Btn_Log_out_staff.Name = "Btn_Log_out_staff";
            this.Btn_Log_out_staff.Size = new System.Drawing.Size(150, 47);
            this.Btn_Log_out_staff.TabIndex = 30;
            this.Btn_Log_out_staff.Text = "LOG OUT";
            this.Btn_Log_out_staff.UseVisualStyleBackColor = false;
            this.Btn_Log_out_staff.Click += new System.EventHandler(this.Btn_Log_out_staff_Click);
            // 
            // View_order_history
            // 
            this.View_order_history.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.View_Order_histtory_button;
            this.View_order_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.View_order_history.Location = new System.Drawing.Point(335, 374);
            this.View_order_history.Name = "View_order_history";
            this.View_order_history.Size = new System.Drawing.Size(240, 140);
            this.View_order_history.TabIndex = 32;
            this.View_order_history.UseVisualStyleBackColor = true;
            this.View_order_history.Click += new System.EventHandler(this.View_order_history_Click);
            // 
            // Btn_view_current_order
            // 
            this.Btn_view_current_order.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.View_staff_current_order_image_Button;
            this.Btn_view_current_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_view_current_order.Location = new System.Drawing.Point(618, 208);
            this.Btn_view_current_order.Name = "Btn_view_current_order";
            this.Btn_view_current_order.Size = new System.Drawing.Size(240, 140);
            this.Btn_view_current_order.TabIndex = 31;
            this.Btn_view_current_order.UseVisualStyleBackColor = true;
            this.Btn_view_current_order.Click += new System.EventHandler(this.Btn_view_current_order_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Good_food_good_life_text_image;
            this.pictureBox2.Location = new System.Drawing.Point(75, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Design_picture_2;
            this.pictureBox1.Location = new System.Drawing.Point(53, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_delete_account
            // 
            this.Btn_delete_account.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Delete_account_button_image;
            this.Btn_delete_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_delete_account.Location = new System.Drawing.Point(618, 374);
            this.Btn_delete_account.Name = "Btn_delete_account";
            this.Btn_delete_account.Size = new System.Drawing.Size(240, 140);
            this.Btn_delete_account.TabIndex = 6;
            this.Btn_delete_account.UseVisualStyleBackColor = true;
            this.Btn_delete_account.Click += new System.EventHandler(this.Btn_delete_account_Click);
            // 
            // Btn_view_menu
            // 
            this.Btn_view_menu.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.View_Menu_Button_image;
            this.Btn_view_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_view_menu.Location = new System.Drawing.Point(335, 208);
            this.Btn_view_menu.Name = "Btn_view_menu";
            this.Btn_view_menu.Size = new System.Drawing.Size(240, 140);
            this.Btn_view_menu.TabIndex = 5;
            this.Btn_view_menu.UseVisualStyleBackColor = true;
            this.Btn_view_menu.Click += new System.EventHandler(this.Btn_view_menu_Click);
            // 
            // Btn_Update_Info
            // 
            this.Btn_Update_Info.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Update_Info_Button_image;
            this.Btn_Update_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Update_Info.Location = new System.Drawing.Point(618, 38);
            this.Btn_Update_Info.Name = "Btn_Update_Info";
            this.Btn_Update_Info.Size = new System.Drawing.Size(240, 140);
            this.Btn_Update_Info.TabIndex = 4;
            this.Btn_Update_Info.UseVisualStyleBackColor = true;
            this.Btn_Update_Info.Click += new System.EventHandler(this.Btn_Update_Info_Click);
            // 
            // Btn_Change_Pass
            // 
            this.Btn_Change_Pass.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Change_Password_Button_image;
            this.Btn_Change_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Change_Pass.Location = new System.Drawing.Point(335, 38);
            this.Btn_Change_Pass.Name = "Btn_Change_Pass";
            this.Btn_Change_Pass.Size = new System.Drawing.Size(240, 140);
            this.Btn_Change_Pass.TabIndex = 3;
            this.Btn_Change_Pass.UseVisualStyleBackColor = true;
            this.Btn_Change_Pass.Click += new System.EventHandler(this.Btn_Change_Pass_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(907, 543);
            this.Controls.Add(this.View_order_history);
            this.Controls.Add(this.Btn_view_current_order);
            this.Controls.Add(this.Btn_Log_out_staff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_delete_account);
            this.Controls.Add(this.Btn_view_menu);
            this.Controls.Add(this.Btn_Update_Info);
            this.Controls.Add(this.Btn_Change_Pass);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button Btn_Change_Pass;
        private System.Windows.Forms.Button Btn_Update_Info;
        private System.Windows.Forms.Button Btn_view_menu;
        private System.Windows.Forms.Button Btn_delete_account;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Log_out_staff;
        private System.Windows.Forms.Button Btn_view_current_order;
        private System.Windows.Forms.Button View_order_history;
    }
}