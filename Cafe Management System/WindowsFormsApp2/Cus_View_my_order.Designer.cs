namespace WindowsFormsApp2
{
    partial class Cus_View_my_order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.richTextBox_selected_items = new System.Windows.Forms.RichTextBox();
            this.textBox_Total_price = new System.Windows.Forms.TextBox();
            this.btn_back_cus_view_order = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected Items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Price (BDT):";
            // 
            // TextBox_name
            // 
            this.TextBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_name.Location = new System.Drawing.Point(634, 160);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.ReadOnly = true;
            this.TextBox_name.Size = new System.Drawing.Size(273, 35);
            this.TextBox_name.TabIndex = 3;
            this.TextBox_name.TabStop = false;
            // 
            // richTextBox_selected_items
            // 
            this.richTextBox_selected_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_selected_items.Location = new System.Drawing.Point(634, 245);
            this.richTextBox_selected_items.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_selected_items.Name = "richTextBox_selected_items";
            this.richTextBox_selected_items.ReadOnly = true;
            this.richTextBox_selected_items.Size = new System.Drawing.Size(273, 153);
            this.richTextBox_selected_items.TabIndex = 4;
            this.richTextBox_selected_items.TabStop = false;
            this.richTextBox_selected_items.Text = "";
            this.richTextBox_selected_items.TextChanged += new System.EventHandler(this.richTextBox_selected_items_TextChanged);
            // 
            // textBox_Total_price
            // 
            this.textBox_Total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total_price.Location = new System.Drawing.Point(634, 440);
            this.textBox_Total_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Total_price.Name = "textBox_Total_price";
            this.textBox_Total_price.ReadOnly = true;
            this.textBox_Total_price.Size = new System.Drawing.Size(273, 35);
            this.textBox_Total_price.TabIndex = 5;
            this.textBox_Total_price.TabStop = false;
            // 
            // btn_back_cus_view_order
            // 
            this.btn_back_cus_view_order.BackColor = System.Drawing.Color.Tomato;
            this.btn_back_cus_view_order.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_cus_view_order.Location = new System.Drawing.Point(807, 519);
            this.btn_back_cus_view_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back_cus_view_order.Name = "btn_back_cus_view_order";
            this.btn_back_cus_view_order.Size = new System.Drawing.Size(101, 48);
            this.btn_back_cus_view_order.TabIndex = 63;
            this.btn_back_cus_view_order.Text = "Back";
            this.btn_back_cus_view_order.UseVisualStyleBackColor = false;
            this.btn_back_cus_view_order.Click += new System.EventHandler(this.btn_back_cus_view_order_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Design_picture_21;
            this.pictureBox1.Location = new System.Drawing.Point(81, 160);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 38);
            this.label4.TabIndex = 65;
            this.label4.Text = "VIEW MY ORDER";
            // 
            // Cus_View_my_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1023, 649);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back_cus_view_order);
            this.Controls.Add(this.textBox_Total_price);
            this.Controls.Add(this.richTextBox_selected_items);
            this.Controls.Add(this.TextBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cus_View_my_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cus_View_my_order";
            this.Load += new System.EventHandler(this.Cus_View_my_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_name;
        private System.Windows.Forms.RichTextBox richTextBox_selected_items;
        private System.Windows.Forms.TextBox textBox_Total_price;
        private System.Windows.Forms.Button btn_back_cus_view_order;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}