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
    public partial class CreateStudent : Form
    {
        
        public CreateStudent()
        {
            InitializeComponent();
        }
        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();

            
            SqlTransaction trans;
            SqlCommand command = con.CreateCommand();
            trans = con.BeginTransaction("create_student_trans");

            command.Connection = con;
            command.Transaction = trans;

            command = new SqlCommand("student_insert", con, trans);
            
            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@first_name", SqlDbType.NChar, 20).Value = first_name_input.Text;
                command.Parameters.Add("@last_name", SqlDbType.NChar, 20).Value = last_name_input.Text;
                command.Parameters.Add("@dob", SqlDbType.Date).Value = dob_datetime.Value;
                command.Parameters.Add("@street", SqlDbType.NChar, 20).Value = street_input.Text;
                command.Parameters.Add("@city", SqlDbType.NChar, 20).Value = city_input.Text;
                command.Parameters.Add("@province", SqlDbType.NChar, 20).Value = province_input.Text;
                command.Parameters.Add("@country", SqlDbType.NChar, 20).Value = country_input.Text;
                command.Parameters.Add("@postal", SqlDbType.NChar, 20).Value = postal_input.Text;
                command.Parameters.Add("@total_credits", SqlDbType.Int).Value = credits_input.Value;

                
                command.ExecuteNonQuery();
                
                trans.Commit();
                MessageBox.Show("Student Added.");
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