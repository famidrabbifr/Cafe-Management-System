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
    public partial class Admin_Update_Info : Form
    {
        private string currentUsername;

        public Admin_Update_Info(string username)
        {
            InitializeComponent();
            currentUsername = username;
            conn = new SqlConnection(connectionString);
        }

        string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin(currentUsername);
            adminForm.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxN.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields before updating.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string query = "UPDATE dbo.Login SET Name = '" + textBoxN.Text + "', Gender = '" + comboBox1.Text + "', Email = '" + textBox2.Text + "', Phone = '" + textBox3.Text + "' WHERE Username = '" + textBox1.Text + "' AND Role = 'Admin'";

            SqlCommand cmd = new SqlCommand(query, conn);
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Information updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed. No row affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.Close();
        }




        private void textBoxN_TextChanged(object sender, EventArgs e)
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

        private void btnloginclear_Click(object sender, EventArgs e)
        {
            textBoxN.Clear();
            comboBox1.SelectedIndex = -1;
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBoxN.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin(currentUsername);
            adminForm.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
