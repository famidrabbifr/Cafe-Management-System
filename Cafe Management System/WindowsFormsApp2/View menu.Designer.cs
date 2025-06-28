namespace WindowsFormsApp2
{
    partial class View_menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.textBox_item_search = new System.Windows.Forms.TextBox();
            this.Btn_Add_items = new System.Windows.Forms.Button();
            this.btn_delete_item = new System.Windows.Forms.Button();
            this.rd_btn_breakfast = new System.Windows.Forms.RadioButton();
            this.rd_btn_main_dish = new System.Windows.Forms.RadioButton();
            this.rd_btn_salad = new System.Windows.Forms.RadioButton();
            this.rd_btn_desserts = new System.Windows.Forms.RadioButton();
            this.rd_btn_coffee = new System.Windows.Forms.RadioButton();
            this.btn_edit_price = new System.Windows.Forms.Button();
            this.btn_back_menu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE YOUR FAVOURITE CATEGORY:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.dataGridView_Category.Location = new System.Drawing.Point(384, 218);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.ReadOnly = true;
            this.dataGridView_Category.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Category.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Category.RowTemplate.Height = 24;
            this.dataGridView_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Category.Size = new System.Drawing.Size(412, 227);
            this.dataGridView_Category.TabIndex = 6;
            this.dataGridView_Category.TabStop = false;
            this.dataGridView_Category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_item_search
            // 
            this.textBox_item_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_item_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_item_search.Location = new System.Drawing.Point(551, 183);
            this.textBox_item_search.Name = "textBox_item_search";
            this.textBox_item_search.Size = new System.Drawing.Size(245, 30);
            this.textBox_item_search.TabIndex = 9;
            this.textBox_item_search.TabStop = false;
            this.textBox_item_search.TextChanged += new System.EventHandler(this.textBox_item_search_TextChanged);
            // 
            // Btn_Add_items
            // 
            this.Btn_Add_items.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Add_items.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_items.Location = new System.Drawing.Point(667, 451);
            this.Btn_Add_items.Name = "Btn_Add_items";
            this.Btn_Add_items.Size = new System.Drawing.Size(129, 52);
            this.Btn_Add_items.TabIndex = 26;
            this.Btn_Add_items.Text = "Add Items";
            this.Btn_Add_items.UseVisualStyleBackColor = false;
            this.Btn_Add_items.Click += new System.EventHandler(this.Btn_Add_items_Click);
            // 
            // btn_delete_item
            // 
            this.btn_delete_item.BackColor = System.Drawing.Color.Tomato;
            this.btn_delete_item.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_item.Location = new System.Drawing.Point(515, 451);
            this.btn_delete_item.Name = "btn_delete_item";
            this.btn_delete_item.Size = new System.Drawing.Size(146, 52);
            this.btn_delete_item.TabIndex = 27;
            this.btn_delete_item.Text = "Delete Items";
            this.btn_delete_item.UseVisualStyleBackColor = false;
            this.btn_delete_item.Click += new System.EventHandler(this.btn_delete_item_Click);
            // 
            // rd_btn_breakfast
            // 
            this.rd_btn_breakfast.AutoSize = true;
            this.rd_btn_breakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_breakfast.Location = new System.Drawing.Point(384, 60);
            this.rd_btn_breakfast.Name = "rd_btn_breakfast";
            this.rd_btn_breakfast.Size = new System.Drawing.Size(224, 29);
            this.rd_btn_breakfast.TabIndex = 28;
            this.rd_btn_breakfast.TabStop = true;
            this.rd_btn_breakfast.Text = "Breakfast and Snacks";
            this.rd_btn_breakfast.UseVisualStyleBackColor = true;
            this.rd_btn_breakfast.CheckedChanged += new System.EventHandler(this.rd_btn_breakfast_CheckedChanged);
            // 
            // rd_btn_main_dish
            // 
            this.rd_btn_main_dish.AutoSize = true;
            this.rd_btn_main_dish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_main_dish.Location = new System.Drawing.Point(655, 60);
            this.rd_btn_main_dish.Name = "rd_btn_main_dish";
            this.rd_btn_main_dish.Size = new System.Drawing.Size(141, 29);
            this.rd_btn_main_dish.TabIndex = 29;
            this.rd_btn_main_dish.TabStop = true;
            this.rd_btn_main_dish.Text = "Main Dishes";
            this.rd_btn_main_dish.UseVisualStyleBackColor = true;
            this.rd_btn_main_dish.CheckedChanged += new System.EventHandler(this.rd_btn_main_dish_CheckedChanged);
            // 
            // rd_btn_salad
            // 
            this.rd_btn_salad.AutoSize = true;
            this.rd_btn_salad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_salad.Location = new System.Drawing.Point(384, 95);
            this.rd_btn_salad.Name = "rd_btn_salad";
            this.rd_btn_salad.Size = new System.Drawing.Size(187, 29);
            this.rd_btn_salad.TabIndex = 30;
            this.rd_btn_salad.TabStop = true;
            this.rd_btn_salad.Text = "Salads and Sides";
            this.rd_btn_salad.UseVisualStyleBackColor = true;
            this.rd_btn_salad.CheckedChanged += new System.EventHandler(this.rd_btn_salad_CheckedChanged);
            // 
            // rd_btn_desserts
            // 
            this.rd_btn_desserts.AutoSize = true;
            this.rd_btn_desserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_desserts.Location = new System.Drawing.Point(655, 92);
            this.rd_btn_desserts.Name = "rd_btn_desserts";
            this.rd_btn_desserts.Size = new System.Drawing.Size(110, 29);
            this.rd_btn_desserts.TabIndex = 31;
            this.rd_btn_desserts.TabStop = true;
            this.rd_btn_desserts.Text = "Desserts";
            this.rd_btn_desserts.UseVisualStyleBackColor = true;
            this.rd_btn_desserts.CheckedChanged += new System.EventHandler(this.rd_btn_desserts_CheckedChanged);
            // 
            // rd_btn_coffee
            // 
            this.rd_btn_coffee.AutoSize = true;
            this.rd_btn_coffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_coffee.Location = new System.Drawing.Point(384, 130);
            this.rd_btn_coffee.Name = "rd_btn_coffee";
            this.rd_btn_coffee.Size = new System.Drawing.Size(228, 29);
            this.rd_btn_coffee.TabIndex = 32;
            this.rd_btn_coffee.TabStop = true;
            this.rd_btn_coffee.Text = "Coffee and Beverages";
            this.rd_btn_coffee.UseVisualStyleBackColor = true;
            this.rd_btn_coffee.CheckedChanged += new System.EventHandler(this.rd_btn_coffee_CheckedChanged);
            // 
            // btn_edit_price
            // 
            this.btn_edit_price.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_edit_price.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_price.Location = new System.Drawing.Point(384, 451);
            this.btn_edit_price.Name = "btn_edit_price";
            this.btn_edit_price.Size = new System.Drawing.Size(125, 52);
            this.btn_edit_price.TabIndex = 33;
            this.btn_edit_price.Text = "Edit Price";
            this.btn_edit_price.UseVisualStyleBackColor = false;
            this.btn_edit_price.Click += new System.EventHandler(this.btn_edit_price_Click);
            // 
            // btn_back_menu
            // 
            this.btn_back_menu.BackColor = System.Drawing.Color.Tomato;
            this.btn_back_menu.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_menu.Location = new System.Drawing.Point(702, 521);
            this.btn_back_menu.Name = "btn_back_menu";
            this.btn_back_menu.Size = new System.Drawing.Size(94, 41);
            this.btn_back_menu.TabIndex = 61;
            this.btn_back_menu.Text = "Back";
            this.btn_back_menu.UseVisualStyleBackColor = false;
            this.btn_back_menu.Click += new System.EventHandler(this.btn_back_menu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.Design_picture_31;
            this.pictureBox2.Location = new System.Drawing.Point(44, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 325);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Search_icon_image;
            this.pictureBox1.Location = new System.Drawing.Point(758, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // View_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(898, 574);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_back_menu);
            this.Controls.Add(this.btn_edit_price);
            this.Controls.Add(this.rd_btn_coffee);
            this.Controls.Add(this.rd_btn_desserts);
            this.Controls.Add(this.rd_btn_salad);
            this.Controls.Add(this.rd_btn_main_dish);
            this.Controls.Add(this.rd_btn_breakfast);
            this.Controls.Add(this.btn_delete_item);
            this.Controls.Add(this.Btn_Add_items);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_item_search);
            this.Controls.Add(this.dataGridView_Category);
            this.Controls.Add(this.label1);
            this.Name = "View_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_menu";
            this.Load += new System.EventHandler(this.View_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.TextBox textBox_item_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Add_items;
        private System.Windows.Forms.Button btn_delete_item;
        private System.Windows.Forms.RadioButton rd_btn_breakfast;
        private System.Windows.Forms.RadioButton rd_btn_main_dish;
        private System.Windows.Forms.RadioButton rd_btn_salad;
        private System.Windows.Forms.RadioButton rd_btn_desserts;
        private System.Windows.Forms.RadioButton rd_btn_coffee;
        private System.Windows.Forms.Button btn_edit_price;
        private System.Windows.Forms.Button btn_back_menu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}