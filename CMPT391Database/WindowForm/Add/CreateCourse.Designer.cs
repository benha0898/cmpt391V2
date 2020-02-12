namespace WindowForm.Add
{
    partial class CreateCourse
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
            this.submit_button = new System.Windows.Forms.Button();
            this.major_label = new System.Windows.Forms.Label();
            this.dept_input = new System.Windows.Forms.ComboBox();
            this.number_label = new System.Windows.Forms.Label();
            this.number_input = new System.Windows.Forms.NumericUpDown();
            this.description_label = new System.Windows.Forms.Label();
            this.description_input = new System.Windows.Forms.TextBox();
            this.subject_label = new System.Windows.Forms.Label();
            this.subject_input = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.title_input = new System.Windows.Forms.TextBox();
            this.course_label = new System.Windows.Forms.Label();
            this.add_course_label = new System.Windows.Forms.Label();
            this.credits_label = new System.Windows.Forms.Label();
            this.credits_input = new System.Windows.Forms.NumericUpDown();
            this.year_label = new System.Windows.Forms.Label();
            this.year_input = new System.Windows.Forms.NumericUpDown();
            this.sucess_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).BeginInit();
            this.SuspendLayout();
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(18, 391);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(110, 32);
            this.submit_button.TabIndex = 51;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // major_label
            // 
            this.major_label.AutoSize = true;
            this.major_label.Location = new System.Drawing.Point(335, 106);
            this.major_label.Name = "major_label";
            this.major_label.Size = new System.Drawing.Size(62, 13);
            this.major_label.TabIndex = 50;
            this.major_label.Text = "Department";
            // 
            // dept_input
            // 
            this.dept_input.FormattingEnabled = true;
            this.dept_input.Location = new System.Drawing.Point(338, 122);
            this.dept_input.Name = "dept_input";
            this.dept_input.Size = new System.Drawing.Size(149, 21);
            this.dept_input.TabIndex = 49;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(15, 313);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(80, 13);
            this.number_label.TabIndex = 48;
            this.number_label.Text = "Course Number";
            // 
            // number_input
            // 
            this.number_input.Location = new System.Drawing.Point(18, 329);
            this.number_input.Name = "number_input";
            this.number_input.Size = new System.Drawing.Size(100, 20);
            this.number_input.TabIndex = 47;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(15, 165);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(96, 13);
            this.description_label.TabIndex = 35;
            this.description_label.Text = "Course Description";
            // 
            // description_input
            // 
            this.description_input.Location = new System.Drawing.Point(18, 190);
            this.description_input.Multiline = true;
            this.description_input.Name = "description_input";
            this.description_input.Size = new System.Drawing.Size(469, 95);
            this.description_input.TabIndex = 34;
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(195, 106);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(43, 13);
            this.subject_label.TabIndex = 32;
            this.subject_label.Text = "Subject";
            // 
            // subject_input
            // 
            this.subject_input.Location = new System.Drawing.Point(198, 122);
            this.subject_input.Name = "subject_input";
            this.subject_input.Size = new System.Drawing.Size(116, 20);
            this.subject_input.TabIndex = 31;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(15, 106);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(63, 13);
            this.title_label.TabIndex = 30;
            this.title_label.Text = "Course Title";
            // 
            // title_input
            // 
            this.title_input.Location = new System.Drawing.Point(18, 122);
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(159, 20);
            this.title_input.TabIndex = 29;
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(14, 75);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(127, 20);
            this.course_label.TabIndex = 28;
            this.course_label.Text = "Course Details";
            // 
            // add_course_label
            // 
            this.add_course_label.AutoSize = true;
            this.add_course_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_course_label.Location = new System.Drawing.Point(12, 9);
            this.add_course_label.Name = "add_course_label";
            this.add_course_label.Size = new System.Drawing.Size(168, 33);
            this.add_course_label.TabIndex = 27;
            this.add_course_label.Text = "Add Course";
            // 
            // credits_label
            // 
            this.credits_label.AutoSize = true;
            this.credits_label.Location = new System.Drawing.Point(138, 313);
            this.credits_label.Name = "credits_label";
            this.credits_label.Size = new System.Drawing.Size(39, 13);
            this.credits_label.TabIndex = 55;
            this.credits_label.Text = "Credits";
            // 
            // credits_input
            // 
            this.credits_input.Location = new System.Drawing.Point(141, 329);
            this.credits_input.Name = "credits_input";
            this.credits_input.Size = new System.Drawing.Size(108, 20);
            this.credits_input.TabIndex = 54;
            this.credits_input.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(267, 313);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(29, 13);
            this.year_label.TabIndex = 57;
            this.year_label.Text = "Year";
            // 
            // year_input
            // 
            this.year_input.Location = new System.Drawing.Point(270, 329);
            this.year_input.Name = "year_input";
            this.year_input.Size = new System.Drawing.Size(121, 20);
            this.year_input.TabIndex = 56;
            this.year_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(178, 398);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(161, 25);
            this.sucess_label.TabIndex = 53;
            this.sucess_label.Text = "Course Added: ";
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.year_input);
            this.Controls.Add(this.credits_label);
            this.Controls.Add(this.credits_input);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.major_label);
            this.Controls.Add(this.dept_input);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.number_input);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.description_input);
            this.Controls.Add(this.subject_label);
            this.Controls.Add(this.subject_input);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.title_input);
            this.Controls.Add(this.course_label);
            this.Controls.Add(this.add_course_label);
            this.Name = "CreateCourse";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.CreateCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label major_label;
        private System.Windows.Forms.ComboBox dept_input;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.NumericUpDown number_input;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox description_input;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox subject_input;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox title_input;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.Label add_course_label;
        private System.Windows.Forms.Label credits_label;
        private System.Windows.Forms.NumericUpDown credits_input;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.NumericUpDown year_input;
        private System.Windows.Forms.Label sucess_label;
    }
}