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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Staff: Form
    {
        private string welcome_name;
        private string USER_NAME;
        public Staff(string name, string USERNAME)
        {
            InitializeComponent();
            welcome_name = name;
            USER_NAME = USERNAME;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void Staff_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "Welcome " + welcome_name + "!";
        }

        private void Btn_Change_Pass_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(welcome_name,USER_NAME);
            cp.Show();
            this.Hide();
        }

        private void Btn_Update_Info_Click(object sender, EventArgs e)
        {
            Update_Info ui = new Update_Info(USER_NAME);
            ui.Show();
            this.Hide();
        }

        private void Btn_view_menu_Click(object sender, EventArgs e)
        {
            View_menu vm = new View_menu(welcome_name, USER_NAME);
            vm.Show();
            this.Hide();
        }

        private void Btn_delete_account_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Do you want to delete your account?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ask == DialogResult.Yes)
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

        private void Btn_Log_out_staff_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Do you want to log out your account?", "Logout account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(ask == DialogResult.Yes)
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

        private void Btn_view_current_order_Click(object sender, EventArgs e)
        {
            string countQuery = "SELECT COUNT(*) FROM Current_order";
            SqlCommand cmd = new SqlCommand(countQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                int orderCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (orderCount == 0)
                {
                    MessageBox.Show("Now current order is empty.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                View_Current_order vco = new View_Current_order(welcome_name, USER_NAME);
                vco.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void View_order_history_Click(object sender, EventArgs e)
        {
            string countQuery = "SELECT COUNT(*) FROM Order_history";
            SqlCommand cmd = new SqlCommand(countQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                int orderCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (orderCount == 0)
                {
                    MessageBox.Show("Order history is empty.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                View_order_history voh = new View_order_history(welcome_name, USER_NAME);
                voh.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }
    }
}
