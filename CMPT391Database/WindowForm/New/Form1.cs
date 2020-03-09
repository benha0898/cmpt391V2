using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm.New
{
    public partial class Form1 : Form
    {
        int course_id;
        int section_id;
        string term = " ";
        int year = DateTime.Now.Year;
        public Form1()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            string queryString = "SELECT DISTINCT subject FROM course";


            SqlCommand command = new SqlCommand(queryString, con);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    course_dropdown.Items.Add(reader["subject"].ToString());
                }
            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            con.Close();
            /*
            term_dropdown.Items.Add("Fall").ToString();
            term_dropdown.Items.Add("Spring/Summer").ToString();
            term_dropdown.Items.Add("Winter").ToString();
            */
            
            term_dropdown.Items.Add("Fall " + year.ToString());
            term_dropdown.Items.Add("Winter " + year.ToString());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void studentid_input_Leave(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();

            string queryString = "SELECT first_name + ' ' + last_name AS full_name FROM student WHERE id=@id";
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@id", studentid_input.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    student_label.Text = reader["full_name"].ToString();
                    //Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                    //    reader.GetString(1));
                }

                // Print to console all the courses this student has taken
                string queryString2 = @"
                    SELECT c.subject as subject, c.level as level
                    FROM takes t, section s, course c
                    WHERE   t.student_id = @student_id AND
                            t.section_id = s.id AND
                            s.course_id = c.id";
                SqlCommand command2 = new SqlCommand(queryString2, con);
                command2.Parameters.AddWithValue("@student_id", studentid_input.Text);
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader.HasRows)
                {
                    Console.WriteLine("Courses student has taken: ");
                    while (reader2.Read())
                    {
                        Console.WriteLine(reader2["subject"] + " " + reader2["level"].ToString());
                    }
                }
                reader2.Close();
            }
            else
            {
                student_label.Text = "No student found";
            }
            reader.Close();
            con.Close();
        }


        private void course_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine(course_dropdown.SelectedItem.ToString());
            Console.WriteLine(term_dropdown.SelectedItem.ToString());
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            //string queryString = "SELECT course.level, section.term FROM course LEFT JOIN section ON course.id = section.course_id WHERE course.subject=@course AND section.term = @term";
            //query now retrieves by term by matching the fall,winter,summer/spring
            string queryString = @"
                SELECT id, level
                FROM course
                WHERE course.subject = @course;";
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@course", course_dropdown.SelectedItem.ToString());
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                course_list.Clear();
                while (reader.Read())
                {
                    ListViewItem course = new ListViewItem();
                    course.Tag = reader["id"];
                    course.Text = (course_dropdown.SelectedItem.ToString() + " " + reader["level"].ToString());
                    // TOTO -- Check for prereqs. Course is green if all prereqs are met; otherwise grey.
                    course.ForeColor = Color.Green;

                    course_list.Items.Add(course);
                    
                    //course_list.Focus();
                }

            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            con.Close();


        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(section_list.SelectedItems[0].Text);
            confirm_sectionlist.Items.Add(section_list.SelectedItems[0].Text);
            section_list.SelectedItems[0].Remove();


        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(confirm_sectionlist.SelectedItems[0].Text);
            section_list.Items.Add(confirm_sectionlist.SelectedItems[0].Text);
            confirm_sectionlist.SelectedItems[0].Remove();
        }

        private void course_list_Click(object sender, EventArgs e)
        {
            string[] split_var;
 
            if (course_list.SelectedItems.Count > 0)
            {
                course_id = (int) course_list.SelectedItems[0].Tag;
                Console.WriteLine("Course_Id: " + course_id.ToString());
            }

            split_var = term_dropdown.SelectedItem.ToString().Split();
            term = split_var[0];


            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            string queryString = @"
                SELECT section.id
                FROM section
                WHERE   course_id = @course_id AND
                        term = @term AND
                        year = @year";

            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@course_id", course_id);
            command.Parameters.AddWithValue("@term", term);
            command.Parameters.AddWithValue("@year", year);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                section_list.Clear();
                while (reader.Read())
                {
                    ListViewItem section = new ListViewItem();
                    section.Text = ("Section " + reader["id"].ToString());
                    // TODO -- Check for vacancy. Section is green if not full, grey if full.
                    section.ForeColor = Color.Green;

                    section_list.Items.Add(section);
                }
            }
            finally
            {
                // Always call Close when done reading.
                reader.Close();
            }
            con.Close();
        }
    }
}
