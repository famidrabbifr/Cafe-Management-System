namespace WindowsFormsApp2
{
    partial class View_Current_order
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
            this.dataGridView_Current_order = new System.Windows.Forms.DataGridView();
            this.Btn_order_served = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back_view_current_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Current_order)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Current_order
            // 
            this.dataGridView_Current_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Current_order.Location = new System.Drawing.Point(51, 116);
            this.dataGridView_Current_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_Current_order.Name = "dataGridView_Current_order";
            this.dataGridView_Current_order.ReadOnly = true;
            this.dataGridView_Current_order.RowHeadersWidth = 51;
            this.dataGridView_Current_order.RowTemplate.Height = 24;
            this.dataGridView_Current_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Current_order.Size = new System.Drawing.Size(922, 434);
            this.dataGridView_Current_order.TabIndex = 0;
            this.dataGridView_Current_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Current_order_CellContentClick);
            // 
            // Btn_order_served
            // 
            this.Btn_order_served.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_order_served.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_order_served.Location = new System.Drawing.Point(685, 571);
            this.Btn_order_served.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_order_served.Name = "Btn_order_served";
            this.Btn_order_served.Size = new System.Drawing.Size(180, 65);
            this.Btn_order_served.TabIndex = 45;
            this.Btn_order_served.Text = "Order Served";
            this.Btn_order_served.UseVisualStyleBackColor = false;
            this.Btn_order_served.Click += new System.EventHandler(this.Btn_order_served_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 46;
            this.label1.Text = "View current order:";
            // 
            // btn_back_view_current_order
            // 
            this.btn_back_view_current_order.BackColor = System.Drawing.Color.Tomato;
            this.btn_back_view_current_order.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_view_current_order.Location = new System.Drawing.Point(872, 571);
            this.btn_back_view_current_order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back_view_current_order.Name = "btn_back_view_current_order";
            this.btn_back_view_current_order.Size = new System.Drawing.Size(101, 65);
            this.btn_back_view_current_order.TabIndex = 63;
            this.btn_back_view_current_order.Text = "Back";
            this.btn_back_view_current_order.UseVisualStyleBackColor = false;
            this.btn_back_view_current_order.Click += new System.EventHandler(this.btn_back_view_current_order_Click);
            // 
            // View_Current_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1024, 671);
            this.Controls.Add(this.btn_back_view_current_order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_order_served);
            this.Controls.Add(this.dataGridView_Current_order);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View_Current_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Current_order";
            this.Load += new System.EventHandler(this.View_Current_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Current_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Current_order;
        private System.Windows.Forms.Button Btn_order_served;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back_view_current_order;
    }
}