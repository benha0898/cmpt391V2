namespace WindowForm
{
    partial class Main
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
            this.add_label = new System.Windows.Forms.Label();
            this.modify_label = new System.Windows.Forms.Label();
            this.add_student_button = new System.Windows.Forms.Button();
            this.add_instructor_button = new System.Windows.Forms.Button();
            this.add_course_button = new System.Windows.Forms.Button();
            this.add_dept_button = new System.Windows.Forms.Button();
            this.add_teaches_button = new System.Windows.Forms.Button();
            this.add_enroll_button = new System.Windows.Forms.Button();
            this.mofidy_enroll_button = new System.Windows.Forms.Button();
            this.modify_teaches_button = new System.Windows.Forms.Button();
            this.modify_dept_button = new System.Windows.Forms.Button();
            this.modify_instructor_button = new System.Windows.Forms.Button();
            this.modify_student_button = new System.Windows.Forms.Button();
            this.modify_course_button = new System.Windows.Forms.Button();
            this.add_section_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_label.Location = new System.Drawing.Point(101, 42);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(62, 31);
            this.add_label.TabIndex = 0;
            this.add_label.Text = "Add";
            // 
            // modify_label
            // 
            this.modify_label.AutoSize = true;
            this.modify_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_label.Location = new System.Drawing.Point(294, 42);
            this.modify_label.Name = "modify_label";
            this.modify_label.Size = new System.Drawing.Size(94, 31);
            this.modify_label.TabIndex = 1;
            this.modify_label.Text = "Modify";
            // 
            // add_student_button
            // 
            this.add_student_button.Location = new System.Drawing.Point(87, 105);
            this.add_student_button.Name = "add_student_button";
            this.add_student_button.Size = new System.Drawing.Size(89, 32);
            this.add_student_button.TabIndex = 2;
            this.add_student_button.Text = "Student";
            this.add_student_button.UseVisualStyleBackColor = true;
            this.add_student_button.Click += new System.EventHandler(this.add_student_button_Click);
            // 
            // add_instructor_button
            // 
            this.add_instructor_button.Location = new System.Drawing.Point(87, 186);
            this.add_instructor_button.Name = "add_instructor_button";
            this.add_instructor_button.Size = new System.Drawing.Size(89, 32);
            this.add_instructor_button.TabIndex = 3;
            this.add_instructor_button.Text = "Instructor";
            this.add_instructor_button.UseVisualStyleBackColor = true;
            this.add_instructor_button.Click += new System.EventHandler(this.add_instructor_button_Click);
            // 
            // add_course_button
            // 
            this.add_course_button.Location = new System.Drawing.Point(87, 270);
            this.add_course_button.Name = "add_course_button";
            this.add_course_button.Size = new System.Drawing.Size(89, 32);
            this.add_course_button.TabIndex = 4;
            this.add_course_button.Text = "Course";
            this.add_course_button.UseVisualStyleBackColor = true;
            this.add_course_button.Click += new System.EventHandler(this.add_course_button_Click);
            // 
            // add_dept_button
            // 
            this.add_dept_button.Location = new System.Drawing.Point(87, 349);
            this.add_dept_button.Name = "add_dept_button";
            this.add_dept_button.Size = new System.Drawing.Size(89, 42);
            this.add_dept_button.TabIndex = 5;
            this.add_dept_button.Text = "Department/  Head";
            this.add_dept_button.UseVisualStyleBackColor = true;
            this.add_dept_button.Click += new System.EventHandler(this.add_dept_button_Click);
            // 
            // add_teaches_button
            // 
            this.add_teaches_button.Location = new System.Drawing.Point(87, 529);
            this.add_teaches_button.Name = "add_teaches_button";
            this.add_teaches_button.Size = new System.Drawing.Size(89, 32);
            this.add_teaches_button.TabIndex = 6;
            this.add_teaches_button.Text = "Teaches";
            this.add_teaches_button.UseVisualStyleBackColor = true;
            this.add_teaches_button.Click += new System.EventHandler(this.add_teaches_button_Click);
            // 
            // add_enroll_button
            // 
            this.add_enroll_button.Location = new System.Drawing.Point(87, 444);
            this.add_enroll_button.Name = "add_enroll_button";
            this.add_enroll_button.Size = new System.Drawing.Size(89, 32);
            this.add_enroll_button.TabIndex = 7;
            this.add_enroll_button.Text = "Enroll Classes";
            this.add_enroll_button.UseVisualStyleBackColor = true;
            this.add_enroll_button.Click += new System.EventHandler(this.add_enroll_button_Click);
            // 
            // mofidy_enroll_button
            // 
            this.mofidy_enroll_button.Location = new System.Drawing.Point(299, 444);
            this.mofidy_enroll_button.Name = "mofidy_enroll_button";
            this.mofidy_enroll_button.Size = new System.Drawing.Size(89, 32);
            this.mofidy_enroll_button.TabIndex = 13;
            this.mofidy_enroll_button.Text = "Drop Classes";
            this.mofidy_enroll_button.UseVisualStyleBackColor = true;
            this.mofidy_enroll_button.Click += new System.EventHandler(this.mofidy_enroll_button_Click);
            // 
            // modify_teaches_button
            // 
            this.modify_teaches_button.Location = new System.Drawing.Point(299, 529);
            this.modify_teaches_button.Name = "modify_teaches_button";
            this.modify_teaches_button.Size = new System.Drawing.Size(89, 32);
            this.modify_teaches_button.TabIndex = 12;
            this.modify_teaches_button.Text = "Teaches";
            this.modify_teaches_button.UseVisualStyleBackColor = true;
            this.modify_teaches_button.Click += new System.EventHandler(this.modify_teaches_button_Click);
            // 
            // modify_dept_button
            // 
            this.modify_dept_button.Location = new System.Drawing.Point(299, 349);
            this.modify_dept_button.Name = "modify_dept_button";
            this.modify_dept_button.Size = new System.Drawing.Size(89, 42);
            this.modify_dept_button.TabIndex = 11;
            this.modify_dept_button.Text = "Department";
            this.modify_dept_button.UseVisualStyleBackColor = true;
            this.modify_dept_button.Click += new System.EventHandler(this.modify_dept_button_Click);
            // 
            // modify_instructor_button
            // 
            this.modify_instructor_button.Location = new System.Drawing.Point(299, 186);
            this.modify_instructor_button.Name = "modify_instructor_button";
            this.modify_instructor_button.Size = new System.Drawing.Size(89, 32);
            this.modify_instructor_button.TabIndex = 9;
            this.modify_instructor_button.Text = "Instructor";
            this.modify_instructor_button.UseVisualStyleBackColor = true;
            this.modify_instructor_button.Click += new System.EventHandler(this.modify_instructor_button_Click);
            // 
            // modify_student_button
            // 
            this.modify_student_button.Location = new System.Drawing.Point(299, 105);
            this.modify_student_button.Name = "modify_student_button";
            this.modify_student_button.Size = new System.Drawing.Size(89, 32);
            this.modify_student_button.TabIndex = 8;
            this.modify_student_button.Text = "Student";
            this.modify_student_button.UseVisualStyleBackColor = true;
            this.modify_student_button.Click += new System.EventHandler(this.modify_student_button_Click);
            // 
            // modify_course_button
            // 
            this.modify_course_button.Location = new System.Drawing.Point(299, 270);
            this.modify_course_button.Name = "modify_course_button";
            this.modify_course_button.Size = new System.Drawing.Size(89, 32);
            this.modify_course_button.TabIndex = 14;
            this.modify_course_button.Text = "Course";
            this.modify_course_button.UseVisualStyleBackColor = true;
            this.modify_course_button.Click += new System.EventHandler(this.modify_course_button_Click);
            // 
            // add_section_button
            // 
            this.add_section_button.Location = new System.Drawing.Point(87, 609);
            this.add_section_button.Name = "add_section_button";
            this.add_section_button.Size = new System.Drawing.Size(89, 32);
            this.add_section_button.TabIndex = 15;
            this.add_section_button.Text = "Section";
            this.add_section_button.UseVisualStyleBackColor = true;
            this.add_section_button.Click += new System.EventHandler(this.add_section_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 664);
            this.Controls.Add(this.add_section_button);
            this.Controls.Add(this.modify_course_button);
            this.Controls.Add(this.mofidy_enroll_button);
            this.Controls.Add(this.modify_teaches_button);
            this.Controls.Add(this.modify_dept_button);
            this.Controls.Add(this.modify_instructor_button);
            this.Controls.Add(this.modify_student_button);
            this.Controls.Add(this.add_enroll_button);
            this.Controls.Add(this.add_teaches_button);
            this.Controls.Add(this.add_dept_button);
            this.Controls.Add(this.add_course_button);
            this.Controls.Add(this.add_instructor_button);
            this.Controls.Add(this.add_student_button);
            this.Controls.Add(this.modify_label);
            this.Controls.Add(this.add_label);
            this.Name = "Main";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_label;
        private System.Windows.Forms.Label modify_label;
        private System.Windows.Forms.Button add_student_button;
        private System.Windows.Forms.Button add_instructor_button;
        private System.Windows.Forms.Button add_course_button;
        private System.Windows.Forms.Button add_dept_button;
        private System.Windows.Forms.Button add_teaches_button;
        private System.Windows.Forms.Button add_enroll_button;
        private System.Windows.Forms.Button mofidy_enroll_button;
        private System.Windows.Forms.Button modify_teaches_button;
        private System.Windows.Forms.Button modify_dept_button;
        private System.Windows.Forms.Button modify_instructor_button;
        private System.Windows.Forms.Button modify_student_button;
        private System.Windows.Forms.Button modify_course_button;
        private System.Windows.Forms.Button add_section_button;
    }
}