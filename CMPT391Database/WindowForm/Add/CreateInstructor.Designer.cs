namespace WindowForm.Add
{
    partial class CreateInstructor
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
            this.add_instructor_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.last_name_input = new System.Windows.Forms.TextBox();
            this.first_name_label = new System.Windows.Forms.Label();
            this.first_name_input = new System.Windows.Forms.TextBox();
            this.personal_label = new System.Windows.Forms.Label();
            this.dept_input = new System.Windows.Forms.ComboBox();
            this.salary_label = new System.Windows.Forms.Label();
            this.salary_input = new System.Windows.Forms.NumericUpDown();
            this.sucess_label = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salary_input)).BeginInit();
            this.SuspendLayout();
            // 
            // add_instructor_label
            // 
            this.add_instructor_label.AutoSize = true;
            this.add_instructor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_instructor_label.Location = new System.Drawing.Point(12, 9);
            this.add_instructor_label.Name = "add_instructor_label";
            this.add_instructor_label.Size = new System.Drawing.Size(196, 33);
            this.add_instructor_label.TabIndex = 1;
            this.add_instructor_label.Text = "Add Instructor";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(15, 217);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(62, 13);
            this.department_label.TabIndex = 24;
            this.department_label.Text = "Department";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Location = new System.Drawing.Point(15, 155);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(58, 13);
            this.last_name_label.TabIndex = 23;
            this.last_name_label.Text = "Last Name";
            // 
            // last_name_input
            // 
            this.last_name_input.Location = new System.Drawing.Point(18, 171);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(121, 20);
            this.last_name_input.TabIndex = 22;
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Location = new System.Drawing.Point(15, 105);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(57, 13);
            this.first_name_label.TabIndex = 21;
            this.first_name_label.Text = "First Name";
            // 
            // first_name_input
            // 
            this.first_name_input.Location = new System.Drawing.Point(18, 121);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(121, 20);
            this.first_name_input.TabIndex = 20;
            // 
            // personal_label
            // 
            this.personal_label.AutoSize = true;
            this.personal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_label.Location = new System.Drawing.Point(14, 74);
            this.personal_label.Name = "personal_label";
            this.personal_label.Size = new System.Drawing.Size(140, 20);
            this.personal_label.TabIndex = 19;
            this.personal_label.Text = "Personal Details";
            // 
            // dept_input
            // 
            this.dept_input.FormattingEnabled = true;
            this.dept_input.Location = new System.Drawing.Point(18, 233);
            this.dept_input.Name = "dept_input";
            this.dept_input.Size = new System.Drawing.Size(121, 21);
            this.dept_input.TabIndex = 25;
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Location = new System.Drawing.Point(15, 279);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(36, 13);
            this.salary_label.TabIndex = 27;
            this.salary_label.Text = "Salary";
            // 
            // salary_input
            // 
            this.salary_input.Location = new System.Drawing.Point(18, 295);
            this.salary_input.Name = "salary_input";
            this.salary_input.Size = new System.Drawing.Size(121, 20);
            this.salary_input.TabIndex = 26;
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(189, 353);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(181, 25);
            this.sucess_label.TabIndex = 29;
            this.sucess_label.Text = "Instructor Added: ";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(18, 352);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(121, 32);
            this.submit_button.TabIndex = 28;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // CreateInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.salary_label);
            this.Controls.Add(this.salary_input);
            this.Controls.Add(this.dept_input);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.last_name_input);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.first_name_input);
            this.Controls.Add(this.personal_label);
            this.Controls.Add(this.add_instructor_label);
            this.Name = "CreateInstructor";
            this.Text = "Add Instructor";
            this.Load += new System.EventHandler(this.CreateInstructor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salary_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_instructor_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox last_name_input;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.TextBox first_name_input;
        private System.Windows.Forms.Label personal_label;
        private System.Windows.Forms.ComboBox dept_input;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.NumericUpDown salary_input;
        private System.Windows.Forms.Label sucess_label;
        private System.Windows.Forms.Button submit_button;
    }
}