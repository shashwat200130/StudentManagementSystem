using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void addStudents1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addStudents1.Visible = false;
            uid1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void addStudent_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addStudents1.Visible = true;
            uid1.Visible = false;

            AddStudent addEmForm = addStudent1 as AddStudent;

            if (addEmForm != null)
            {
                addEmForm.RefreshData();

            }

            private void branch_button_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addStudents1.Visible = false;
            uid1.Visible = true;
        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
