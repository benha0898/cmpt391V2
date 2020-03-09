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
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
        string[] item;
        string subject = " ";
        string level = " ";
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
            term_dropdown.Items.Add("Fall").ToString();
            term_dropdown.Items.Add("Spring/Summer").ToString();
            term_dropdown.Items.Add("Winter").ToString();
            /*
             term_dropdown.Items.Add("Fall " + DateTime.Now.Year.ToString());
            term_dropdown.Items.Add("Spring/Summer " + DateTime.Now.Year.ToString());
            term_dropdown.Items.Add("Winter " + DateTime.Now.Year.ToString());
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void textBox1_Leave(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
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
            string queryString = "SELECT DISTINCT p.* FROM( SELECT level, term FROM course RIGHT JOIN section on course.id = section.course_id where course.subject = @course and section.term = @term)p; ";
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@term", term_dropdown.SelectedItem.ToString());
            command.Parameters.AddWithValue("@course", course_dropdown.SelectedItem.ToString());
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                course_list.Clear();
                while (reader.Read())
                {
                    course_list.Items.Add(course_dropdown.SelectedItem.ToString() + " " + reader["level"].ToString());
                    //need to do a another query here to check if student has required course in takes and if he does then
                    // it will be green color or red if not. Green indicates he is available to take this class and red means he cannot
                    //atm all items will be green
                    course_list.ForeColor = Color.Green;
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
            Console.WriteLine(course_list.SelectedItems[0].Text);
            confirm_courselist.Items.Add(course_list.SelectedItems[0].Text);
            //will have to check pre req here
            course_list.SelectedItems[0].Remove();


        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(confirm_courselist.SelectedItems[0].Text);
            course_list.Items.Add(confirm_courselist.SelectedItems[0].Text);
            confirm_courselist.SelectedItems[0].Remove();
        }

        private void course_list_DoubleClick(object sender, EventArgs e)
        {

            int index = 0;
            
            string var;
            /* if (course_list.SelectedItems.Count > 0)
             {
                 Console.WriteLine(course_list.SelectedItems[0].SubItems[0].Text);
             }*/

            if (index >= 0) {
                if (course_list.SelectedItems.Count > 0)
                {
                    var = course_list.SelectedItems[0].SubItems[0].Text;
                    Console.WriteLine(var); //acct 101
                    item = var.Split(' ');

                    subject = item[0].ToString();
                    level = item[7].ToString();
                    
                }
            }
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            string queryString = "SELECT section.id FROM course LEFT JOIN section ON course.id = section.course_id WHERE course.subject=@subject AND course.level=@level";

            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@subject", subject);
            command.Parameters.AddWithValue("@level", level);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                
                if (index == 0)
                {   
                    //remove the sections -----TODO----------------
                    foreach (ListViewItem eachItem in course_list.SelectedItems)
                    {
                        Match match = Regex.Match(eachItem.Text, @"Section +", RegexOptions.IgnoreCase);
                        if (match.Success)
                        {
                            course_list.Items.Remove(eachItem);
                        }
                    }
                    while (reader.Read())
                    {

                        course_list.Items.Add("Section " + reader["id"].ToString());
                    }
                    index += 1;
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
