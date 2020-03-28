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

        int course_subject = 0;
        int course_level = 0;
        int course_department = 0;

        int instructor_faculty = 0;
        int instructor_dept = 0;

        int semester_term = 0;
        int semester_year = 0;

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
            setIndex();

        }

        private void setIndex()
        {
            course_subjectdrop.SelectedIndex = 0;
            course_leveldrop.SelectedIndex = 0;
            course_deptdrop.SelectedIndex = 0;

            instructor_deptdrop.SelectedIndex = 0;
            instructor_facdrop.SelectedIndex = 0;

            semester_semdrop.SelectedIndex = 0;
            semester_yeardrop.SelectedIndex = 0;
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

        private void submit_button_Click(object sender, EventArgs e)
        {
            querylabel.Text = "";
            string query = "SELECT ";
            string query2 = " FROM UniversityWH as U ";
            string level = "";
            string course_join = "";
            string department_join = "";
            string instructor_join = "";
            string semester_join = "";

            int where = 0;
            string where_term = "";
            string where_year = "";
            string where_department = "";
            string where_subject = "";
            string where_faculty = "";

            check_variables();

            //course
            if (course_subject == 1 || course_level == 1)
            {
                query = query + "U.student_id, U.course_id ";
                course_join = "JOIN courseWH as C ON U.course_id = C.course_id ";
                if (course_subject == 1)
                {
                    where_subject = "C.subject = @subject AND ";
                    where++;
                }
                if (course_level == 1)
                {
                    string newlevel = (Convert.ToInt32(course_leveldrop.SelectedItem) + 99).ToString();
                    level = "AND C.level BETWEEN " + course_leveldrop.SelectedItem.ToString() + " AND " + newlevel + " " ;
                }
            }

            //department and instructor
            if (course_department == 1 || instructor_faculty ==  1)
            {
                if (query.Equals("SELECT "))
                {
                    query = query + "U.dept_id ";
                } else
                {
                    query = query + ", U.dept_id";
                }
                department_join = "JOIN departmentWH as D ON U.dept_id = D.dept_id ";
                
                if (course_department == 1)
                {
                    where_department = "D.department = @department AND ";
                    where++;
                }
                if (instructor_faculty == 1)
                {
                    where_faculty = "D.faculty = @faculty AND ";
                    where++;
                }

            }

            if (instructor_faculty == 1)
            {
                if (query.Equals("SELECT "))
                {
                    query = query + "U.instructor_id ";
                }
                else
                {
                    query = query + ", U.instructor_id";
                }
            }



            //semester
            if (semester_year == 1 || semester_term == 1)
            {
                if (query.Equals("SELECT "))
                {
                    query = query + "U.semester_id ";
                } else
                {
                    query = query + ", U.semester_id";
                }
                semester_join = "JOIN semesterWH as S ON s.semester_id = U.semester_id";

                if (semester_term == 1)
                {
                    where_term = "S.term = @term AND ";
                    where++;
                }
                if (semester_year == 1)
                {
                    where_year = "S.year = @year AND ";
                    where++;
                }

            }
            query = query + query2 + "\n" + course_join + "\n" + level + "\n" + department_join + "\n" + semester_join + "\n";
            
            if (where >= 1)
            {
                query = query + " WHERE " +  where_subject + where_department + where_term + where_year + where_faculty;
                query = query.Substring(0, query.Length -4);

            }

            querylabel.Text = query;
            
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand(query, con);

            if (!where_subject.Equals(""))
            {
                command.Parameters.AddWithValue("@subject", course_subjectdrop.SelectedItem.ToString());
            }
            if (!where_department.Equals(""))
            {
                command.Parameters.AddWithValue("@department", course_deptdrop.SelectedItem.ToString());
            }
            if (!where_term.Equals(""))
            {
                command.Parameters.AddWithValue("@term", semester_semdrop.SelectedItem.ToString());
            }
            if (!where_year.Equals(""))
            {
                command.Parameters.AddWithValue("@year", semester_yeardrop.SelectedItem.ToString());
            }
            if (!where_faculty.Equals(""))
            {
                command.Parameters.AddWithValue("@faculty", instructor_facdrop.SelectedItem.ToString());
            }

            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(command);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            results_grid.DataSource = dtRecord;
            count_label.Text = dtRecord.Rows.Count.ToString();
            con.Close();
            Console.WriteLine(query);
            

        }

        private void check_variables()
        {

            course_subject = (!course_subjectdrop.SelectedItem.ToString().Equals("")) ? course_subject = 1 : course_subject = 0;
            course_level = (!course_leveldrop.SelectedItem.ToString().Equals("")) ? course_level = 1 : course_level = 0;
            course_department = (!course_deptdrop.SelectedItem.ToString().Equals("")) ? course_department = 1 : course_department = 0;


            instructor_faculty = (!instructor_facdrop.SelectedItem.ToString().Equals("")) ? instructor_faculty = 1 : instructor_faculty = 0;
            
            //instructor_dept = (!instructor_deptdrop.SelectedItem.ToString().Equals("")) ? instructor_dept = 1 : instructor_dept = 0;
            

            semester_term = (!semester_semdrop.SelectedItem.ToString().Equals("")) ? semester_term = 1 : semester_term = 0;
            semester_year = (!semester_yeardrop.SelectedItem.ToString().Equals("")) ? semester_year = 1 : semester_year = 0;
            Console.WriteLine(instructor_faculty);
            /*
            Console.WriteLine(course_subject);
            Console.WriteLine(course_level);
            Console.WriteLine(course_department);


            Console.WriteLine(instructor_faculty);
            Console.WriteLine(instructor_dept);

            Console.WriteLine(semester_term);
            Console.WriteLine(semester_year);*/
        }

    }
}
