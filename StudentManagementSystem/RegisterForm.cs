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

namespace StudentManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shashwat\Documents\student.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_login_btn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(register_username.Text == "" ||  register_password.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        //To check if user already existing

                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", register_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " is already taken ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } 
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users (username, password, date_register) VALUES (@username, @password, @dateReg)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                           

                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                 , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            
        }
    }
}
