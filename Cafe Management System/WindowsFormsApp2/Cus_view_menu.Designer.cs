namespace WindowsFormsApp2
{
    partial class Cus_view_menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rd_btn_coffee = new System.Windows.Forms.RadioButton();
            this.rd_btn_desserts = new System.Windows.Forms.RadioButton();
            this.rd_btn_salad = new System.Windows.Forms.RadioButton();
            this.rd_btn_main_dish = new System.Windows.Forms.RadioButton();
            this.rd_btn_breakfast = new System.Windows.Forms.RadioButton();
            this.textBox_item_search = new System.Windows.Forms.TextBox();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_selected_items = new System.Windows.Forms.DataGridView();
            this.Btn_select_item = new System.Windows.Forms.Button();
            this.Btn_remove_item = new System.Windows.Forms.Button();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.textBox_total_price = new System.Windows.Forms.TextBox();
            this.Btn_confirm_order = new System.Windows.Forms.Button();
            this.Btn_cancel_order = new System.Windows.Forms.Button();
            this.btn_back_cus_view_menu = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selected_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rd_btn_coffee
            // 
            this.rd_btn_coffee.AutoSize = true;
            this.rd_btn_coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_coffee.Location = new System.Drawing.Point(68, 201);
            this.rd_btn_coffee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_coffee.Name = "rd_btn_coffee";
            this.rd_btn_coffee.Size = new System.Drawing.Size(277, 33);
            this.rd_btn_coffee.TabIndex = 41;
            this.rd_btn_coffee.Text = "Coffee and Beverages";
            this.rd_btn_coffee.UseVisualStyleBackColor = true;
            this.rd_btn_coffee.CheckedChanged += new System.EventHandler(this.rd_btn_coffee_CheckedChanged);
            // 
            // rd_btn_desserts
            // 
            this.rd_btn_desserts.AutoSize = true;
            this.rd_btn_desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_desserts.Location = new System.Drawing.Point(372, 154);
            this.rd_btn_desserts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_desserts.Name = "rd_btn_desserts";
            this.rd_btn_desserts.Size = new System.Drawing.Size(133, 33);
            this.rd_btn_desserts.TabIndex = 40;
            this.rd_btn_desserts.Text = "Desserts";
            this.rd_btn_desserts.UseVisualStyleBackColor = true;
            this.rd_btn_desserts.CheckedChanged += new System.EventHandler(this.rd_btn_desserts_CheckedChanged);
            // 
            // rd_btn_salad
            // 
            this.rd_btn_salad.AutoSize = true;
            this.rd_btn_salad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_salad.Location = new System.Drawing.Point(68, 158);
            this.rd_btn_salad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_salad.Name = "rd_btn_salad";
            this.rd_btn_salad.Size = new System.Drawing.Size(226, 33);
            this.rd_btn_salad.TabIndex = 39;
            this.rd_btn_salad.Text = "Salads and Sides";
            this.rd_btn_salad.UseVisualStyleBackColor = true;
            this.rd_btn_salad.CheckedChanged += new System.EventHandler(this.rd_btn_salad_CheckedChanged);
            // 
            // rd_btn_main_dish
            // 
            this.rd_btn_main_dish.AutoSize = true;
            this.rd_btn_main_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_main_dish.Location = new System.Drawing.Point(372, 114);
            this.rd_btn_main_dish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_main_dish.Name = "rd_btn_main_dish";
            this.rd_btn_main_dish.Size = new System.Drawing.Size(170, 33);
            this.rd_btn_main_dish.TabIndex = 38;
            this.rd_btn_main_dish.Text = "Main Dishes";
            this.rd_btn_main_dish.UseVisualStyleBackColor = true;
            this.rd_btn_main_dish.CheckedChanged += new System.EventHandler(this.rd_btn_main_dish_CheckedChanged);
            // 
            // rd_btn_breakfast
            // 
            this.rd_btn_breakfast.AutoSize = true;
            this.rd_btn_breakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_breakfast.Location = new System.Drawing.Point(68, 114);
            this.rd_btn_breakfast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd_btn_breakfast.Name = "rd_btn_breakfast";
            this.rd_btn_breakfast.Size = new System.Drawing.Size(268, 33);
            this.rd_btn_breakfast.TabIndex = 37;
            this.rd_btn_breakfast.Text = "Breakfast and Snacks";
            this.rd_btn_breakfast.UseVisualStyleBackColor = true;
            this.rd_btn_breakfast.CheckedChanged += new System.EventHandler(this.rd_btn_breakfast_CheckedChanged);
            // 
            // textBox_item_search
            // 
            this.textBox_item_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_item_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_item_search.Location = new System.Drawing.Point(243, 250);
            this.textBox_item_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_item_search.Name = "textBox_item_search";
            this.textBox_item_search.Size = new System.Drawing.Size(275, 35);
            this.textBox_item_search.TabIndex = 35;
            this.textBox_item_search.TabStop = false;
            this.textBox_item_search.TextChanged += new System.EventHandler(this.textBox_item_search_TextChanged);
            // 
            // dataGridView_Category
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Category.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Category.Location = new System.Drawing.Point(55, 294);
            this.dataGridView_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.ReadOnly = true;
            this.dataGridView_Category.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Category.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Category.RowTemplate.Height = 24;
            this.dataGridView_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Category.Size = new System.Drawing.Size(464, 284);
            this.dataGridView_Category.TabIndex = 34;
            this.dataGridView_Category.TabStop = false;
            this.dataGridView_Category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Category_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "CHOOSE YOUR FAVOURITE CATEGORY:";
            // 
            // dataGridView_selected_items
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_selected_items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_selected_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_selected_items.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_selected_items.Location = new System.Drawing.Point(604, 294);
            this.dataGridView_selected_items.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_selected_items.Name = "dataGridView_selected_items";
            this.dataGridView_selected_items.ReadOnly = true;
            this.dataGridView_selected_items.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_selected_items.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_selected_items.RowTemplate.Height = 24;
            this.dataGridView_selected_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_selected_items.Size = new System.Drawing.Size(464, 284);
            this.dataGridView_selected_items.TabIndex = 42;
            this.dataGridView_selected_items.TabStop = false;
            this.dataGridView_selected_items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_selected_items_CellContentClick);
            // 
            // Btn_select_item
            // 
            this.Btn_select_item.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_select_item.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_select_item.Location = new System.Drawing.Point(374, 585);
            this.Btn_select_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_select_item.Name = "Btn_select_item";
            this.Btn_select_item.Size = new System.Drawing.Size(145, 65);
            this.Btn_select_item.TabIndex = 43;
            this.Btn_select_item.Text = "Select Item";
            this.Btn_select_item.UseVisualStyleBackColor = false;
            this.Btn_select_item.Click += new System.EventHandler(this.Btn_select_item_Click);
            // 
            // Btn_remove_item
            // 
            this.Btn_remove_item.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_remove_item.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_remove_item.Location = new System.Drawing.Point(888, 585);
            this.Btn_remove_item.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_remove_item.Name = "Btn_remove_item";
            this.Btn_remove_item.Size = new System.Drawing.Size(180, 65);
            this.Btn_remove_item.TabIndex = 44;
            this.Btn_remove_item.Text = "Remove Item";
            this.Btn_remove_item.UseVisualStyleBackColor = false;
            this.Btn_remove_item.Click += new System.EventHandler(this.Btn_remove_item_Click);
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_price.Location = new System.Drawing.Point(598, 596);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(158, 32);
            this.lbl_total_price.TabIndex = 45;
            this.lbl_total_price.Text = "Total Price:";
            // 
            // textBox_total_price
            // 
            this.textBox_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total_price.Location = new System.Drawing.Point(748, 594);
            this.textBox_total_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_total_price.Name = "textBox_total_price";
            this.textBox_total_price.Size = new System.Drawing.Size(95, 44);
            this.textBox_total_price.TabIndex = 46;
            this.textBox_total_price.TextChanged += new System.EventHandler(this.textBox_total_price_TextChanged);
            // 
            // Btn_confirm_order
            // 
            this.Btn_confirm_order.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Btn_confirm_order.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_confirm_order.Location = new System.Drawing.Point(778, 662);
            this.Btn_confirm_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_confirm_order.Name = "Btn_confirm_order";
            this.Btn_confirm_order.Size = new System.Drawing.Size(180, 48);
            this.Btn_confirm_order.TabIndex = 47;
            this.Btn_confirm_order.Text = "Confirm Order";
            this.Btn_confirm_order.UseVisualStyleBackColor = false;
            this.Btn_confirm_order.Click += new System.EventHandler(this.Btn_confirm_order_Click);
            // 
            // Btn_cancel_order
            // 
            this.Btn_cancel_order.BackColor = System.Drawing.Color.Tomato;
            this.Btn_cancel_order.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancel_order.Location = new System.Drawing.Point(601, 662);
            this.Btn_cancel_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_cancel_order.Name = "Btn_cancel_order";
            this.Btn_cancel_order.Size = new System.Drawing.Size(169, 48);
            this.Btn_cancel_order.TabIndex = 48;
            this.Btn_cancel_order.Text = "Cancel Order";
            this.Btn_cancel_order.UseVisualStyleBackColor = false;
            this.Btn_cancel_order.Click += new System.EventHandler(this.Btn_cancel_order_Click);
            // 
            // btn_back_cus_view_menu
            // 
            this.btn_back_cus_view_menu.BackColor = System.Drawing.Color.Tomato;
            this.btn_back_cus_view_menu.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_cus_view_menu.Location = new System.Drawing.Point(966, 662);
            this.btn_back_cus_view_menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back_cus_view_menu.Name = "btn_back_cus_view_menu";
            this.btn_back_cus_view_menu.Size = new System.Drawing.Size(101, 48);
            this.btn_back_cus_view_menu.TabIndex = 62;
            this.btn_back_cus_view_menu.Text = "Back";
            this.btn_back_cus_view_menu.UseVisualStyleBackColor = false;
            this.btn_back_cus_view_menu.Click += new System.EventHandler(this.btn_back_cus_view_menu_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.Arrow_symbol_picture;
            this.pictureBox3.Location = new System.Drawing.Point(506, 400);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Design_picture_6;
            this.pictureBox2.Location = new System.Drawing.Point(638, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 251);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Search_icon_image;
            this.pictureBox1.Location = new System.Drawing.Point(476, 251);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Cus_view_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1141, 739);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_back_cus_view_menu);
            this.Controls.Add(this.Btn_cancel_order);
            this.Controls.Add(this.Btn_confirm_order);
            this.Controls.Add(this.textBox_total_price);
            this.Controls.Add(this.lbl_total_price);
            this.Controls.Add(this.Btn_remove_item);
            this.Controls.Add(this.Btn_select_item);
            this.Controls.Add(this.dataGridView_selected_items);
            this.Controls.Add(this.rd_btn_coffee);
            this.Controls.Add(this.rd_btn_desserts);
            this.Controls.Add(this.rd_btn_salad);
            this.Controls.Add(this.rd_btn_main_dish);
            this.Controls.Add(this.rd_btn_breakfast);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_item_search);
            this.Controls.Add(this.dataGridView_Category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cus_view_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cus_view_menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selected_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_item_search;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_selected_items;
        private System.Windows.Forms.Button Btn_select_item;
        private System.Windows.Forms.Button Btn_remove_item;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.TextBox textBox_total_price;
        private System.Windows.Forms.Button Btn_confirm_order;
        private System.Windows.Forms.Button Btn_cancel_order;
        private System.Windows.Forms.Button btn_back_cus_view_menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}