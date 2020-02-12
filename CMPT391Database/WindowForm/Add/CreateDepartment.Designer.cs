namespace WindowForm.Add
{
    partial class CreateDepartment
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
            this.add_head_button = new System.Windows.Forms.Button();
            this.instructor_input = new System.Windows.Forms.ComboBox();
            this.DepartmentCombobox = new System.Windows.Forms.ComboBox();
            this.instructor_label = new System.Windows.Forms.Label();
            this.dept_label = new System.Windows.Forms.Label();
            this.dept_head_label = new System.Windows.Forms.Label();
            this.building_input = new System.Windows.Forms.NumericUpDown();
            this.building_label = new System.Windows.Forms.Label();
            this.add_dept_button = new System.Windows.Forms.Button();
            this.add_dept_label = new System.Windows.Forms.Label();
            this.dept_name_label = new System.Windows.Forms.Label();
            this.dept_name_input = new System.Windows.Forms.TextBox();
            this.sucess_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.building_input)).BeginInit();
            this.SuspendLayout();
            // 
            // add_head_button
            // 
            this.add_head_button.Location = new System.Drawing.Point(262, 194);
            this.add_head_button.Name = "add_head_button";
            this.add_head_button.Size = new System.Drawing.Size(143, 27);
            this.add_head_button.TabIndex = 28;
            this.add_head_button.Text = "Add Department Head";
            this.add_head_button.UseVisualStyleBackColor = true;
            // 
            // instructor_input
            // 
            this.instructor_input.DisplayMember = "Name";
            this.instructor_input.FormattingEnabled = true;
            this.instructor_input.Location = new System.Drawing.Point(262, 136);
            this.instructor_input.Name = "instructor_input";
            this.instructor_input.Size = new System.Drawing.Size(143, 21);
            this.instructor_input.TabIndex = 27;
            this.instructor_input.ValueMember = "InstructorID";
            // 
            // DepartmentCombobox
            // 
            this.DepartmentCombobox.DisplayMember = "Dept_Name";
            this.DepartmentCombobox.FormattingEnabled = true;
            this.DepartmentCombobox.Location = new System.Drawing.Point(262, 82);
            this.DepartmentCombobox.Name = "DepartmentCombobox";
            this.DepartmentCombobox.Size = new System.Drawing.Size(143, 21);
            this.DepartmentCombobox.TabIndex = 26;
            this.DepartmentCombobox.ValueMember = "Dept_Name";
            // 
            // instructor_label
            // 
            this.instructor_label.AutoSize = true;
            this.instructor_label.Location = new System.Drawing.Point(259, 120);
            this.instructor_label.Name = "instructor_label";
            this.instructor_label.Size = new System.Drawing.Size(51, 13);
            this.instructor_label.TabIndex = 25;
            this.instructor_label.Text = "Instructor";
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(259, 67);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(62, 13);
            this.dept_label.TabIndex = 24;
            this.dept_label.Text = "Department";
            // 
            // dept_head_label
            // 
            this.dept_head_label.AutoSize = true;
            this.dept_head_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_head_label.Location = new System.Drawing.Point(258, 21);
            this.dept_head_label.Name = "dept_head_label";
            this.dept_head_label.Size = new System.Drawing.Size(298, 29);
            this.dept_head_label.TabIndex = 23;
            this.dept_head_label.Text = "Select Department Head";
            // 
            // building_input
            // 
            this.building_input.Location = new System.Drawing.Point(15, 137);
            this.building_input.Margin = new System.Windows.Forms.Padding(2);
            this.building_input.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.building_input.Name = "building_input";
            this.building_input.Size = new System.Drawing.Size(144, 20);
            this.building_input.TabIndex = 18;
            // 
            // building_label
            // 
            this.building_label.AutoSize = true;
            this.building_label.Location = new System.Drawing.Point(13, 122);
            this.building_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.building_label.Name = "building_label";
            this.building_label.Size = new System.Drawing.Size(44, 13);
            this.building_label.TabIndex = 22;
            this.building_label.Text = "Building";
            this.building_label.Visible = false;
            // 
            // add_dept_button
            // 
            this.add_dept_button.Location = new System.Drawing.Point(15, 193);
            this.add_dept_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_dept_button.Name = "add_dept_button";
            this.add_dept_button.Size = new System.Drawing.Size(145, 28);
            this.add_dept_button.TabIndex = 19;
            this.add_dept_button.Text = "Add Department";
            this.add_dept_button.UseVisualStyleBackColor = true;
            // 
            // add_dept_label
            // 
            this.add_dept_label.AutoSize = true;
            this.add_dept_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_dept_label.Location = new System.Drawing.Point(11, 21);
            this.add_dept_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.add_dept_label.Name = "add_dept_label";
            this.add_dept_label.Size = new System.Drawing.Size(201, 29);
            this.add_dept_label.TabIndex = 21;
            this.add_dept_label.Text = "Add Department";
            // 
            // dept_name_label
            // 
            this.dept_name_label.AutoSize = true;
            this.dept_name_label.Location = new System.Drawing.Point(12, 67);
            this.dept_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dept_name_label.Name = "dept_name_label";
            this.dept_name_label.Size = new System.Drawing.Size(93, 13);
            this.dept_name_label.TabIndex = 20;
            this.dept_name_label.Text = "Department Name";
            // 
            // dept_name_input
            // 
            this.dept_name_input.Location = new System.Drawing.Point(15, 82);
            this.dept_name_input.Margin = new System.Windows.Forms.Padding(2);
            this.dept_name_input.Name = "dept_name_input";
            this.dept_name_input.Size = new System.Drawing.Size(145, 20);
            this.dept_name_input.TabIndex = 16;
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(12, 272);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(203, 25);
            this.sucess_label.TabIndex = 54;
            this.sucess_label.Text = "Department Added: ";
            // 
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.add_head_button);
            this.Controls.Add(this.instructor_input);
            this.Controls.Add(this.DepartmentCombobox);
            this.Controls.Add(this.instructor_label);
            this.Controls.Add(this.dept_label);
            this.Controls.Add(this.dept_head_label);
            this.Controls.Add(this.building_input);
            this.Controls.Add(this.building_label);
            this.Controls.Add(this.add_dept_button);
            this.Controls.Add(this.add_dept_label);
            this.Controls.Add(this.dept_name_label);
            this.Controls.Add(this.dept_name_input);
            this.Name = "CreateDepartment";
            this.Text = "Add Department";
            ((System.ComponentModel.ISupportInitialize)(this.building_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_head_button;
        private System.Windows.Forms.ComboBox instructor_input;
        private System.Windows.Forms.ComboBox DepartmentCombobox;
        private System.Windows.Forms.Label instructor_label;
        private System.Windows.Forms.Label dept_label;
        private System.Windows.Forms.Label dept_head_label;
        private System.Windows.Forms.NumericUpDown building_input;
        private System.Windows.Forms.Label building_label;
        private System.Windows.Forms.Button add_dept_button;
        private System.Windows.Forms.Label add_dept_label;
        private System.Windows.Forms.Label dept_name_label;
        private System.Windows.Forms.TextBox dept_name_input;
        private System.Windows.Forms.Label sucess_label;
    }
}