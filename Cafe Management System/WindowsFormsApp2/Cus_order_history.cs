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
    public partial class Cus_order_history: Form
    {
        private string welcome_name;
        private string uname;
        public Cus_order_history(string name, string USERNAME)
        {
            InitializeComponent();
            welcome_name = name;
            uname = USERNAME;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void Cus_order_history_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Order_history Where Username = '" + uname +"'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_cus_order_history.DataSource = dt;
            dataGridView_cus_order_history.Columns["Order_ID"].Visible = false;
            dataGridView_cus_order_history.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView_cus_order_history.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void btn_back_view_order_history_Click(object sender, EventArgs e)
        {
            Customer cm = new Customer(welcome_name, uname);
            cm.Show();
            this.Hide();
        }

        private void dataGridView_cus_order_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
