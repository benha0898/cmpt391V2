using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDBDataSet.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.universityDBDataSet.course);

        }
    }
}
