using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Add_item_staff: Form
    {
        private string welcome_name, uname;
        public Add_item_staff(string name, string Uname)
        {
            InitializeComponent();
            welcome_name = name;
            uname = Uname;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void rd_btn_breakfast_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_new_item_save_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (!rd_btn_breakfast.Checked && !rd_btn_main_dish.Checked &&
                !rd_btn_salad.Checked && !rd_btn_desserts.Checked && !rd_btn_coffee.Checked)
            {
                MessageBox.Show("Please select the category to add an item.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_new_item_name.Text))
            {
                Need_new_itemname.Text = "✱";
                Need_new_itemname.Visible = true;
                isValid = false;
            }
            else
            {
                Need_new_itemname.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(textbox_new_item_price.Text))
            {
                need_new_item_price.Text = "✱";
                need_new_item_price.Visible = true;
                isValid = false;
            }
            else
            {
                if (!int.TryParse(textbox_new_item_price.Text, out int price))
                {
                    MessageBox.Show("Please enter a valid price.");
                    isValid = false;
                }
                else
                {
                    need_new_item_price.Visible = false;
                }
            }

            if (isValid)
            {
                string category = "";
                if (rd_btn_breakfast.Checked)
                {
                    category = "Breakfast & Snacks";
                }
                else if (rd_btn_main_dish.Checked)
                {
                    category = "Main Dishes";
                }
                else if (rd_btn_salad.Checked)
                {
                    category = "Salads & Sides";
                }
                else if (rd_btn_desserts.Checked)
                {
                    category = "Desserts";
                }
                else if (rd_btn_coffee.Checked)
                {
                    category = "Coffee & Beverages";
                }

                string insert_query = "insert into Items_list values('" + category + "', '" + textBox_new_item_name.Text + "', '" + textbox_new_item_price.Text + "')";

                SqlCommand cmd = new SqlCommand(insert_query, con);


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        

                        DialogResult res = MessageBox.Show("Item added successfully!", "", MessageBoxButtons.OK);

                        if (res == DialogResult.OK)
                        {
                            rd_btn_breakfast.Checked = false;
                            rd_btn_main_dish.Checked = false;
                            rd_btn_salad.Checked = false;
                            rd_btn_desserts.Checked = false;
                            rd_btn_coffee.Checked = false;
                            textBox_new_item_name.Clear();
                            textbox_new_item_price.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item add not successfull!");
                    }
                }
                else
                {
                    MessageBox.Show("DB connection not established");
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_add_item_Click(object sender, EventArgs e)
        {
            View_menu vm = new View_menu(welcome_name, uname);
            vm.Show();
            this.Hide();
        }
    }
}
