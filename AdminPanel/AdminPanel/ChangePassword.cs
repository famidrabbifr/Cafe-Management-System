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
    public partial class ChangePassword : Form
    {
        string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)

        {
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string newPassword = textBox2.Text.Trim();
            string confirmPassword = textBox3.Text.Trim();

            if (username == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open(); 

            try
            {
                string roleQuery = "SELECT Role FROM LOGIN WHERE Username = '" + username + "'";
                SqlCommand roleCmd = new SqlCommand(roleQuery, conn);
                object roleObj = roleCmd.ExecuteScalar();

                if (roleObj == null)
                {
                    MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string role = roleObj.ToString();
                if (role.ToLower() != "admin")
                {
                    MessageBox.Show("Only Admins are allowed to change the password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE LOGIN SET Password = '" + newPassword + "' WHERE Username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin adminForm = new Admin(username);
                    adminForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin(); 
            adminForm.Show();
            this.Close();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !showPass.Checked;
            textBox3.UseSystemPasswordChar = !showPass.Checked;
        }

        private void btnloginclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();  
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
