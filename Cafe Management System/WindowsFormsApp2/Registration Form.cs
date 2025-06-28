using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Registration_Form : Form
    {
        string Gender;
        public Registration_Form()
        {
            InitializeComponent();

            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;

            textBoxPhone.MaxLength = 11;

            lblPhoneError.Visible = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                textBoxPass.UseSystemPasswordChar = false;
                textBoxPassRetype.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                textBoxPassRetype.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigitOrControl = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);
            if (!isDigitOrControl)
            {
                e.Handled = true; 
                lblPhoneError.Text = "Invalid character! Please enter digits only (0-9)";
                lblPhoneError.Visible = true;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string onlyDigits = Regex.Replace(textBoxPhone.Text, "[^0-9]", "");

            if (textBoxPhone.Text != onlyDigits)
            {
                int cursorPos = textBoxPhone.SelectionStart;
                textBoxPhone.Text = onlyDigits;
                textBoxPhone.SelectionStart = cursorPos > 0 ? cursorPos - 1 : 0;

                lblPhoneError.Text = "Invalid character! Please enter digits only (0-9)";
                lblPhoneError.Visible = true;
                return;
            }

            if (textBoxPhone.Text.Length == 0)
            {
                lblPhoneError.Visible = false;
            }
            else if (textBoxPhone.Text.Length != 11)
            {
                lblPhoneError.Text = "Phone number must be exactly 11 digits.";
                lblPhoneError.Visible = true;
            }
            else
            {
                lblPhoneError.Visible = false;
            }
        }
        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPass.Text.Length > 8)
            {
                passErrorText1.Text = "Password must be up to 8 characters.";
                passErrorText1.Visible = true;
            }
            else
            {
                passErrorText1.Visible = false;
            }
        }

        private void textBoxPassRetype_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPass.Text != textBoxPassRetype.Text)
            {
                lblRetypepassErorr.Text = "Password doesn't match.";
            }
            else
            {
                lblRetypepassErorr.Text = " ";
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            ClearAllIndicators();

            bool isValid = true;  

            if (string.IsNullOrWhiteSpace(textBoxN.Text))
            {
                Need_name.Text = "✱";
                Need_name.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textboxmail.Text))
            {
                Mail_need.Text = "✱";
                Mail_need.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                Phone_need.Text = "✱";
                Phone_need.Visible = true;
                isValid = false;
            }
            else if (textBoxPhone.Text.Length != 11)
            {
                lblPhoneError.Text = "Phone must be 11 digits";
                lblPhoneError.Visible = true;
                isValid = false;
            }

            if (!radioButton_male.Checked && !radioButton_female.Checked)
            {
                Gender_need.Text = "✱";
                Gender_need.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBox_UN.Text))
            {
                Need_username.Text = "✱";
                Need_username.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPass.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassRetype.Text))
            {
                Need_pass.Text = "✱";
                Need_pass.Visible = true;
                isValid = false;
            }
            else
            {
                if (textBoxPass.Text.Length > 8)
                {
                    passErrorText1.Text = "Password must be up to 8 characters.";
                    passErrorText1.Visible = true;
                    isValid = false;
                }

                if (textBoxPass.Text != textBoxPassRetype.Text)
                {
                    lblRetypepassErorr.Text = "Password doesn't match.";
                    isValid = false;
                }
            }

            if (comboBoxRole.SelectedIndex == -1) 
            {
                Need_Role.Text = "✱";
                Need_Role.Visible = true;
                isValid = false;
            }

            if (isValid)
            {
                // InsertIntoDatabase();

                if (IsUsernameExists(textBox_UN.Text.Trim()))
                {
                    lbl_username_error.Text = "This username already exists.";
                    lbl_username_error.Visible = true;
                    return;
                }
                lbl_username_error.Visible = false;

                if (radioButton_male.Checked) Gender = radioButton_male.Text;
                else Gender = radioButton_female.Text;

                string insert_query = "insert into Login values('" + textBoxN.Text + "', '" + textboxmail.Text + "', '" + textBoxPhone.Text + "', '"+Gender+"', '"+textBox_UN.Text+"', '"+textBoxPass.Text+"', '"+comboBoxRole.Text+"')";

                SqlCommand cmd = new SqlCommand(insert_query, con);

                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        textBoxN.Clear();
                        textboxmail.Clear();
                        textBoxPhone.Clear();
                        radioButton_male.Checked = false;
                        radioButton_female.Checked = false;
                        textBox_UN.Clear();
                        textBoxPass.Clear();
                        textBoxPassRetype.Clear();
                        showPass.Checked = false;
                        comboBoxRole.SelectedItem = null;
                        textBoxN.Focus();

                        DialogResult res = MessageBox.Show("Account created successfully!", "", MessageBoxButtons.OK);
                        
                        if(res == DialogResult.OK)
                        {
                            Login f1 = new Login();
                            f1.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account created not successfull!");
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
            Need_name.Visible = false;
            Mail_need.Visible = false;
            Phone_need.Visible = false;
            Gender_need.Visible = false;
            Need_username.Visible = false;
            Need_pass.Visible = false;
            Need_Role.Visible = false;

            lblPhoneError.Visible = false;
            passErrorText1.Visible = false;
            lblRetypepassErorr.Text = "";
        }

        private bool IsUsernameExists(string username)
        {
            string query = "SELECT Username FROM Login WHERE Username = '" + username + "'";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }


        private void textboxmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lbl_username_error_Click(object sender, EventArgs e)
        {

        }
    }
}

