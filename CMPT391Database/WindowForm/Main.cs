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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {
            Add.CreateStudent addStudent = new Add.CreateStudent();
            addStudent.Show();
        }

        private void add_instructor_button_Click(object sender, EventArgs e)
        {
            Add.CreateInstructor addInstructor = new Add.CreateInstructor();
            addInstructor.Show();
        }

        private void add_course_button_Click(object sender, EventArgs e)
        {
            Add.CreateCourse addCourse = new Add.CreateCourse();
            addCourse.Show();
        }

        private void add_dept_button_Click(object sender, EventArgs e)
        {
            Add.CreateDepartment addDepartment = new Add.CreateDepartment();
            addDepartment.Show();
        }

        private void add_enroll_button_Click(object sender, EventArgs e)
        {
            Add.Enroll enroll = new Add.Enroll();
            enroll.Show();
        }

        private void add_teaches_button_Click(object sender, EventArgs e)
        {
            Add.Teaches teaches = new Add.Teaches();
            teaches.Show();
        }

        private void add_section_button_Click(object sender, EventArgs e)
        {
            Add.CreateSection section = new Add.CreateSection();
            section.Show();
        }

        private void modify_student_button_Click(object sender, EventArgs e)
        {
            Modify.MoidifyStudent student = new Modify.MoidifyStudent();
            student.Show();
        }

        private void modify_instructor_button_Click(object sender, EventArgs e)
        {
            Modify.ModifyInstructor instructor = new Modify.ModifyInstructor();
            instructor.Show();
        }

        private void modify_course_button_Click(object sender, EventArgs e)
        {
            Modify.ModifyCourse course = new Modify.ModifyCourse();
            course.Show();
        }

        private void modify_dept_button_Click(object sender, EventArgs e)
        {
            Modify.ModifyDepartment department = new Modify.ModifyDepartment();
            department.Show();
        }

        private void mofidy_enroll_button_Click(object sender, EventArgs e)
        {
            Modify.Drop drop = new Modify.Drop();
            drop.Show();
        }

        private void modify_teaches_button_Click(object sender, EventArgs e)
        {
            Modify.ModifyTeaches teaches = new Modify.ModifyTeaches();
            teaches.Show();
        }
    }
}
