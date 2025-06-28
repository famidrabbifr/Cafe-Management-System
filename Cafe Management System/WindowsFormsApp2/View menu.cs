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

namespace WindowsFormsApp2
{
    public partial class View_menu: Form
    {
        private string welcome_name;
        private string uname;
        public View_menu(string name, string USERNAME)
        {
            welcome_name = name;
            uname = USERNAME;
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rd_btn_breakfast_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Breakfast & Snacks'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_main_dish_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Main Dishes'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_salad_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Salads & Sides'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_desserts_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Desserts'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_coffee_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Coffee & Beverages'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void textBox_item_search_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Items like '%" + textBox_item_search.Text.Trim() + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void Btn_Add_items_Click(object sender, EventArgs e)
        {
            Add_item_staff ais = new Add_item_staff(welcome_name, uname);
            ais.Show();
            this.Hide();
        }

        private void View_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_item_Click(object sender, EventArgs e)
        {
            if (dataGridView_Category.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            string itemName = dataGridView_Category.SelectedRows[0].Cells["Items"].Value.ToString();

            DialogResult ask = MessageBox.Show("Are you sure you want to delete '" + itemName + "' ?","Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ask != DialogResult.Yes)
            {
                return;
            }

            string deleteQuery = "DELETE FROM Items_list WHERE Items = '" + itemName + "'";

            SqlCommand cmd = new SqlCommand(deleteQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Item deleted successfully!");

                    dataGridView_Category.Rows.Remove(dataGridView_Category.SelectedRows[0]);
                }
                else
                {
                    MessageBox.Show("Delete failed—item not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }

        }

        private void btn_edit_price_Click(object sender, EventArgs e)
        {
            if (dataGridView_Category.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            string itemName = dataGridView_Category.SelectedRows[0].Cells["Items"].Value.ToString();
            string itemPrice = dataGridView_Category.SelectedRows[0].Cells["Price"].Value.ToString();

            Edit_price_staff eps = new Edit_price_staff(itemName, itemPrice, welcome_name, uname);
            eps.Show();
            this.Hide();
        }

        private void btn_back_menu_Click(object sender, EventArgs e)
        {
            Staff sf = new Staff(welcome_name, uname);
            sf.Show();
            this.Hide();
        }
    }
}
