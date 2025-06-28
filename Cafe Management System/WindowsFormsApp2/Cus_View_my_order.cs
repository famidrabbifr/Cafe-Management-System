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
    public partial class Cus_View_my_order: Form
    {
        private string welcome_name;
        private string uname;
        public Cus_View_my_order(string name, string USERNAME)
        {
            InitializeComponent();
            welcome_name = name;
            uname = USERNAME;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private string Get_Item_list(string uname)
        {
            string Items = null;

            string name_query = "SELECT Selected_Items FROM Current_order WHERE Username = '" + uname + "'";

            using (SqlCommand cmd = new SqlCommand(name_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    Items = result.ToString();
                }
            }

            return Items;
        }

        private string Get_Total_price(string uname)
        {
            string price = null;

            string name_query = "SELECT Total_Price FROM Current_order WHERE Username = '" + uname + "'";

            using (SqlCommand cmd = new SqlCommand(name_query, con))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    price = result.ToString();
                }
            }

            return price;
        }
        private void Cus_View_my_order_Load(object sender, EventArgs e)
        {
            TextBox_name.Text = welcome_name;
            richTextBox_selected_items.Text = Get_Item_list(uname);
            textBox_Total_price.Text = Get_Total_price(uname);
        }

        private void btn_back_cus_view_order_Click(object sender, EventArgs e)
        {
            Customer cm = new Customer(welcome_name, uname);
            cm.Show();
            this.Hide();
        }

        private void richTextBox_selected_items_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
