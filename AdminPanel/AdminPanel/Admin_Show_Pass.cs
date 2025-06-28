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
    public partial class Admin_Show_Pass : Form
    {
        public Admin_Show_Pass()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;

        private void Admin_add_catagory_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadAdminCredentials(string name, string phone)
        {
            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "SELECT Username, Password FROM dbo.Login WHERE Role = 'Admin' AND Name = @name AND Phone = @phone";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void LoadCustomerCredentials(string name, string phone)
        {
            conn.Open();

            string query = "SELECT Username, Password FROM dbo.Login WHERE Role = 'Customer' AND Name = @name AND Phone = @phone";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void LoadStaffCredentials(string name, string phone)
        {
            conn.Open();

            string query = "SELECT Username, Password FROM dbo.Login WHERE Role = 'Staff' AND Name = @name AND Phone = @phone";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text.Trim();
            string phone = textBox2.Text.Trim();

            if (name == "" || phone == "")
            {
                MessageBox.Show("Enter both name and phone number.");
                return;
            }

            LoadAdminCredentials(name, phone);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        private void btnloginclear_Click(object sender, EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text.Trim();
            string phone = textBox2.Text.Trim();

            if (name == "" || phone == "")
            {
                MessageBox.Show("Enter both name and phone number.");
                return;
            }

            LoadCustomerCredentials(name, phone);
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

        private void label8_Click(object sender, EventArgs e) 
        { 
        
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

            if (textBox2.Text.Length > 11)
            {
                MessageBox.Show("Phone number must be 11 digits.");
                textBox2.Text = textBox2.Text.Substring(0, 11);
                textBox2.SelectionStart = textBox2.Text.Length;
            }

        }

        private void lbl_un_Click(object sender, EventArgs e) 
        { 

        }

        private void label2_Click(object sender, EventArgs e) 
        { 

        }

        private void textBox3_TextChanged(object sender, EventArgs e) 
        {

          

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



            private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox3.Text.Trim();
            string phone = textBox2.Text.Trim();

            if (name == "" || phone == "")
            {
                MessageBox.Show("Enter both name and phone number.");
                return;
            }

            LoadStaffCredentials(name, phone);
        }
    }
}

