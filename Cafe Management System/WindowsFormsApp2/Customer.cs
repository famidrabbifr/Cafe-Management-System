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
    public partial class Customer: Form
    {
        private string welcome_name;
        private string USER_NAME;
        public Customer(string name, string USERNAME)
        {
            InitializeComponent();
            welcome_name = name;
            USER_NAME = USERNAME;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void Customer_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Welcome " + welcome_name + "!";
        }
        private void Cus_Btn_change_pass(object sender, EventArgs e)
        {
            Cus_Password_change cpc = new Cus_Password_change(welcome_name, USER_NAME);
            cpc.Show();
            this.Hide();
        }
        private void Btn_Cus_Update_Info_Click(object sender, EventArgs e)
        {
            Cus_Update_info cui = new Cus_Update_info(USER_NAME);
            cui.Show();
            this.Hide();
        }

        private void Btn_cus_delete_account_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Do you want to delete your account?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM Login WHERE Username = '" + USER_NAME + "'";

                SqlCommand cmd = new SqlCommand(deleteQuery, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {

                        DialogResult res = MessageBox.Show("Account deleted successfully!", "", MessageBoxButtons.OK);

                        if (res == DialogResult.OK)
                        {
                            Login f1 = new Login();
                            f1.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account delete not successfull!");
                    }
                }
                else
                {
                    MessageBox.Show("DB connection not established");
                }
            }
            else
            {
                return;
            }
        }

        private void Btn_cus_view_menu_Click(object sender, EventArgs e)
        {
            Cus_view_menu cvm = new Cus_view_menu(welcome_name, USER_NAME);
            cvm.Show();
            this.Hide();
        }

        private void Btn_view_my_order_Click(object sender, EventArgs e)
        {
            string countQuery = "SELECT COUNT(*) FROM Current_order WHERE Username = '" + USER_NAME + "'";
            SqlCommand cmd = new SqlCommand(countQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                int orderCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (orderCount == 0)
                {
                    MessageBox.Show("You have no current order.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;   
                }

                Cus_View_my_order cvmo = new Cus_View_my_order(welcome_name, USER_NAME);
                cvmo.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void Btn_view_my_order_history_Click(object sender, EventArgs e)
        {
            string countQuery = "SELECT COUNT(*) FROM Order_history WHERE Username = '" + USER_NAME + "'";
            SqlCommand cmd = new SqlCommand(countQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                int orderCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (orderCount == 0)
                {
                    MessageBox.Show("You have no order history.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Cus_order_history coh = new Cus_order_history(welcome_name, USER_NAME);
                coh.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void Btn_Log_out_staff_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Do you want to log out your account?", "Logout account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                Login f1 = new Login();
                f1.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
    }
}
