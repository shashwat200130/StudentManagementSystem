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
using System.IO;

namespace StudentManagementSystem
{
    public partial class AddStudents : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shashwat\Documents\student.mdf;Integrated Security=True;Connect Timeout=30");
        public AddStudents()
        {
            InitializeComponent();

            displayStudentData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addStudent_id.Text = row.Cells[1].Value.ToString();
                addStudent_fullName.Text = row.Cells[2].Value.ToString();
                addStudent_gender.Text = row.Cells[3].Value.ToString();
                addStudent_phoneNum.Text = row.Cells[4].Value.ToString();
                addStudent_status.Text = row.Cells[8].Value.ToString();
            }
        }

        public void clearFields()
        {
            addStudent_id.Text = "";
            addStudent_fullName.Text = "";
            addStudent_gender.SelectedIndex = -1;
            addStudent_phoneNum.Text = "";
            addStudent_status.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayStudentData();
        }

        public void displayStudentData()
        {
            StudentData ed = new StudentData();
            List<StudentData> listData = ed.studentListData();

            dataGridView1.DataSource = listData;
        }

        private void addStudent_addbtn_Click(object sender, EventArgs e)
        {
            if (addStudent_id.Text == ""
                || addStudent_fullName.Text == ""
                || addStudent_gender.Text == ""
                || addStudent_phoneNum.Text == ""
                || addStudent_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addStudent_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addStudent_id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                    "(employee_id, full_name, gender, contact_number" +
                                    " ,insert_date, status) " +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum" +
                                    ", @insertDate, @status)";

                                string path = Path.Combine(@"C:\Users\shashwat\source\repos\StudentManagementSystem\StudentManagementSystem\Directory\"
                                    + addStudent_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }


                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addStudent_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addStudent_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addStudent_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addStudent_phoneNum.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addStudent_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayStudentData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
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

        private void addStudent_importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addStudent_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addStudent_picture_Click(object sender, EventArgs e)
        {

        }

        private void addStudent_updatebtn_Click(object sender, EventArgs e)
        {
            if (addStudent_id.Text == ""
                || addStudent_fullName.Text == ""
                || addStudent_gender.Text == ""
                || addStudent_phoneNum.Text == ""
                || addStuden_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Student ID: " + addStudent_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE students SET full_name = @fullName" +
                            ", gender = @gender, contact_number = @contactNum" +
                            ", update_date = @updateDate, status = @status " +
                            "WHERE student_id = @studentID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName", addStudent_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addStudent_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", addStudent_phoneNum.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addStudent_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addStudent_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayStudentData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void addStudent_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addStudent_deletebtn_Click(object sender, EventArgs e)
        {
            if (addStudent_id.Text == ""
                || addStudent_fullName.Text == ""
                || addStudent_gender.Text == ""
                || addStudent_phoneNum.Text == ""
                || addStudent_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Student ID: " + addStudent_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE students SET delete_date = @deleteDate " +
                            "WHERE student_id = @studentID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@studentID", addStudent_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayStudentData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}