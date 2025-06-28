namespace WindowsFormsApp2
{
    partial class Customer
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
            this.Btn_view_my_order_history = new System.Windows.Forms.Button();
            this.Btn_view_my_order = new System.Windows.Forms.Button();
            this.Btn_cus_delete_account = new System.Windows.Forms.Button();
            this.Btn_cus_view_menu = new System.Windows.Forms.Button();
            this.Btn_Cus_Update_Info = new System.Windows.Forms.Button();
            this.Btn_Change_Pass = new System.Windows.Forms.Button();
            this.Btn_Log_out_staff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(31, 32);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 29);
            this.lbl_welcome.TabIndex = 2;
            // 
            // Btn_view_my_order_history
            // 
            this.Btn_view_my_order_history.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.View_my_order_history_Button_image;
            this.Btn_view_my_order_history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_view_my_order_history.Location = new System.Drawing.Point(409, 391);
            this.Btn_view_my_order_history.Name = "Btn_view_my_order_history";
            this.Btn_view_my_order_history.Size = new System.Drawing.Size(240, 140);
            this.Btn_view_my_order_history.TabIndex = 12;
            this.Btn_view_my_order_history.UseVisualStyleBackColor = true;
            this.Btn_view_my_order_history.Click += new System.EventHandler(this.Btn_view_my_order_history_Click);
            // 
            // Btn_view_my_order
            // 
            this.Btn_view_my_order.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.View_my_order_Button_image;
            this.Btn_view_my_order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_view_my_order.Location = new System.Drawing.Point(692, 222);
            this.Btn_view_my_order.Name = "Btn_view_my_order";
            this.Btn_view_my_order.Size = new System.Drawing.Size(240, 140);
            this.Btn_view_my_order.TabIndex = 11;
            this.Btn_view_my_order.UseVisualStyleBackColor = true;
            this.Btn_view_my_order.Click += new System.EventHandler(this.Btn_view_my_order_Click);
            // 
            // Btn_cus_delete_account
            // 
            this.Btn_cus_delete_account.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Delete_account_button_image;
            this.Btn_cus_delete_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cus_delete_account.Location = new System.Drawing.Point(692, 391);
            this.Btn_cus_delete_account.Name = "Btn_cus_delete_account";
            this.Btn_cus_delete_account.Size = new System.Drawing.Size(240, 140);
            this.Btn_cus_delete_account.TabIndex = 10;
            this.Btn_cus_delete_account.UseVisualStyleBackColor = true;
            this.Btn_cus_delete_account.Click += new System.EventHandler(this.Btn_cus_delete_account_Click);
            // 
            // Btn_cus_view_menu
            // 
            this.Btn_cus_view_menu.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.View_Menu_Button_image;
            this.Btn_cus_view_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_cus_view_menu.Location = new System.Drawing.Point(409, 222);
            this.Btn_cus_view_menu.Name = "Btn_cus_view_menu";
            this.Btn_cus_view_menu.Size = new System.Drawing.Size(240, 140);
            this.Btn_cus_view_menu.TabIndex = 9;
            this.Btn_cus_view_menu.UseVisualStyleBackColor = true;
            this.Btn_cus_view_menu.Click += new System.EventHandler(this.Btn_cus_view_menu_Click);
            // 
            // Btn_Cus_Update_Info
            // 
            this.Btn_Cus_Update_Info.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Update_Info_Button_image;
            this.Btn_Cus_Update_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Cus_Update_Info.Location = new System.Drawing.Point(692, 52);
            this.Btn_Cus_Update_Info.Name = "Btn_Cus_Update_Info";
            this.Btn_Cus_Update_Info.Size = new System.Drawing.Size(240, 140);
            this.Btn_Cus_Update_Info.TabIndex = 8;
            this.Btn_Cus_Update_Info.UseVisualStyleBackColor = true;
            this.Btn_Cus_Update_Info.Click += new System.EventHandler(this.Btn_Cus_Update_Info_Click);
            // 
            // Btn_Change_Pass
            // 
            this.Btn_Change_Pass.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Change_Password_Button_image;
            this.Btn_Change_Pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Change_Pass.Location = new System.Drawing.Point(409, 52);
            this.Btn_Change_Pass.Name = "Btn_Change_Pass";
            this.Btn_Change_Pass.Size = new System.Drawing.Size(240, 140);
            this.Btn_Change_Pass.TabIndex = 7;
            this.Btn_Change_Pass.UseVisualStyleBackColor = true;
            this.Btn_Change_Pass.Click += new System.EventHandler(this.Cus_Btn_change_pass);
            // 
            // Btn_Log_out_staff
            // 
            this.Btn_Log_out_staff.BackColor = System.Drawing.Color.Salmon;
            this.Btn_Log_out_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Log_out_staff.Location = new System.Drawing.Point(108, 484);
            this.Btn_Log_out_staff.Name = "Btn_Log_out_staff";
            this.Btn_Log_out_staff.Size = new System.Drawing.Size(150, 47);
            this.Btn_Log_out_staff.TabIndex = 31;
            this.Btn_Log_out_staff.Text = "LOG OUT";
            this.Btn_Log_out_staff.UseVisualStyleBackColor = false;
            this.Btn_Log_out_staff.Click += new System.EventHandler(this.Btn_Log_out_staff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "\"Logged in as CUSTOMER\"";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Good_food_good_life_text_image;
            this.pictureBox2.Location = new System.Drawing.Point(91, 336);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Design_picture_2;
            this.pictureBox1.Location = new System.Drawing.Point(63, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(975, 564);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Log_out_staff);
            this.Controls.Add(this.Btn_view_my_order_history);
            this.Controls.Add(this.Btn_view_my_order);
            this.Controls.Add(this.Btn_cus_delete_account);
            this.Controls.Add(this.Btn_cus_view_menu);
            this.Controls.Add(this.Btn_Cus_Update_Info);
            this.Controls.Add(this.Btn_Change_Pass);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button Btn_cus_delete_account;
        private System.Windows.Forms.Button Btn_cus_view_menu;
        private System.Windows.Forms.Button Btn_Cus_Update_Info;
        private System.Windows.Forms.Button Btn_Change_Pass;
        private System.Windows.Forms.Button Btn_view_my_order;
        private System.Windows.Forms.Button Btn_view_my_order_history;
        private System.Windows.Forms.Button Btn_Log_out_staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}