using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Update_Info: Form
    {
        private string uname;
        public Update_Info(string USER_NAME)
        {
            InitializeComponent();
            uname = USER_NAME;

            textBox_Up_Phone.KeyPress += textBox_Up_Phone_KeyPress;
            textBox_Up_Phone.TextChanged += textBox_Up_Phone_TextChanged;

            textBox_Up_Phone.MaxLength = 11;

            lblPhoneError.Visible = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void textBox_Up_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigitOrControl = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);
            if (!isDigitOrControl)
            {
                e.Handled = true;
                lblPhoneError.Text = "Invalid character! Please enter digits only (0-9)";
                lblPhoneError.Visible = true;
            }
        }
        private void textBox_Up_Phone_TextChanged(object sender, EventArgs e)
        {
            string onlyDigits = Regex.Replace(textBox_Up_Phone.Text, "[^0-9]", "");

            if (textBox_Up_Phone.Text != onlyDigits)
            {
                int cursorPos = textBox_Up_Phone.SelectionStart;
                textBox_Up_Phone.Text = onlyDigits;
                textBox_Up_Phone.SelectionStart = cursorPos > 0 ? cursorPos - 1 : 0;

                lblPhoneError.Text = "Invalid character! Please enter digits only (0-9)";
                lblPhoneError.Visible = true;
                return;
            }

            if (textBox_Up_Phone.Text.Length == 0)
            {
                lblPhoneError.Visible = false;
            }
            else if (textBox_Up_Phone.Text.Length != 11)
            {
                lblPhoneError.Text = "Phone number must be exactly 11 digits.";
                lblPhoneError.Visible = true;
            }
            else
            {
                lblPhoneError.Visible = false;
            }
        }

        private string GetName(string uname)
        {
            string name = null;

            string name_query = "SELECT Name FROM Login WHERE Username = '" + uname + "'";

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

        private string GetEmail(string uname)
        {
            string email = null;

            string mail_query = "SELECT Email FROM Login WHERE Username = '" + uname + "'";

            using (SqlCommand cmd = new SqlCommand(mail_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    email = result.ToString();
                }
            }

            return email;
        }

        private string GetPhone(string uname)
        {
            string phone = null;

            string phone_query = "SELECT Phone FROM Login WHERE Username = '" + uname + "'";

            using (SqlCommand cmd = new SqlCommand(phone_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    phone = result.ToString();
                }
            }

            return phone;
        }

        private void Update_Info_Load(object sender, EventArgs e)
        {
            string Name = GetName(uname);
            string Email = GetEmail(uname);
            string Phone = GetPhone(uname);

            textBoxUname.Text = uname;
            textBox_Up_Name.Text = Name;
            textBox_Up_Email.Text = Email;
            textBox_Up_Phone.Text = Phone;

        }

        private void textBoxUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_edit_name_Click(object sender, EventArgs e)
        {
            textBox_Up_Name.Enabled = true;
            textBox_Up_Name.ReadOnly = false;
            textBox_Up_Name.Focus();
        }

        private void Btn_save_name_Click(object sender, EventArgs e)
        {
            if(textBox_Up_Name.Enabled == true && textBox_Up_Name.ReadOnly == false && textBox_Up_Name.Text != "")
            {
                Need_name.Visible = false;
                string updateNameQuery = "UPDATE Login SET Name = '" + textBox_Up_Name.Text + "' WHERE Username = '" + uname + "'";

                SqlCommand cmd = new SqlCommand(updateNameQuery, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        DialogResult res = MessageBox.Show("Name changed successfully!", "", MessageBoxButtons.OK);

                        if (res == DialogResult.OK)
                        {
                            textBox_Up_Name.Enabled = false;
                            textBox_Up_Name.ReadOnly = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name change not successfull!");
                    }
                }
                else
                {
                    MessageBox.Show("DB connection not established");
                }
            }
            else if(textBox_Up_Name.Text == "")
            {
                Need_name.Text = "✱";
                Need_name.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void Btn_edit_email_Click(object sender, EventArgs e)
        {
            textBox_Up_Email.Enabled = true;
            textBox_Up_Email.ReadOnly = false;
            textBox_Up_Email.Focus();
        }

        private void Btn_save_email_Click(object sender, EventArgs e)
        {
            if (textBox_Up_Email.Enabled == true && textBox_Up_Email.ReadOnly == false && textBox_Up_Email.Text != "")
            {
                Mail_need.Visible = false;
                string updateEmailQuery = "UPDATE Login SET Email = '" + textBox_Up_Email.Text + "' WHERE Username = '" + uname + "'";

                SqlCommand cmd = new SqlCommand(updateEmailQuery, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        DialogResult res = MessageBox.Show("Email changed successfully!", "", MessageBoxButtons.OK);

                        if (res == DialogResult.OK)
                        {
                            textBox_Up_Email.Enabled = false;
                            textBox_Up_Email.ReadOnly = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email change not successfull!");
                    }
                }
                else
                {
                    MessageBox.Show("DB connection not established");
                }
            }
            else if (textBox_Up_Email.Text == "")
            {
                Mail_need.Text = "✱";
                Mail_need.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void Btn_edit_phone_Click(object sender, EventArgs e)
        {
            textBox_Up_Phone.Enabled = true;
            textBox_Up_Phone.ReadOnly = false;
            textBox_Up_Phone.Focus();

            if (textBox_Up_Phone.Text.Length != 11)
            {
                lblPhoneError.Text = "Phone must be 11 digits";
                lblPhoneError.Visible = true;
            }
            else
            {
                lblPhoneError.Visible = false;
            }
        }

        private void Btn_save_phone_Click(object sender, EventArgs e)
        {
            if (textBox_Up_Phone.Enabled == true && textBox_Up_Phone.ReadOnly == false && textBox_Up_Phone.Text != "")
            {
                Phone_need.Visible = false;
                string updatePhoneQuery = "UPDATE Login SET Phone = '" + textBox_Up_Phone.Text + "' WHERE Username = '" + uname + "'";

                SqlCommand cmd = new SqlCommand(updatePhoneQuery, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        DialogResult res = MessageBox.Show("Phone number changed successfully!", "", MessageBoxButtons.OK);

                        if (res == DialogResult.OK)
                        {
                            textBox_Up_Phone.Enabled = false;
                            textBox_Up_Phone.ReadOnly = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone number change not successfull!");
                    }
                }
                else
                {
                    MessageBox.Show("DB connection not established");
                }
            }
            else if (textBox_Up_Phone.Text == "")
            {
                Phone_need.Text = "✱";
                Phone_need.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void btn_update_info_back_Click(object sender, EventArgs e)
        {
            string welcome_name = GetName(uname);
            Staff sf = new Staff(welcome_name, uname);
            sf.Show();
            this.Hide();
        }
    }
}
