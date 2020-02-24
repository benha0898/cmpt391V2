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
                con.Open();
                SqlCommand sc = new SqlCommand("select (dept_name) from department", con);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("dept_name", typeof(string));
                dt.Load(reader);
                DepartmentCombobox.ValueMember = "dept_name";
                DepartmentCombobox.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
