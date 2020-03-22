namespace DataWarehouse
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.course_subjectdrop = new System.Windows.Forms.ComboBox();
            this.instructor_deptdrop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.semester_semdrop = new System.Windows.Forms.ComboBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.student_input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.course_leveldrop = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.instructor_facdrop = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.semester_yeardrop = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.course_deptdrop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "University Data Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Count:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 477);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(685, 134);
            this.listBox1.TabIndex = 2;
            // 
            // course_subjectdrop
            // 
            this.course_subjectdrop.FormattingEnabled = true;
            this.course_subjectdrop.Location = new System.Drawing.Point(104, 202);
            this.course_subjectdrop.Name = "course_subjectdrop";
            this.course_subjectdrop.Size = new System.Drawing.Size(158, 21);
            this.course_subjectdrop.TabIndex = 4;
            // 
            // instructor_deptdrop
            // 
            this.instructor_deptdrop.FormattingEnabled = true;
            this.instructor_deptdrop.Location = new System.Drawing.Point(287, 284);
            this.instructor_deptdrop.Name = "instructor_deptdrop";
            this.instructor_deptdrop.Size = new System.Drawing.Size(258, 21);
            this.instructor_deptdrop.TabIndex = 5;
            this.instructor_deptdrop.SelectedIndexChanged += new System.EventHandler(this.instructor_deptdrop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Instructor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Semester:";
            // 
            // semester_semdrop
            // 
            this.semester_semdrop.FormattingEnabled = true;
            this.semester_semdrop.Location = new System.Drawing.Point(104, 366);
            this.semester_semdrop.Name = "semester_semdrop";
            this.semester_semdrop.Size = new System.Drawing.Size(158, 21);
            this.semester_semdrop.TabIndex = 10;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(104, 426);
            this.submit_button.Name = "submit_button";
            this.submit_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 11;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // student_input
            // 
            this.student_input.Location = new System.Drawing.Point(104, 120);
            this.student_input.Name = "student_input";
            this.student_input.Size = new System.Drawing.Size(158, 20);
            this.student_input.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subject:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Level:";
            // 
            // course_leveldrop
            // 
            this.course_leveldrop.FormattingEnabled = true;
            this.course_leveldrop.Location = new System.Drawing.Point(287, 202);
            this.course_leveldrop.Name = "course_leveldrop";
            this.course_leveldrop.Size = new System.Drawing.Size(158, 21);
            this.course_leveldrop.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Department:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Faculty:";
            // 
            // instructor_facdrop
            // 
            this.instructor_facdrop.FormattingEnabled = true;
            this.instructor_facdrop.Location = new System.Drawing.Point(106, 284);
            this.instructor_facdrop.Name = "instructor_facdrop";
            this.instructor_facdrop.Size = new System.Drawing.Size(158, 21);
            this.instructor_facdrop.TabIndex = 17;
            this.instructor_facdrop.SelectedIndexChanged += new System.EventHandler(this.instructor_facdrop_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Term:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(284, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Year:";
            // 
            // semester_yeardrop
            // 
            this.semester_yeardrop.FormattingEnabled = true;
            this.semester_yeardrop.Location = new System.Drawing.Point(287, 366);
            this.semester_yeardrop.Name = "semester_yeardrop";
            this.semester_yeardrop.Size = new System.Drawing.Size(158, 21);
            this.semester_yeardrop.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(464, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Department:";
            // 
            // course_deptdrop
            // 
            this.course_deptdrop.FormattingEnabled = true;
            this.course_deptdrop.Location = new System.Drawing.Point(467, 202);
            this.course_deptdrop.Name = "course_deptdrop";
            this.course_deptdrop.Size = new System.Drawing.Size(234, 21);
            this.course_deptdrop.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 635);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.course_deptdrop);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.semester_yeardrop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.instructor_facdrop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.course_leveldrop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.student_input);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.semester_semdrop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructor_deptdrop);
            this.Controls.Add(this.course_subjectdrop);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox course_subjectdrop;
        private System.Windows.Forms.ComboBox instructor_deptdrop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox semester_semdrop;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox student_input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox course_leveldrop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox instructor_facdrop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox semester_yeardrop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox course_deptdrop;
    }
}

