using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    internal class UIDdata
    {
        
        public string StudentID { set; get; } // 0
        public string Name { set; get; } // 1
        public string Gender { set; get; } //2
        public string Contact {  set; get; } //3
        public int UID { set; get; } // 4

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shashwat\Documents\student.mdf;Integrated Security=True;Connect Timeout=30");

        public List<UIDdata> UidStudentListData()
        {
            List<UIDdata> listdata = new List<UIDdata>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE status = 'Active' " +
                        "AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            UIDdata ed = new UIDdata();
                            ed.StudentID = reader["student_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact"].ToString();
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
