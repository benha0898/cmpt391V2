using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataWarehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            instructor_dropdown.Items.Add("Department");
            semester_dropdown.Items.Add("Term");
            semester_dropdown.Items.Add("Year");
            student_dropdown.Items.Add("Major");
            student_dropdown.Items.Add("Status");
            course_dropdown.Items.Add("Subject");
            course_dropdown.Items.Add("Department");
            course_dropdown.Items.Add("Credit");
        }
    }
}
