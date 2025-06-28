using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AdminPanel; 


namespace WindowsFormsApp2
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                textboxpass.UseSystemPasswordChar = false;
            }
            else
            {
                textboxpass.UseSystemPasswordChar = true;
            }
        }

        private void btnloginclear_Click(object sender, EventArgs e)
        {
            textBoxUN.Clear();
            textboxpass.Clear();
            textBoxUN.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private string GetUserRole(string username, string password)
        {
            string role = null;

            string role_query = "SELECT Role FROM Login WHERE Username = '" + username + "' AND Password = '" + password + "'";

            using (SqlCommand cmd = new SqlCommand(role_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    role = result.ToString();
                }
            }

            return role;
        }

        private string GetName(string username, string password)
        {
            string name = null;

            string name_query = "SELECT Name FROM Login WHERE Username = '" + username + "' AND Password = '" + password + "'";

            using (SqlCommand cmd = new SqlCommand(name_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    name = result.ToString();
                }
            }

            return name;
        }

        private string GetUserame(string username, string password)
        {
            string USERNAME = null;

            string name_query = "SELECT Username FROM Login WHERE Username = '" + username + "' AND Password = '" + password + "'";

            using (SqlCommand cmd = new SqlCommand(name_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    USERNAME = result.ToString();
                }
            }

            return USERNAME;
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxUN.Text.Trim();
            string password = textboxpass.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter the usernmame and password.");
                return;
            }

            string role = GetUserRole(username, password);
            string name = GetName(username, password);
            string USERNAME = GetUserame(username, password);

            if (role == null)
            {
                DialogResult ask = MessageBox.Show("Wrong username or password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (ask == DialogResult.OK) MessageBox.Show("If you forget your username or password, please contact the admin!","Forgot password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (role.ToLower() == "admin")
            {
                AdminPanel.Admin af = new AdminPanel.Admin(name);
                af.Show();
                this.Hide();
            }
            else if (role.ToLower() == "customer")
            {
                Customer cf = new Customer(name, USERNAME);
                cf.Show();
                this.Hide();
            }
            else if (role.ToLower() == "staff")
            {
                Staff sf = new Staff(name, USERNAME);
                sf.Show();
                this.Hide();
            }
        }


        private void linklblCreateNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form rf = new Registration_Form();
            rf.Show();
            this.Hide();
        }
    }
}
