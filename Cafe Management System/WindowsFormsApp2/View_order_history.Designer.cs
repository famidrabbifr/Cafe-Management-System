namespace WindowsFormsApp2
{
    partial class View_order_history
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
            this.dataGridView_order_history = new System.Windows.Forms.DataGridView();
            this.btn_back_view_order_history = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order_history)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "View order history:";
            // 
            // dataGridView_order_history
            // 
            this.dataGridView_order_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order_history.Location = new System.Drawing.Point(72, 98);
            this.dataGridView_order_history.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_order_history.Name = "dataGridView_order_history";
            this.dataGridView_order_history.ReadOnly = true;
            this.dataGridView_order_history.RowHeadersWidth = 51;
            this.dataGridView_order_history.RowTemplate.Height = 24;
            this.dataGridView_order_history.Size = new System.Drawing.Size(829, 450);
            this.dataGridView_order_history.TabIndex = 49;
            this.dataGridView_order_history.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_order_history_CellContentClick);
            // 
            // btn_back_view_order_history
            // 
            this.btn_back_view_order_history.BackColor = System.Drawing.Color.Tomato;
            this.btn_back_view_order_history.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_view_order_history.Location = new System.Drawing.Point(800, 570);
            this.btn_back_view_order_history.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back_view_order_history.Name = "btn_back_view_order_history";
            this.btn_back_view_order_history.Size = new System.Drawing.Size(101, 65);
            this.btn_back_view_order_history.TabIndex = 65;
            this.btn_back_view_order_history.Text = "Back";
            this.btn_back_view_order_history.UseVisualStyleBackColor = false;
            this.btn_back_view_order_history.Click += new System.EventHandler(this.btn_back_view_order_history_Click);
            // 
            // View_order_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(981, 661);
            this.Controls.Add(this.btn_back_view_order_history);
            this.Controls.Add(this.dataGridView_order_history);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "View_order_history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_order_history";
            this.Load += new System.EventHandler(this.View_order_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order_history)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_order_history;
        private System.Windows.Forms.Button btn_back_view_order_history;
    }
}