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

namespace WindowForm.New
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");

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
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            string queryString = "SELECT level FROM course WHERE subject=@course";
            SqlCommand command = new SqlCommand(queryString, con);
            command.Parameters.AddWithValue("@course", course_dropdown.SelectedItem.ToString());
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    course_list.Items.Add(course_dropdown.SelectedItem.ToString() + " " + reader["level"].ToString());
                    //need to do a another query here to check if student has required course in takes and if he does then
                    // it will be green color or red if not. Green indicates he is available to take this class and red means he cannot
                    //atm all items will be green
                    course_list.ForeColor = Color.Green;
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
    }
}
