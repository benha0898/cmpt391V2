namespace WindowForm.Modify
{
    partial class ModifyInstructor
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
            this.sucess_label = new System.Windows.Forms.Label();
            this.salary_label = new System.Windows.Forms.Label();
            this.salary_input = new System.Windows.Forms.NumericUpDown();
            this.dept_input = new System.Windows.Forms.ComboBox();
            this.department_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.last_name_input = new System.Windows.Forms.TextBox();
            this.first_name_label = new System.Windows.Forms.Label();
            this.first_name_input = new System.Windows.Forms.TextBox();
            this.personal_label = new System.Windows.Forms.Label();
            this.modify_instructor_label = new System.Windows.Forms.Label();
            this.instructor_input = new System.Windows.Forms.NumericUpDown();
            this.instructorid_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.search_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salary_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructor_input)).BeginInit();
            this.SuspendLayout();
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(13, 394);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(181, 25);
            this.sucess_label.TabIndex = 41;
            this.sucess_label.Text = "Instructor Added: ";
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Location = new System.Drawing.Point(335, 279);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(36, 13);
            this.salary_label.TabIndex = 39;
            this.salary_label.Text = "Salary";
            // 
            // salary_input
            // 
            this.salary_input.Location = new System.Drawing.Point(338, 295);
            this.salary_input.Name = "salary_input";
            this.salary_input.Size = new System.Drawing.Size(158, 20);
            this.salary_input.TabIndex = 38;
            // 
            // dept_input
            // 
            this.dept_input.FormattingEnabled = true;
            this.dept_input.Location = new System.Drawing.Point(338, 233);
            this.dept_input.Name = "dept_input";
            this.dept_input.Size = new System.Drawing.Size(158, 21);
            this.dept_input.TabIndex = 37;
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(335, 217);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(62, 13);
            this.department_label.TabIndex = 36;
            this.department_label.Text = "Department";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.Location = new System.Drawing.Point(335, 155);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(58, 13);
            this.last_name_label.TabIndex = 35;
            this.last_name_label.Text = "Last Name";
            // 
            // last_name_input
            // 
            this.last_name_input.Location = new System.Drawing.Point(338, 171);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.Size = new System.Drawing.Size(158, 20);
            this.last_name_input.TabIndex = 34;
            // 
            // first_name_label
            // 
            this.first_name_label.AutoSize = true;
            this.first_name_label.Location = new System.Drawing.Point(335, 105);
            this.first_name_label.Name = "first_name_label";
            this.first_name_label.Size = new System.Drawing.Size(57, 13);
            this.first_name_label.TabIndex = 33;
            this.first_name_label.Text = "First Name";
            // 
            // first_name_input
            // 
            this.first_name_input.Location = new System.Drawing.Point(338, 121);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.Size = new System.Drawing.Size(158, 20);
            this.first_name_input.TabIndex = 32;
            // 
            // personal_label
            // 
            this.personal_label.AutoSize = true;
            this.personal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personal_label.Location = new System.Drawing.Point(334, 74);
            this.personal_label.Name = "personal_label";
            this.personal_label.Size = new System.Drawing.Size(140, 20);
            this.personal_label.TabIndex = 31;
            this.personal_label.Text = "Personal Details";
            // 
            // modify_instructor_label
            // 
            this.modify_instructor_label.AutoSize = true;
            this.modify_instructor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_instructor_label.Location = new System.Drawing.Point(12, 9);
            this.modify_instructor_label.Name = "modify_instructor_label";
            this.modify_instructor_label.Size = new System.Drawing.Size(216, 31);
            this.modify_instructor_label.TabIndex = 30;
            this.modify_instructor_label.Text = "Modify Instructor";
            // 
            // instructor_input
            // 
            this.instructor_input.Location = new System.Drawing.Point(31, 134);
            this.instructor_input.Margin = new System.Windows.Forms.Padding(2);
            this.instructor_input.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.instructor_input.Name = "instructor_input";
            this.instructor_input.Size = new System.Drawing.Size(120, 20);
            this.instructor_input.TabIndex = 80;
            // 
            // instructorid_label
            // 
            this.instructorid_label.AutoSize = true;
            this.instructorid_label.Location = new System.Drawing.Point(28, 117);
            this.instructorid_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructorid_label.Name = "instructorid_label";
            this.instructorid_label.Size = new System.Drawing.Size(65, 13);
            this.instructorid_label.TabIndex = 79;
            this.instructorid_label.Text = "Instructor ID";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(31, 175);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(108, 28);
            this.search_button.TabIndex = 78;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(240, 461);
            this.splitter1.TabIndex = 81;
            this.splitter1.TabStop = false;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(27, 74);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(66, 20);
            this.search_label.TabIndex = 117;
            this.search_label.Text = "Search";
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Location = new System.Drawing.Point(418, 350);
            this.delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(78, 24);
            this.delete_button.TabIndex = 119;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(336, 350);
            this.update_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(78, 24);
            this.update_button.TabIndex = 118;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // ModifyInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.instructor_input);
            this.Controls.Add(this.instructorid_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.salary_label);
            this.Controls.Add(this.salary_input);
            this.Controls.Add(this.dept_input);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.last_name_label);
            this.Controls.Add(this.last_name_input);
            this.Controls.Add(this.first_name_label);
            this.Controls.Add(this.first_name_input);
            this.Controls.Add(this.personal_label);
            this.Controls.Add(this.modify_instructor_label);
            this.Controls.Add(this.splitter1);
            this.Name = "ModifyInstructor";
            this.Text = "Modify Instructor";
            ((System.ComponentModel.ISupportInitialize)(this.salary_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructor_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sucess_label;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.NumericUpDown salary_input;
        private System.Windows.Forms.ComboBox dept_input;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label last_name_label;
        private System.Windows.Forms.TextBox last_name_input;
        private System.Windows.Forms.Label first_name_label;
        private System.Windows.Forms.TextBox first_name_input;
        private System.Windows.Forms.Label personal_label;
        private System.Windows.Forms.Label modify_instructor_label;
        private System.Windows.Forms.NumericUpDown instructor_input;
        private System.Windows.Forms.Label instructorid_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
    }
}