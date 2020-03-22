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
            this.student_dropdown = new System.Windows.Forms.ComboBox();
            this.course_dropdown = new System.Windows.Forms.ComboBox();
            this.instructor_dropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.semester_dropdown = new System.Windows.Forms.ComboBox();
            this.submit_button = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(22, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Count:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 432);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(685, 134);
            this.listBox1.TabIndex = 2;
            // 
            // student_dropdown
            // 
            this.student_dropdown.FormattingEnabled = true;
            this.student_dropdown.Location = new System.Drawing.Point(236, 126);
            this.student_dropdown.Name = "student_dropdown";
            this.student_dropdown.Size = new System.Drawing.Size(158, 21);
            this.student_dropdown.TabIndex = 3;
            // 
            // course_dropdown
            // 
            this.course_dropdown.FormattingEnabled = true;
            this.course_dropdown.Location = new System.Drawing.Point(236, 188);
            this.course_dropdown.Name = "course_dropdown";
            this.course_dropdown.Size = new System.Drawing.Size(158, 21);
            this.course_dropdown.TabIndex = 4;
            // 
            // instructor_dropdown
            // 
            this.instructor_dropdown.FormattingEnabled = true;
            this.instructor_dropdown.Location = new System.Drawing.Point(236, 250);
            this.instructor_dropdown.Name = "instructor_dropdown";
            this.instructor_dropdown.Size = new System.Drawing.Size(158, 21);
            this.instructor_dropdown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Instructor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Semester:";
            // 
            // semester_dropdown
            // 
            this.semester_dropdown.FormattingEnabled = true;
            this.semester_dropdown.Location = new System.Drawing.Point(236, 307);
            this.semester_dropdown.Name = "semester_dropdown";
            this.semester_dropdown.Size = new System.Drawing.Size(158, 21);
            this.semester_dropdown.TabIndex = 10;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(236, 350);
            this.submit_button.Name = "submit_button";
            this.submit_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 11;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 578);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.semester_dropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instructor_dropdown);
            this.Controls.Add(this.course_dropdown);
            this.Controls.Add(this.student_dropdown);
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
        private System.Windows.Forms.ComboBox student_dropdown;
        private System.Windows.Forms.ComboBox course_dropdown;
        private System.Windows.Forms.ComboBox instructor_dropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox semester_dropdown;
        private System.Windows.Forms.Button submit_button;
    }
}

