using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Edit_price_staff: Form
    {
        string itemName;
        string itemPrice;
        string welcome_name;
        string uname;
        public Edit_price_staff(string name, string price, string Welcome_name, string Uname)
        {
            InitializeComponent();

            itemName = name;
            itemPrice = price;
            welcome_name = Welcome_name;
            uname = Uname;

            textBox_item_name.Text = name;
            textBox_item_name.ReadOnly = true;

            textbox_item_price_edit.Text = price;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void textBox_item_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox__item_price_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_edit_price_Click(object sender, EventArgs e)
        {
            View_menu vm = new View_menu(welcome_name, uname);
            vm.Show();
            this.Hide();
        }

        private void Btn_edit_save_Click(object sender, EventArgs e)
        {
            string newPriceText = textbox_item_price_edit.Text.Trim();

            if (!int.TryParse(newPriceText, out int newPrice) || newPrice < 0)
            {
                MessageBox.Show("Please enter a valid price (positive number).");
                return;
            }

            string updateQuery = "UPDATE Items_list SET Price = '" + newPrice + "' WHERE Items = '" + textBox_item_name.Text + "'";

            SqlCommand cmd = new SqlCommand(updateQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Price updated successfully!");
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }


        }
    }
}
