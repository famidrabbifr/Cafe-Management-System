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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AdminPanel
{
    public partial class Admin_Update_Staff : Form
    {
        string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;

        public Admin_Update_Staff()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Update_Staff_Load(object sender, EventArgs e)
        {
            Show();
            

        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 11)
            {
                MessageBox.Show("Phone number must be 11 digits.");
                textBox3.Text = textBox3.Text.Substring(0, 11);
                textBox3.SelectionStart = textBox3.Text.Length;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnloginclear_Click(object sender, EventArgs e)
        {
            textBoxN.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox3.Clear();
           
            textBox6.Clear();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

         


            string query = "UPDATE Login SET Gender = '" + comboBox1.Text +
                           "', Email = '" + textBox2.Text +
                           "', Phone = '" + textBox3.Text +
                           "' WHERE Name = '" + textBoxN.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Staff info updated successfully.", "Updated");

            Show();

          
        }





        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox6.Text;

            if (name == "")
            {
                MessageBox.Show("Enter name to search.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM Login WHERE Name LIKE @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
          
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadStaffGrid()
        {

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;
TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string q = "SELECT * FROM dbo.Login WHERE Role = 'Staff'";
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;

            conn.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            string nameToDelete = textBox1.Text.Trim();

            if (nameToDelete == "")
            {
                MessageBox.Show("Please enter a staff name to delete.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM Login WHERE Name = '" + nameToDelete + "' AND Role = 'Staff'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Staff deleted successfully.");
                textBox1.Clear();
                Show();
            }
            else
            {
                MessageBox.Show("Staff not found.");
            }

            conn.Close();
        }





        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                

                string name = textBoxN.Text;
                string gender = comboBox1.Text;
                string email = textBox2.Text;
                string phone = textBox3.Text;

                if (name == "" || gender == "" || email == "" || phone == "")
                {
                    MessageBox.Show("All fields are required.", "Input Error");
                    return;
                }

                string username = name.Split(' ')[0];
                string password = "123456";
                string role = "Staff";

                string query = "INSERT INTO Login (Name, Gender, Email, Phone, Username, Password, Role) " +
                   "VALUES ('" + name + "', '" + gender + "', '" + email + "', '" + phone + "', '" + username + "', '" + password + "', '" + role + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Staff inserted successfully.", "Inserted");

                LoadStaffGrid();

                textBoxN.Clear();
                comboBox1.SelectedIndex = -1;
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) 
                {
                    MessageBox.Show("Duplicate entry. This staff already exists.", "Error");
                }
                else
                {
                    MessageBox.Show("SQL Error: " + ex.Message, "Error");
                }
            }
            finally
            {
                conn.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_un_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            LoadStaffGrid(); 
            MessageBox.Show("Data refreshed.", "Refreshed");

        }
    }
}
