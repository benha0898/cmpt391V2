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

namespace WindowForm.Add
{
    public partial class CreateCourse : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
        public CreateCourse()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlTransaction trans;
            SqlCommand command = con.CreateCommand();
            trans = con.BeginTransaction("create_course_trans");

            command.Connection = con;
            command.Transaction = trans;

            command = new SqlCommand("course_insert", con, trans);

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@subject", SqlDbType.NChar, 10).Value = subject_input.Text;
                command.Parameters.Add("@level", SqlDbType.Int, 20).Value = number_input.Value;
                command.Parameters.Add("@title", SqlDbType.NChar,30).Value = title_input.Text;
                command.Parameters.Add("@description", SqlDbType.NChar, 100).Value = description_input.Text;
                command.Parameters.Add("@dept", SqlDbType.NChar, 100).Value = dept_input.Text;
                command.Parameters.Add("@credit", SqlDbType.Int).Value = credits_input.Value;
                

                command.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Course Added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
            }
            try
            {
                trans.Rollback();
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                Console.WriteLine("  Message: {0}", ex2.Message);
            }
        }

        private void dept_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("select (dept_name) from department", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("dept_name", typeof(string));
                dt.Load(reader);
                dept_input.ValueMember = "dept_name";
                dept_input.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
