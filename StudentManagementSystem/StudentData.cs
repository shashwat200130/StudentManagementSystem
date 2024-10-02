using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    internal class StudentData
    {


        public int ID { set; get; } // 0
        public string StudentID { set; get; } // 1
        public string Name { set; get; } // 2
        public string Gender { set; get; } // 3
        public string Contact { set; get; } // 4
        public string Image { set; get; } // 6
        public int UID { set; get; } // 7
        public string Status { set; get; } // 8



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shashwat\Documents\student.mdf;Integrated Security=True;Connect Timeout=30");

        public List<StudentData> studentListData()
        {
            List<StudentData> listdata = new List<StudentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM students WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            StudentData ed = new StudentData();
                            ed.ID = (int)reader["id"];
                            ed.StudentID = reader["student_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.UID = (int)reader["uid"];
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

        public List<StudentData> UidStudentListData()
        {
            List<StudentData> listdata = new List<StudentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            StudentData ed = new StudentData();
                            ed.StudentID = reader["student_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.UID = (int)reader["uid"];

                            listdata.Add(ed);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
