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
    public partial class CreateInstructor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");

        public CreateInstructor()
        {
            InitializeComponent();
        }

        private void CreateInstructor_Load(object sender, EventArgs e)
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
