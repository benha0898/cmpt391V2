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
            int year = DateTime.Now.Year;
            int i;
            instructor_deptdrop.Items.Add("Department");


            semester_semdrop.Items.Add("Fall " + year.ToString());
            semester_semdrop.Items.Add("Winter " + year.ToString());
            semester_yeardrop.Items.Add(year.ToString());

            for (i = year; i < year-10; i--) {
                semester_yeardrop.Items.Add(i.ToString());
            }


        }
    }
}
