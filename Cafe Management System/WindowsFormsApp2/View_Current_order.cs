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
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class View_Current_order: Form
    {
        private string welcome_name;
        private string uname;
        public View_Current_order(string name, string USERNAME)
        {
            InitializeComponent();
            welcome_name = name;
            uname = USERNAME;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void View_Current_order_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Current_Order";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Current_order.DataSource = dt;
            dataGridView_Current_order.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView_Current_order.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
        }

        private void Btn_order_served_Click(object sender, EventArgs e)
        {
            if (dataGridView_Current_order.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dataGridView_Current_order.SelectedRows[0];

            string userName = row.Cells["Username"].Value.ToString();
            string customerName = row.Cells["Name"].Value.ToString();
            string selectedItems = row.Cells["Selected_Items"].Value.ToString();
            string totalPriceTxt = row.Cells["Total_Price"].Value.ToString();

            if (!int.TryParse(totalPriceTxt, out int totalPrice))
            {
                MessageBox.Show("Invalid total price value.");
                return;
            }

            DialogResult ask = MessageBox.Show("Mark this order as served?", "Order Served", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask != DialogResult.Yes) return;

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                string insertHistory = "INSERT INTO Order_history " + "(Username, Name, Selected_Items, Total_Price) VALUES ('" + userName + "', '" + customerName + "', '" + selectedItems + "', " + totalPrice + ")";

                string deleteCurrent = "DELETE FROM Current_order " + "WHERE Username = '" + userName + "' " + "AND   Selected_Items = '" + selectedItems + "' " + "AND   Total_Price = " + totalPrice;

                SqlCommand cmdInsert = new SqlCommand(insertHistory, con);
                SqlCommand cmdDelete = new SqlCommand(deleteCurrent, con);

                int insRows = cmdInsert.ExecuteNonQuery();
                int delRows = cmdDelete.ExecuteNonQuery();

                if (insRows > 0 && delRows > 0)
                {
                    MessageBox.Show("Order marked as served!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    View_Current_order_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to move order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void btn_back_view_current_order_Click(object sender, EventArgs e)
        {
            Staff sf = new Staff(welcome_name, uname);
            sf.Show();
            this.Hide();
        }

        private void dataGridView_Current_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
