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

namespace DataWarehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int i;
            course_leveldrop.Items.Add("");
            course_leveldrop.Items.Add("100");
            course_leveldrop.Items.Add("200");
            course_leveldrop.Items.Add("300");
            course_leveldrop.Items.Add("400");
            semester_semdrop.Items.Add("");
            semester_semdrop.Items.Add("Fall");
            semester_semdrop.Items.Add("Spring/Summer");
            semester_semdrop.Items.Add("Winter");

            semester_yeardrop.Items.Add("");
            for (i = year - 10; i <= year; i++) {
                semester_yeardrop.Items.Add(i.ToString());
            }

            course_subjectdrop.Items.Add("");
            readCourse();
            readDepartment();
            readDepartment2();

        }

        private void readDepartment2()
        {
            instructor_facdrop.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            string queryString = "SELECT DISTINCT faculty FROM departmentWH";
            instructor_facdrop.Items.Add("");
            SqlCommand command = new SqlCommand(queryString, con);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    instructor_facdrop.Items.Add(reader["faculty"].ToString());
                }
            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            con.Close();
        }

        private void readDepartment()
        {
            instructor_deptdrop.Items.Clear();
            course_deptdrop.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            string queryString = "SELECT department FROM departmentWH";
            instructor_deptdrop.Items.Add("");
            course_deptdrop.Items.Add("");
            SqlCommand command = new SqlCommand(queryString, con);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    instructor_deptdrop.Items.Add(reader["department"].ToString());
                    course_deptdrop.Items.Add(reader["department"].ToString());
                }
            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            con.Close();
        }

        private void readCourse()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            string queryString = "SELECT DISTINCT subject FROM courseWH";

            SqlCommand command = new SqlCommand(queryString, con);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    course_subjectdrop.Items.Add(reader["subject"].ToString());
                }
            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            con.Close();
        }

        private void instructor_facdrop_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!instructor_facdrop.SelectedItem.ToString().Equals(""))
            {
                instructor_deptdrop.Enabled = false;
            } else
            {
                instructor_deptdrop.Enabled = true;
            }


        }

        private void instructor_deptdrop_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!instructor_deptdrop.SelectedItem.ToString().Equals(""))
            {
                instructor_facdrop.Items.Clear();
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
                con.Open();

                string queryString = "SELECT faculty FROM departmentWH WHERE department=@department";
                SqlCommand command = new SqlCommand(queryString, con);
                command.Parameters.AddWithValue("@department", instructor_deptdrop.SelectedItem.ToString());
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        instructor_facdrop.Items.Add(reader["faculty"].ToString());
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
                con.Close();
            } else
            {
                instructor_facdrop.Items.Clear();
                readDepartment2();
            }
            
        }
    }
}
