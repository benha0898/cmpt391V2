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
    public partial class CreateDepartment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");

        public CreateDepartment()
        {
            InitializeComponent();
        }

        private void CreateDepartment_Load(object sender, EventArgs e)
        {
            try
            {
                instructor_input.Enabled = false;
                con.Open();
                //get all departments
                SqlCommand sc = new SqlCommand("select (dept_name) from department", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("dept_name", typeof(string));
                dt.Load(reader);
                DepartmentCombobox.ValueMember = "dept_name";
                DepartmentCombobox.DataSource = dt;
                con.Close();

                /*//get all instructors
                con.Open();
                SqlCommand cs = new SqlCommand("select (first_name) from instructor", con);
                SqlDataReader read;
                read = cs.ExecuteReader();
                DataTable td = new DataTable();
        
                td.Columns.Add("first_name", typeof(string));
                td.Load(read);
                instructor_input.ValueMember = "first_name";
                instructor_input.DataSource = td.Rows;

                con.Close();
                */
            }
            catch (Exception)
            {

            }
        }

        private void DepartmentCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get all instructors
            instructor_input.Enabled = true;
            try
            {

                con.Open();
                SqlCommand cs = new SqlCommand("select (first_name) from instructor", con);
                SqlDataReader read;
                read = cs.ExecuteReader();
                DataTable td = new DataTable();

                td.Columns.Add("first_name", typeof(string));
                td.Load(read);
                instructor_input.ValueMember = "first_name";
                instructor_input.DataSource = td;

                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void add_dept_button_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlTransaction trans;
            SqlCommand command = con.CreateCommand();
            trans = con.BeginTransaction("create_department_trans");

            command.Connection = con;
            command.Transaction = trans;

            command = new SqlCommand("Department_insert", con, trans);

            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@dept_name", SqlDbType.NChar, 100).Value = dept_name_input.Text;
                command.Parameters.Add("@building", SqlDbType.Int).Value = building_input.Value;
                command.Parameters.Add("@dept_head", SqlDbType.Int).Value = instructor_input;
               

                command.ExecuteNonQuery();

                trans.Commit();
                MessageBox.Show("Department Added.");
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
    }
}
