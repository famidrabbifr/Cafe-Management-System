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
    public partial class Cus_Password_change: Form
    {
        private string uname;
        private string name;
        public Cus_Password_change(string welcome_name, string USER_NAME)
        {
            InitializeComponent();
            uname = USER_NAME;
            name = welcome_name;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void show_curr_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if (show_curr_Pass.Checked)
            {
                textBox_current_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_current_pass.UseSystemPasswordChar = true;
            }
        }

        private void show_new_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (show_new_pass.Checked)
            {
                textBox_new_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_new_pass.UseSystemPasswordChar = true;
            }
        }

        private void show_confirm_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (show_confirm_pass.Checked)
            {
                textBox_confirm_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_confirm_pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_chnage_pass_clear_Click(object sender, EventArgs e)
        {
            textBox_current_pass.Clear();
            textBox_new_pass.Clear();
            textBox_confirm_pass.Clear();
            textBox_current_pass.Focus();
        }

        private string GetPassword(string uname)
        {
            string Curr_Pass = null;

            string pass_query = "SELECT Password FROM Login WHERE Username = '" + uname + "'";

            using (SqlCommand cmd = new SqlCommand(pass_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    Curr_Pass = result.ToString();
                }
            }

            return Curr_Pass;
        }

        private void btn_change_pass_confirm_Click(object sender, EventArgs e)
        {
            ClearAllIndicators();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBox_current_pass.Text))
            {
                Need_Curr_pass.Text = "✱";
                Need_Curr_pass.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_new_pass.Text))
            {
                need_new_pass.Text = "✱";
                need_new_pass.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_confirm_pass.Text))
            {
                need_confirm_pass.Text = "✱";
                need_confirm_pass.Visible = true;
                isValid = false;
            }

            else
            {
                if (textBox_new_pass.Text.Length > 8)
                {
                    New_passErrorText1.Text = "Password must be up to 8 characters.";
                    New_passErrorText1.Visible = true;
                    isValid = false;
                }

                if (textBox_new_pass.Text != textBox_confirm_pass.Text)
                {
                    lbl_Confirm_passErorr.Text = "Password doesn't match.";
                    isValid = false;
                }
            }

            if (isValid)
            {
                string Curr_pass = GetPassword(uname);

                if (textBox_current_pass.Text != Curr_pass)
                {
                    lbl_curr_pass_error.Text = "Current password doesn't match.";
                    lbl_curr_pass_error.Visible = true;
                    return;
                }
                else
                {
                    lbl_curr_pass_error.Visible = false;
                }

                if (Curr_pass == textBox_new_pass.Text)
                {
                    New_passErrorText1.Text = "New password must be different.";
                    New_passErrorText1.Visible = true;
                    return;
                }
                else
                {
                    New_passErrorText1.Visible = false;
                }

                string updatePassQuery = "UPDATE Login SET Password = '" + textBox_new_pass.Text + "' WHERE Username = '" + uname + "'";

                SqlCommand cmd = new SqlCommand(updatePassQuery, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        DialogResult res = MessageBox.Show("Password changed successfully!", "", MessageBoxButtons.OK);

                        if (res == DialogResult.OK)
                        {
                            textBox_current_pass.Clear();
                            textBox_new_pass.Clear();
                            textBox_confirm_pass.Clear();
                            show_curr_Pass.Checked = false;
                            show_new_pass.Checked = false;
                            show_confirm_pass.Checked = false;
                            textBox_current_pass.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password change not successfull!");
                    }
                }
                else
                {
                    MessageBox.Show("DB connection not established");
                }
            }
        }
        private void ClearAllIndicators()
        {
            Need_Curr_pass.Visible = false;
            need_new_pass.Visible = false;
            need_confirm_pass.Visible = false;

            New_passErrorText1.Visible = false;
            lbl_Confirm_passErorr.Text = "";
        }

        private void textBox_current_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_new_pass_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox_new_pass.Text.Length > 8)
            {
                New_passErrorText1.Text = "Password must be up to 8 characters.";
                New_passErrorText1.Visible = true;
            }
            else
            {
                New_passErrorText1.Visible = false;
            }
        }

        private void Cus_Password_change_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_confirm_pass_TextChanged(object sender, EventArgs e)
        {
            if (textBox_new_pass.Text != textBox_confirm_pass.Text)
            {
                lbl_Confirm_passErorr.Text = "Password doesn't match.";
            }
            else
            {
                lbl_Confirm_passErorr.Text = " ";
            }
        }

        private void btn_change_pass_back_Click(object sender, EventArgs e)
        {
            Customer cm = new Customer(name, uname);
            cm.Show();
            this.Hide();
        }
    }
}
