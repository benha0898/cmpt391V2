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
        
        /*SqlCommand cmd = new SqlCommand("sorted_CreateStudent");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
        *///SqlDataAdapter adapter = new SqlDataAdapter("StudentInsert", con);
        public CreateStudent()
        {
            //open connection
            //con.Open();
            InitializeComponent();
        }
        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniversityDB;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("student_insert", con);
            adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
 
            adapt.SelectCommand.Parameters.Add("@first_name",SqlDbType.NChar,20).Value = first_name_input.Text;
            adapt.SelectCommand.Parameters.Add("@last_name",SqlDbType.NChar,20).Value = last_name_input.Text;
            adapt.SelectCommand.Parameters.Add("@dob",SqlDbType.Date).Value = dob_datetime.Value;
            adapt.SelectCommand.Parameters.Add("@street",SqlDbType.NChar,20).Value = street_input.Text;
            adapt.SelectCommand.Parameters.Add("@city",SqlDbType.NChar,20).Value = city_input.Text;
            adapt.SelectCommand.Parameters.Add("@province",SqlDbType.NChar,20).Value = province_input.Text;
            adapt.SelectCommand.Parameters.Add("@country",SqlDbType.NChar,20).Value = country_input.Text;
            adapt.SelectCommand.Parameters.Add("@postal",SqlDbType.NChar,20).Value = postal_input.Text;
            adapt.SelectCommand.Parameters.Add("@total_credits",SqlDbType.Int).Value = credits_input.Value;

            adapt.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            /*cmd.CommandType = CommandType.StoredProcedure;
            SqlTransaction trans;
            trans = con.BeginTransaction("sorted_CreateStudent");

            cmd.Connection = con;
            cmd.Transaction = trans;
            try
            {
                cmd.Parameters.AddWithValue("@first_name", first_name_input.Text);
                cmd.Parameters.AddWithValue("@last_name", last_name_input.Text);
                cmd.Parameters.AddWithValue("@dob", dob_datetime.Value);
                cmd.Parameters.AddWithValue("@street", street_input.Text);
                cmd.Parameters.AddWithValue("@city", city_input.Text);
                cmd.Parameters.AddWithValue("@province", postal_input.Text);
                cmd.Parameters.AddWithValue("@country", country_input.Text);
                cmd.Parameters.AddWithValue("@postal", postal_input.Text);
                cmd.Parameters.AddWithValue("@total_credits", credits_input.Value);

                /*cmd.CommandText = "Insert Into student (first_name,last_name,dob,street,city,province,country,postal,total_credits) Values('" + first_name_input.Text + "','" + last_name_input.Text + "','" + dob_datetime.Value + "','" + street_input.Text + "','" + city_input.Text + "','" + province_input.Text + "','" + country_input.Text + "','" + postal_input.Text + "','" + credits_input.Value + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Student added sucessfully.");
                //
                //Get the stored procedure - The studentID
                SqlParameter returnValue = new SqlParameter("@Result", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnValue);

                cmd.ExecuteNonQuery();
                trans.Commit();
                success_label.Text = "Student Added";

                //clear all fields
                first_name_input.Text = string.Empty;
                last_name_input.Text = string.Empty;
                street_input.Text = string.Empty;
                city_input.Text = "Edmonton";
                province_input.Text = "AB";
                country_input.Text = "Canada";
                postal_input.Text = string.Empty;
                credits_input.Value = 0;
                dob_datetime.Value = DateTime.Now.Date;
                //clear parameter
                cmd.Parameters.Clear();
            }
            catch (Exception exception1)
            {
                Console.WriteLine("Commit Exception Type: {0}", exception1.GetType());
                Console.WriteLine("  Message: {0}", exception1.Message);

                //Try to roll back the transaction 
                try
                {
                    trans.Rollback();
                }
                catch (Exception exception2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", exception2.GetType());
                    Console.WriteLine("  Message: {0}", exception2.Message);
                }
            }*/
        }
        private void sucess_label_Click(object sender, EventArgs e)
        {

        }
    }
}