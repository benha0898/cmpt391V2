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

            course_leveldrop.Items.Add("100");
            course_leveldrop.Items.Add("200");
            course_leveldrop.Items.Add("300");
            course_leveldrop.Items.Add("400");
            semester_semdrop.Items.Add("Fall ");
            semester_semdrop.Items.Add("Winter ");

            for (i = year; i > year-10; i--) {
                semester_yeardrop.Items.Add(i.ToString());
            }


        }
    }
}
