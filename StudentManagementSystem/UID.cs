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

namespace StudentManagementSystem
{
    public partial class UID : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shashwat\Documents\student.mdf;Integrated Security=True;Connect Timeout=30");
        public UID()
        {
            InitializeComponent();
            displayStudents();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayStudents();
            disableFields();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void disableFields()
        {
            uid_employeeID.Enabled = false;
            uid_name.Enabled = false;
        }

        public void displayStudents()
        {
            StudentData ed = new StudentData();
            List<StudentData> listData = ed.UidStudentListData();
            dataGridView1.DataSource = listData;
        }

        private void uid_updatebtn_Click(object sender, EventArgs e)
        {
            if (uid_employeeID.Text == ""
                || uid_name.Text == ""
                || uid_position.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: "
                    + uid_studentID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE students SET salary = @uid" +
                                ", update_date = @updateData WHERE student_id = @studentID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@uid", uid_uid.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@studentID", uid_studentID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayStudents();

                                MessageBox.Show("Updated successfully!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
         }


        public void clearFields()
        {
            uid_studentID.Text = "";
            uid_name.Text = "";

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                uid_employeeID.Text = row.Cells[0].Value.ToString();
                uid_name.Text = row.Cells[1].Value.ToString();
                uid_position.Text = row.Cells[4].Value.ToString();
                uid_uid.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
