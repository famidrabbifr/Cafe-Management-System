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
    public partial class Admin_Admins_And_Customers : Form
    {
        public Admin_Admins_And_Customers()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;


        private void LoadAdminList(string search = "")
        {
            con.Open();

            string query = "SELECT Name, Email, Phone, Gender, Username, Role FROM dbo.Login WHERE Role = 'Admin'";
            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " AND Name LIKE @search";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            if (!string.IsNullOrWhiteSpace(search))
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void LoadCustomerList(string search = "")
        {
            con.Open();

            string query = "SELECT Name, Email, Phone, Gender, Username, Role FROM dbo.Login WHERE Role = 'Customer'";
            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " AND Name LIKE @search";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            if (!string.IsNullOrWhiteSpace(search))
            {
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadAdminList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string searchUsername = textBox1.Text.Trim();

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT Name, Email, Phone, Gender, Username, Role FROM dbo.Login WHERE Role IN ('Admin', 'Customer') AND Username LIKE @username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", "%" + searchUsername + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnloginclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Please enter a Customer Username to delete.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM Login WHERE Username = '" + username + "' AND Role = 'Customer'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Customer deleted successfully.");
                textBox2.Clear();
                LoadCustomerList();
            }
            else
            {
                MessageBox.Show("Customer not found.");
            }

            conn.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "SELECT Name, Email, Phone, Gender, Username, Role FROM dbo.Login WHERE Role IN ('Admin', 'Customer')";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            MessageBox.Show("Data refreshed.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text.Trim();

            if (username == "")
            {
                MessageBox.Show("Please enter a Admin Username to delete.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM Login WHERE Username = '" + username + "' AND Role = 'Admin'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Admin deleted successfully.");
                textBox3.Clear();
                LoadAdminList();
            }
            else
            {
                MessageBox.Show("Admin not found.");
            }

            conn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

