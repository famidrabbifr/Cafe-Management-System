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

namespace AdminPanel
{
    public partial class Admin_Update_Menu : Form
    {
        public Admin_Update_Menu()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            string itemName = textBox3.Text;
            string price = textBox4.Text;
            string category = comboBox1.Text;

            if (itemName == "" || price == "" || category == "")
            {
                MessageBox.Show("Item name, price, and category are required.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                string query = "INSERT INTO Items_list (Category, Items, Price) VALUES('" + category + "', '" + itemName + "', " + price + ")";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item added.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                if (textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Item, Price, and Category must not be empty.");
                    return;
                }

                string query = "UPDATE Items_list SET Price=" + textBox4.Text + ", Category='" + comboBox1.Text + "' WHERE Items='" + textBox3.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated successfully.", "Updated");
                LoadCategories();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }


        }



        private void btnloginclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
         
            comboBox1.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text.Trim();

            if (itemName == "")
            {
                MessageBox.Show("Please enter an item name to delete.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            string query = "DELETE FROM Items_list WHERE Items = '" + itemName + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Item deleted successfully!");
                textBox1.Clear();
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Item not found!");
            }

            conn.Close();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Close();
        }

        private void LoadCategories()
        {
            try
            {
                string query = "SELECT * FROM Items_list";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void Admin_Update_Menu_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string searchItem = textBox2.Text.Trim();

            if (searchItem == "")
            {
                MessageBox.Show("Please enter an item name to search.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM Items_list WHERE Items LIKE @item + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@item", searchItem);


            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_un_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Update_Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadCategories();
            MessageBox.Show("Data refreshed.", "Refreshed");
        }
    }
}

