using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AdminPanel
{
    public partial class Admin : Form
    {
        private string adminName;

        public Admin(string name)
        {
            InitializeComponent();
            adminName = name;

            
        }

        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Update_Menu K = new Admin_Update_Menu();
            K.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ChangePassword changep = new ChangePassword();
            changep.Show();

            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_Show_Pass o = new Admin_Show_Pass();
            o.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Admin_Admins_And_Customers op= new Admin_Admins_And_Customers();
            op.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Update_Staff staffForm = new Admin_Update_Staff();
            staffForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Admin_Update_Info updateForm = new Admin_Update_Info(adminName);
            updateForm.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
