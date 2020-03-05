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
            this.add_head_button.Location = new System.Drawing.Point(393, 298);
            this.add_head_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_head_button.Name = "add_head_button";
            this.add_head_button.Size = new System.Drawing.Size(214, 42);
            this.add_head_button.TabIndex = 28;
            this.add_head_button.Text = "Add Department Head";
            this.add_head_button.UseVisualStyleBackColor = true;
            // 
            // instructor_input
            // 
            this.instructor_input.DisplayMember = "Name";
            this.instructor_input.FormattingEnabled = true;
            this.instructor_input.Location = new System.Drawing.Point(393, 209);
            this.instructor_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instructor_input.Name = "instructor_input";
            this.instructor_input.Size = new System.Drawing.Size(212, 28);
            this.instructor_input.TabIndex = 27;
            this.instructor_input.ValueMember = "InstructorID";
            // 
            // DepartmentCombobox
            // 
            this.DepartmentCombobox.DisplayMember = "Dept_Name";
            this.DepartmentCombobox.FormattingEnabled = true;
            this.DepartmentCombobox.Location = new System.Drawing.Point(393, 126);
            this.DepartmentCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepartmentCombobox.Name = "DepartmentCombobox";
            this.DepartmentCombobox.Size = new System.Drawing.Size(212, 28);
            this.DepartmentCombobox.TabIndex = 26;
            this.DepartmentCombobox.ValueMember = "Dept_Name";
            this.DepartmentCombobox.SelectedIndexChanged += new System.EventHandler(this.DepartmentCombobox_SelectedIndexChanged);
            // 
            // instructor_label
            // 
            this.instructor_label.AutoSize = true;
            this.instructor_label.Location = new System.Drawing.Point(388, 185);
            this.instructor_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructor_label.Name = "instructor_label";
            this.instructor_label.Size = new System.Drawing.Size(77, 20);
            this.instructor_label.TabIndex = 25;
            this.instructor_label.Text = "Instructor";
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(388, 103);
            this.dept_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(94, 20);
            this.dept_label.TabIndex = 24;
            this.dept_label.Text = "Department";
            // 
            // dept_head_label
            // 
            this.dept_head_label.AutoSize = true;
            this.dept_head_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_head_label.Location = new System.Drawing.Point(387, 32);
            this.dept_head_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dept_head_label.Name = "dept_head_label";
            this.dept_head_label.Size = new System.Drawing.Size(433, 40);
            this.dept_head_label.TabIndex = 23;
            this.dept_head_label.Text = "Select Department Head";
            // 
            // building_input
            // 
            this.building_input.Location = new System.Drawing.Point(22, 211);
            this.building_input.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.building_input.Name = "building_input";
            this.building_input.Size = new System.Drawing.Size(216, 26);
            this.building_input.TabIndex = 18;
            // 
            // building_label
            // 
            this.building_label.AutoSize = true;
            this.building_label.Location = new System.Drawing.Point(20, 188);
            this.building_label.Name = "building_label";
            this.building_label.Size = new System.Drawing.Size(65, 20);
            this.building_label.TabIndex = 22;
            this.building_label.Text = "Building";
            this.building_label.Visible = false;
            // 
            // add_dept_button
            // 
            this.add_dept_button.Location = new System.Drawing.Point(22, 297);
            this.add_dept_button.Name = "add_dept_button";
            this.add_dept_button.Size = new System.Drawing.Size(218, 43);
            this.add_dept_button.TabIndex = 19;
            this.add_dept_button.Text = "Add Department";
            this.add_dept_button.UseVisualStyleBackColor = true;
            this.add_dept_button.Click += new System.EventHandler(this.add_dept_button_Click);
            // 
            // add_dept_label
            // 
            this.add_dept_label.AutoSize = true;
            this.add_dept_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_dept_label.Location = new System.Drawing.Point(16, 32);
            this.add_dept_label.Name = "add_dept_label";
            this.add_dept_label.Size = new System.Drawing.Size(293, 40);
            this.add_dept_label.TabIndex = 21;
            this.add_dept_label.Text = "Add Department";
            // 
            // dept_name_label
            // 
            this.dept_name_label.AutoSize = true;
            this.dept_name_label.Location = new System.Drawing.Point(18, 103);
            this.dept_name_label.Name = "dept_name_label";
            this.dept_name_label.Size = new System.Drawing.Size(140, 20);
            this.dept_name_label.TabIndex = 20;
            this.dept_name_label.Text = "Department Name";
            // 
            // dept_name_input
            // 
            this.dept_name_input.Location = new System.Drawing.Point(22, 126);
            this.dept_name_input.Name = "dept_name_input";
            this.dept_name_input.Size = new System.Drawing.Size(216, 26);
            this.dept_name_input.TabIndex = 16;
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(18, 418);
            this.sucess_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(304, 37);
            this.sucess_label.TabIndex = 54;
            this.sucess_label.Text = "Department Added: ";
            // 
            // CreateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 709);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateDepartment";
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.CreateDepartment_Load);
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