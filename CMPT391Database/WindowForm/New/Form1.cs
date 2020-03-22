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
        int studentid;
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
            term_dropdown.Enabled = false;
            course_dropdown.Enabled = false;
            add_button.Enabled = false;
            remove_button.Enabled = false;
            submit_button.Enabled = false;
            drop_button.Enabled = false;
        }


        private void studentid_input_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(studentid_input.Text, out studentid))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True;MultipleActiveResultSets=True");
                con.Open();

                string queryString = "SELECT first_name + ' ' + last_name AS full_name FROM student WHERE id=@id";
                SqlCommand command = new SqlCommand(queryString, con);
                command.Parameters.AddWithValue("@id", studentid.ToString());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student_label.Text = reader["full_name"].ToString();
                        //Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        //    reader.GetString(1));
                    }
                    term_dropdown.Enabled = true;

                    // Print to console all the courses this student has taken
                    show_course_list();
                }
                else
                {
                    student_label.Text = "No student found";
                }
                reader.Close();
                con.Close();
            }
            else
            {
                student_label.Text = "Please Enter Student ID";
            }
        }

        private void show_course_list()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();

            course_view.Items.Clear();

            string queryString = @"
                        SELECT c.subject as subject, c.level as level, s.id as section, s.term as term, s.year as year
                        FROM takes t, section s, course c
                        WHERE   t.student_id = @student_id AND
                                t.section_id = s.id AND
                                s.course_id = c.id AND
                                s.year = @year
                        ORDER BY year DESC, term, subject, level, section;";
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@student_id", studentid_input.Text);
            command.Parameters.AddWithValue("@year", year.ToString());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("Courses student has taken: ");
                while (reader.Read())
                {
                    course_view.Items.Add(reader["subject"] + " \t" + reader["level"].ToString() + "\t" + reader["section"].ToString() + "\t" + reader["term"].ToString() + "\t" + reader["year"].ToString());
                }
            }
            reader.Close();
            con.Close();
        }

        private void term_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] split_var = term_dropdown.SelectedItem.ToString().Split();
            term = split_var[0];
            if (!course_dropdown.Enabled)
                course_dropdown.Enabled = true;
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

        private void course_list_Click(object sender, EventArgs e)
        {
            if (course_list.SelectedItems.Count > 0)
            {
                course_id = (int)course_list.SelectedItems[0].Tag;
                Console.WriteLine("Course_Id: " + course_id.ToString());
            }

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True;MultipleActiveResultSets=True");
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
                    // For each section, check for vacancy
                    string queryString2 = "SELECT vacancies FROM section WHERE id = @id";
                    SqlCommand command2 = new SqlCommand(queryString2, con);
                    command2.Parameters.AddWithValue("@id", reader["id"].ToString());
                    SqlDataReader reader2 = command2.ExecuteReader();
                    try
                    {
                        ListViewItem section = new ListViewItem();
                        section.Text = ("Section " + reader["id"].ToString());
                        section.Tag = new int[] {course_id, (int) reader["id"]};
                        while (reader2.Read())
                        {
                            if ((int)reader2["vacancies"] <= 0)
                            {
                                section.ForeColor = Color.Red;
                            }
                            else
                            {
                                section.ForeColor = Color.Green;
                            }
                        }
                        section_list.Items.Add(section);
                    }
                    finally
                    {
                        // Close reader
                        reader2.Close();
                    }
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
            ListViewItem item = (ListViewItem)section_list.SelectedItems[0].Clone();
            section_list.SelectedItems[0].ForeColor = Color.Gray;
            section_list.SelectedItems[0].Selected = false;
            confirm_sectionlist.Items.Add(item);

            if (!submit_button.Enabled)
                submit_button.Enabled = true;
            add_button.Enabled = false;
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine(confirm_sectionlist.SelectedItems[0].Text);
            ListViewItem item = confirm_sectionlist.SelectedItems[0];
            confirm_sectionlist.SelectedItems[0].Remove();
            item.Selected = false;
            ListViewItem item1 = section_list.FindItemWithText(item.Text);
            if (item1 != null)
            {
                item1.ForeColor = Color.Green;
            }

            if (confirm_sectionlist.Items.Count == 0)
                submit_button.Enabled = false;
            remove_button.Enabled = false;
        }

        private void section_list_MouseClick(object sender, MouseEventArgs e)
        {
            if (section_list.SelectedItems.Count > 0)
            {
                if (section_list.SelectedItems[0].ForeColor == Color.Green)
                    add_button.Enabled = true;
                else
                    add_button.Enabled = false;
            }
        }

        private void confirm_sectionlist_MouseClick(object sender, MouseEventArgs e)
        {
            remove_button.Enabled = true;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();

            SqlCommand command = con.CreateCommand();
            SqlCommand command2 = con.CreateCommand();

            foreach (ListViewItem item in confirm_sectionlist.Items)
                // Check if student has the prereqs, and if they are already enrolled
            {
                Console.WriteLine(item.Text);
                string queryString = @"
                    IF NOT EXISTS (
                        SELECT p.prereq
                        FROM prereq p, section s
                        WHERE   p.course = @CourseId AND
                                s.id NOT IN (
                                    SELECT s.id FROM takes t
                                    WHERE   t.student_id = @StudentId AND
                                            s.id = t.section_id) AND
                                p.prereq = s.course_id)
                    BEGIN
                        IF NOT EXISTS (
                            SELECT section_id
                            FROM takes
                            WHERE   student_id = @StudentId AND
                                    section_id = @SectionId)
                        BEGIN
                            SELECT 1 as result;
                        END
                        ELSE
                        BEGIN
                            SELECT 2 as result;
                        END
                    END
                    ELSE
                    BEGIN
                        SELECT 3 as result;
                    END";
                command = new SqlCommand(queryString, con);
                command.Parameters.AddWithValue("@CourseId", ((int[])item.Tag)[0]);
                command.Parameters.AddWithValue("@StudentId", studentid);
                command.Parameters.AddWithValue("@SectionId", ((int[])item.Tag)[1]);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int result = (int)reader["result"];
                reader.Close();
                switch (result)
                {
                    case 1:
                        SqlTransaction trans;
                        trans = con.BeginTransaction("add_course_trans");

                        command2.Connection = con;
                        command2.Transaction = trans;
                        try
                        {
                            string queryString2 = @"
                                INSERT INTO takes (student_id, section_id)
                                VALUES (
                                    @StudentId,
                                    @SectionId);
                                UPDATE section
                                SET vacancies = vacancies - 1
                                WHERE id = @SectionId";


                            command2 = new SqlCommand(queryString2, con, trans);
                            command2.Parameters.AddWithValue("@StudentId", studentid);
                            command2.Parameters.AddWithValue("@SectionId", ((int[])item.Tag)[1]);
                            command2.ExecuteNonQuery();

                            trans.Commit();

                            MessageBox.Show("Success! Course Added.");
                            confirm_sectionlist.Clear();

                            show_course_list();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                            Console.WriteLine(" Message: {0}", ex.Message);
                        }
                        try
                        {
                            trans.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            Console.WriteLine("Commit Exception Type: {0}", ex2.GetType());
                            Console.WriteLine(" Message: {0}", ex2.Message);
                        }
                        break;
                    case 2:
                        MessageBox.Show("FAIL - You are already enrolled in this class.");
                        break;
                    case 3:
                        MessageBox.Show("FAIL - You don't have all the required prerequisites.");
                        break;
                }
                reader.Close();
            }
            con.Close();
        }

        private void course_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (course_view.SelectedItems.Count > 0)
                drop_button.Enabled = true;
            else
                drop_button.Enabled = false;
        }

        private void drop_button_MouseClick(object sender, MouseEventArgs e)
        {
            string[] split_string = course_view.SelectedItem.ToString().Split('\t');
            /*
            for (int i = 0; i< split_string.Length; i++)
            {
                Console.WriteLine(split_string[i]);
            }
            */
            string section = split_string[2];

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            SqlCommand command = con.CreateCommand();
            SqlTransaction trans;
            trans = con.BeginTransaction("drop_course_trans");

            command.Connection = con;
            command.Transaction = trans;

            try
            {
                string queryString = @"
                DELETE FROM takes WHERE section_id = @section_id;
                UPDATE section SET vacancies = vacancies + 1 WHERE id = @section_id;";

                command = new SqlCommand(queryString, con, trans);
                command.Parameters.AddWithValue("@section_id", section);
                command.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Course Dropped!");

                show_course_list();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine(" Message: {0}", ex.Message);
            }
            try
            {
                trans.Rollback();
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex2.GetType());
                Console.WriteLine(" Message: {0}", ex2.Message);
            }


        }
    }
}
