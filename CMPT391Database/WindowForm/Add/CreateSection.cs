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
    public partial class CreateSection : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");

        public CreateSection()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
                       con.Open();


            SqlTransaction trans;
            SqlCommand command = con.CreateCommand();
            trans = con.BeginTransaction("create_section_trans");

            command.Connection = con;
            command.Transaction = trans;

            command = new SqlCommand("section_insert", con, trans);

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = sectionid_input;
                command.Parameters.Add("@term", SqlDbType.NChar, 10).Value = term_input.Text;
                command.Parameters.Add("@year", SqlDbType.Int).Value = year_input.Value;
                command.Parameters.Add("@capacity", SqlDbType.Int).Value = capacity_input.Value;
                command.Parameters.Add("@classroom", SqlDbType.NChar, 10).Value = classroom_input.Text;
               // command.Parameters.Add("@time_id", SqlDbType.Int).Value = credits_input.Value;


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

        private void CreateSection_Load(object sender, EventArgs e)
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
