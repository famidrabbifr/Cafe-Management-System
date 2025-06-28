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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Cus_view_menu: Form
    {
        private string welcome_name;
        private string uname;
        public Cus_view_menu(string name, string USERNAME)
        {
            InitializeComponent();
            welcome_name = name;
            uname = USERNAME;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5A3PSSU\SQLEXPRESS;Initial Catalog=CafeManagementSystemDB;Integrated Security=True;TrustServerCertificate=True");

        private void rd_btn_breakfast_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Breakfast & Snacks'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_main_dish_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Main Dishes'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_salad_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Salads & Sides'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_desserts_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Desserts'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void rd_btn_coffee_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Category = 'Coffee & Beverages'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void textBox_item_search_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Items, Price FROM Items_list WHERE Items like '%" + textBox_item_search.Text.Trim() + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView_Category.DataSource = dt;
            dataGridView_Category.Columns["Items"].Width = 183;
            dataGridView_Category.Columns["Price"].Width = 73;
        }

        private void dataGridView_selected_items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_select_item_Click(object sender, EventArgs e)
        {
            if (dataGridView_Category.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item first.");
                return;
            }

            string itemName = dataGridView_Category.SelectedRows[0].Cells["Items"].Value.ToString();
            string priceTxt = dataGridView_Category.SelectedRows[0].Cells["Price"].Value.ToString();

            if (!int.TryParse(priceTxt, out int price))
            {
                MessageBox.Show("Invalid price data.");
                return;
            }

            string insertQuery = "INSERT INTO Selected_Item_list (Username, Items, Price) VALUES ('"+ uname + "', '" + itemName + "', " + price + ")";

            SqlCommand cmd = new SqlCommand(insertQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //MessageBox.Show("Item added!")
                    LoadSelectedItems();
                }
                else
                {
                    MessageBox.Show("Failed to add item.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }
        private void LoadSelectedItems()
        {
            string query = "SELECT Selected_ID, Items, Price " + "FROM Selected_Item_list WHERE Username = '" + uname + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView_selected_items.DataSource = dt;

            dataGridView_selected_items.Columns["Items"].Width = 183;
            dataGridView_selected_items.Columns["Price"].Width = 73;

            dataGridView_selected_items.Columns["Selected_ID"].Visible = false;

            UpdateTotalPrice();
        }


        private void Btn_remove_item_Click(object sender, EventArgs e)
        {
            if (dataGridView_selected_items.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }

            // Just Read ID
            string idTxt = dataGridView_selected_items.SelectedRows[0].Cells["Selected_ID"].Value.ToString();

            if (!int.TryParse(idTxt, out int selectedId))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            DialogResult ask = MessageBox.Show("Remove selected item?","Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask != DialogResult.Yes) return;

            string deleteQuery = "DELETE FROM Selected_Item_list WHERE Selected_ID = " + selectedId;
            SqlCommand cmd = new SqlCommand(deleteQuery, con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //MessageBox.Show("Item removed!");
                    LoadSelectedItems();
                }
                else
                {
                    MessageBox.Show("Remove failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void UpdateTotalPrice()
        {
            string sumQuery = "SELECT ISNULL(SUM(Price),0) FROM Selected_Item_list " + "WHERE Username = '" + uname + "'";

            SqlCommand cmd = new SqlCommand(sumQuery, con);

            if (con.State == ConnectionState.Closed) con.Open();
            object result = cmd.ExecuteScalar();
            int total = Convert.ToInt32(result);

            textBox_total_price.Text = total.ToString();
        }

        private void textBox_total_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_confirm_order_Click(object sender, EventArgs e)
        {
            if (dataGridView_selected_items.Rows.Count == 0)
            {
                MessageBox.Show("No items in cart.");
                return;
            }

            List<string> itemsList = new List<string>();
            foreach (DataGridViewRow row in dataGridView_selected_items.Rows)
            {
                if (row.IsNewRow) continue;

                itemsList.Add(row.Cells["Items"].Value.ToString());
            }
            string selectedItems = string.Join(", ", itemsList);

            if (!int.TryParse(textBox_total_price.Text, out int totalPrice))
            {
                MessageBox.Show("Total price invalid.");
                return;
            }

            string insertOrder = "INSERT INTO Current_order " + "(Username, Name, Selected_Items, Total_Price) VALUES ('" + uname + "', '" + welcome_name + "', '" + selectedItems + "', " + totalPrice + ")";

            SqlCommand cmd = new SqlCommand(insertOrder, con);

            try
            {
                if (con.State == ConnectionState.Closed) con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Order confirmed! Thank you.");

                    string clearCart = "DELETE FROM Selected_Item_list WHERE Username = '" + uname + "'";
                    new SqlCommand(clearCart, con).ExecuteNonQuery();

                    LoadSelectedItems();
                }
                else
                {
                    MessageBox.Show("Order could not be saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void Btn_cancel_order_Click(object sender, EventArgs e)
        {
            string countQuery = "SELECT COUNT(*) FROM Current_order WHERE Username = '" + uname + "'";
            SqlCommand countCmd = new SqlCommand(countQuery, con);

            if (con.State == ConnectionState.Closed) con.Open();
            int orderCount = Convert.ToInt32(countCmd.ExecuteScalar());

            if (orderCount == 0)
            {
                MessageBox.Show("You have no order to cancel.", "Cancel order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult ask = MessageBox.Show(
                "Are you sure you want to cancel your current order?",
                "Cancel Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ask != DialogResult.Yes) return;

            string deleteOrder = "DELETE FROM Current_order WHERE Username = '" + uname + "'";
            SqlCommand delCmd = new SqlCommand(deleteOrder, con);

            try
            {
                int rows = delCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Order cancelled successfully.","Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancel failed (order not found).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
            }
        }

        private void btn_back_cus_view_menu_Click(object sender, EventArgs e)
        {
            Customer cm = new Customer(welcome_name, uname);
            cm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
