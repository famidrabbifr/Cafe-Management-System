namespace WindowsFormsApp2
{
    partial class Add_item_staff
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
            this.rd_btn_coffee = new System.Windows.Forms.RadioButton();
            this.rd_btn_desserts = new System.Windows.Forms.RadioButton();
            this.rd_btn_salad = new System.Windows.Forms.RadioButton();
            this.rd_btn_main_dish = new System.Windows.Forms.RadioButton();
            this.rd_btn_breakfast = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_new_item_price = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.textBox_new_item_name = new System.Windows.Forms.TextBox();
            this.lbl_un = new System.Windows.Forms.Label();
            this.Btn_new_item_save = new System.Windows.Forms.Button();
            this.Need_new_itemname = new System.Windows.Forms.Label();
            this.need_new_item_price = new System.Windows.Forms.Label();
            this.btn_back_add_item = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_btn_coffee
            // 
            this.rd_btn_coffee.AutoSize = true;
            this.rd_btn_coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_coffee.Location = new System.Drawing.Point(439, 266);
            this.rd_btn_coffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_coffee.Name = "rd_btn_coffee";
            this.rd_btn_coffee.Size = new System.Drawing.Size(277, 33);
            this.rd_btn_coffee.TabIndex = 38;
            this.rd_btn_coffee.Text = "Coffee and Beverages";
            this.rd_btn_coffee.UseVisualStyleBackColor = true;
            // 
            // rd_btn_desserts
            // 
            this.rd_btn_desserts.AutoSize = true;
            this.rd_btn_desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_desserts.Location = new System.Drawing.Point(744, 219);
            this.rd_btn_desserts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_desserts.Name = "rd_btn_desserts";
            this.rd_btn_desserts.Size = new System.Drawing.Size(133, 33);
            this.rd_btn_desserts.TabIndex = 37;
            this.rd_btn_desserts.Text = "Desserts";
            this.rd_btn_desserts.UseVisualStyleBackColor = true;
            // 
            // rd_btn_salad
            // 
            this.rd_btn_salad.AutoSize = true;
            this.rd_btn_salad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_salad.Location = new System.Drawing.Point(439, 222);
            this.rd_btn_salad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_salad.Name = "rd_btn_salad";
            this.rd_btn_salad.Size = new System.Drawing.Size(226, 33);
            this.rd_btn_salad.TabIndex = 36;
            this.rd_btn_salad.Text = "Salads and Sides";
            this.rd_btn_salad.UseVisualStyleBackColor = true;
            // 
            // rd_btn_main_dish
            // 
            this.rd_btn_main_dish.AutoSize = true;
            this.rd_btn_main_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_main_dish.Location = new System.Drawing.Point(744, 179);
            this.rd_btn_main_dish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_main_dish.Name = "rd_btn_main_dish";
            this.rd_btn_main_dish.Size = new System.Drawing.Size(170, 33);
            this.rd_btn_main_dish.TabIndex = 35;
            this.rd_btn_main_dish.Text = "Main Dishes";
            this.rd_btn_main_dish.UseVisualStyleBackColor = true;
            // 
            // rd_btn_breakfast
            // 
            this.rd_btn_breakfast.AutoSize = true;
            this.rd_btn_breakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_breakfast.Location = new System.Drawing.Point(439, 179);
            this.rd_btn_breakfast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_breakfast.Name = "rd_btn_breakfast";
            this.rd_btn_breakfast.Size = new System.Drawing.Size(268, 33);
            this.rd_btn_breakfast.TabIndex = 34;
            this.rd_btn_breakfast.Text = "Breakfast and Snacks";
            this.rd_btn_breakfast.UseVisualStyleBackColor = true;
            this.rd_btn_breakfast.CheckedChanged += new System.EventHandler(this.rd_btn_breakfast_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "SELECT THE CATEGORY TO ADD THE ITEM:";
            // 
            // textbox_new_item_price
            // 
            this.textbox_new_item_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_new_item_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_new_item_price.Location = new System.Drawing.Point(600, 424);
            this.textbox_new_item_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_new_item_price.Name = "textbox_new_item_price";
            this.textbox_new_item_price.Size = new System.Drawing.Size(288, 37);
            this.textbox_new_item_price.TabIndex = 42;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(447, 426);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(141, 31);
            this.lblpass.TabIndex = 41;
            this.lblpass.Text = "Item price:";
            // 
            // textBox_new_item_name
            // 
            this.textBox_new_item_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_new_item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_new_item_name.Location = new System.Drawing.Point(600, 354);
            this.textBox_new_item_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_new_item_name.Name = "textBox_new_item_name";
            this.textBox_new_item_name.Size = new System.Drawing.Size(288, 37);
            this.textBox_new_item_name.TabIndex = 40;
            // 
            // lbl_un
            // 
            this.lbl_un.AutoSize = true;
            this.lbl_un.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_un.Location = new System.Drawing.Point(446, 354);
            this.lbl_un.Name = "lbl_un";
            this.lbl_un.Size = new System.Drawing.Size(149, 31);
            this.lbl_un.TabIndex = 39;
            this.lbl_un.Text = "Item name:";
            // 
            // Btn_new_item_save
            // 
            this.Btn_new_item_save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_new_item_save.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_new_item_save.Location = new System.Drawing.Point(775, 471);
            this.Btn_new_item_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_new_item_save.Name = "Btn_new_item_save";
            this.Btn_new_item_save.Size = new System.Drawing.Size(112, 45);
            this.Btn_new_item_save.TabIndex = 43;
            this.Btn_new_item_save.Text = "Save";
            this.Btn_new_item_save.UseVisualStyleBackColor = false;
            this.Btn_new_item_save.Click += new System.EventHandler(this.Btn_new_item_save_Click);
            // 
            // Need_new_itemname
            // 
            this.Need_new_itemname.AutoSize = true;
            this.Need_new_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need_new_itemname.ForeColor = System.Drawing.Color.Red;
            this.Need_new_itemname.Location = new System.Drawing.Point(902, 359);
            this.Need_new_itemname.Name = "Need_new_itemname";
            this.Need_new_itemname.Size = new System.Drawing.Size(0, 29);
            this.Need_new_itemname.TabIndex = 44;
            // 
            // need_new_item_price
            // 
            this.need_new_item_price.AutoSize = true;
            this.need_new_item_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.need_new_item_price.ForeColor = System.Drawing.Color.Red;
            this.need_new_item_price.Location = new System.Drawing.Point(902, 431);
            this.need_new_item_price.Name = "need_new_item_price";
            this.need_new_item_price.Size = new System.Drawing.Size(0, 29);
            this.need_new_item_price.TabIndex = 45;
            // 
            // btn_back_add_item
            // 
            this.btn_back_add_item.BackColor = System.Drawing.Color.Tomato;
            this.btn_back_add_item.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_add_item.Location = new System.Drawing.Point(775, 556);
            this.btn_back_add_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back_add_item.Name = "btn_back_add_item";
            this.btn_back_add_item.Size = new System.Drawing.Size(112, 45);
            this.btn_back_add_item.TabIndex = 46;
            this.btn_back_add_item.Text = "Back";
            this.btn_back_add_item.UseVisualStyleBackColor = false;
            this.btn_back_add_item.Click += new System.EventHandler(this.btn_back_add_item_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Design_picture_3;
            this.pictureBox1.Location = new System.Drawing.Point(55, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Add_item_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1034, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back_add_item);
            this.Controls.Add(this.need_new_item_price);
            this.Controls.Add(this.Need_new_itemname);
            this.Controls.Add(this.Btn_new_item_save);
            this.Controls.Add(this.textbox_new_item_price);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.textBox_new_item_name);
            this.Controls.Add(this.lbl_un);
            this.Controls.Add(this.rd_btn_coffee);
            this.Controls.Add(this.rd_btn_desserts);
            this.Controls.Add(this.rd_btn_salad);
            this.Controls.Add(this.rd_btn_main_dish);
            this.Controls.Add(this.rd_btn_breakfast);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_item_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_item_staff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_btn_coffee;
        private System.Windows.Forms.RadioButton rd_btn_desserts;
        private System.Windows.Forms.RadioButton rd_btn_salad;
        private System.Windows.Forms.RadioButton rd_btn_main_dish;
        private System.Windows.Forms.RadioButton rd_btn_breakfast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_new_item_price;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox textBox_new_item_name;
        private System.Windows.Forms.Label lbl_un;
        private System.Windows.Forms.Button Btn_new_item_save;
        private System.Windows.Forms.Label Need_new_itemname;
        private System.Windows.Forms.Label need_new_item_price;
        private System.Windows.Forms.Button btn_back_add_item;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}