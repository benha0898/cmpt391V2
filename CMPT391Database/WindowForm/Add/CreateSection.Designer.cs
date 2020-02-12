namespace WindowForm.Add
{
    partial class CreateSection
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
            this.dept_input = new System.Windows.Forms.ComboBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.course_label = new System.Windows.Forms.Label();
            this.end_time_label = new System.Windows.Forms.Label();
            this.start_time_label = new System.Windows.Forms.Label();
            this.days_label = new System.Windows.Forms.Label();
            this.capacity_label = new System.Windows.Forms.Label();
            this.classroom_label = new System.Windows.Forms.Label();
            this.dept_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.term_label = new System.Windows.Forms.Label();
            this.sectionid_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.section_label = new System.Windows.Forms.Label();
            this.end_time_input = new System.Windows.Forms.DateTimePicker();
            this.start_time_input = new System.Windows.Forms.DateTimePicker();
            this.days_checklist = new System.Windows.Forms.CheckedListBox();
            this.capacity_input = new System.Windows.Forms.NumericUpDown();
            this.classroom_input = new System.Windows.Forms.TextBox();
            this.year_input = new System.Windows.Forms.NumericUpDown();
            this.term_input = new System.Windows.Forms.ComboBox();
            this.sectionid_input = new System.Windows.Forms.TextBox();
            this.sucess_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capacity_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).BeginInit();
            this.SuspendLayout();
            // 
            // dept_input
            // 
            this.dept_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dept_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dept_input.DisplayMember = "Dept_Name";
            this.dept_input.FormattingEnabled = true;
            this.dept_input.Location = new System.Drawing.Point(21, 215);
            this.dept_input.Name = "dept_input";
            this.dept_input.Size = new System.Drawing.Size(129, 21);
            this.dept_input.TabIndex = 31;
            this.dept_input.ValueMember = "Dept_Name";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(24, 414);
            this.submit_button.Margin = new System.Windows.Forms.Padding(2);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(126, 36);
            this.submit_button.TabIndex = 38;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(21, 169);
            this.course_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(59, 17);
            this.course_label.TabIndex = 51;
            this.course_label.Text = "Course";
            // 
            // end_time_label
            // 
            this.end_time_label.AutoSize = true;
            this.end_time_label.Location = new System.Drawing.Point(357, 309);
            this.end_time_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.end_time_label.Name = "end_time_label";
            this.end_time_label.Size = new System.Drawing.Size(52, 13);
            this.end_time_label.TabIndex = 50;
            this.end_time_label.Text = "End Time";
            // 
            // start_time_label
            // 
            this.start_time_label.AutoSize = true;
            this.start_time_label.Location = new System.Drawing.Point(354, 251);
            this.start_time_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.start_time_label.Name = "start_time_label";
            this.start_time_label.Size = new System.Drawing.Size(55, 13);
            this.start_time_label.TabIndex = 49;
            this.start_time_label.Text = "Start Time";
            // 
            // days_label
            // 
            this.days_label.AutoSize = true;
            this.days_label.Location = new System.Drawing.Point(354, 58);
            this.days_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.days_label.Name = "days_label";
            this.days_label.Size = new System.Drawing.Size(31, 13);
            this.days_label.TabIndex = 48;
            this.days_label.Text = "Days";
            // 
            // capacity_label
            // 
            this.capacity_label.AutoSize = true;
            this.capacity_label.Location = new System.Drawing.Point(18, 309);
            this.capacity_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.capacity_label.Name = "capacity_label";
            this.capacity_label.Size = new System.Drawing.Size(48, 13);
            this.capacity_label.TabIndex = 47;
            this.capacity_label.Text = "Capacity";
            // 
            // classroom_label
            // 
            this.classroom_label.AutoSize = true;
            this.classroom_label.Location = new System.Drawing.Point(21, 251);
            this.classroom_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classroom_label.Name = "classroom_label";
            this.classroom_label.Size = new System.Drawing.Size(55, 13);
            this.classroom_label.TabIndex = 45;
            this.classroom_label.Text = "Classroom";
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(20, 199);
            this.dept_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(62, 13);
            this.dept_label.TabIndex = 44;
            this.dept_label.Text = "Department";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(21, 111);
            this.year_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(29, 13);
            this.year_label.TabIndex = 43;
            this.year_label.Text = "Year";
            // 
            // term_label
            // 
            this.term_label.AutoSize = true;
            this.term_label.Location = new System.Drawing.Point(177, 58);
            this.term_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.term_label.Name = "term_label";
            this.term_label.Size = new System.Drawing.Size(31, 13);
            this.term_label.TabIndex = 42;
            this.term_label.Text = "Term";
            // 
            // sectionid_label
            // 
            this.sectionid_label.AutoSize = true;
            this.sectionid_label.Location = new System.Drawing.Point(20, 58);
            this.sectionid_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sectionid_label.Name = "sectionid_label";
            this.sectionid_label.Size = new System.Drawing.Size(57, 13);
            this.sectionid_label.TabIndex = 41;
            this.sectionid_label.Text = "Section ID";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(352, 9);
            this.time_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(73, 29);
            this.time_label.TabIndex = 40;
            this.time_label.Text = "Time";
            // 
            // section_label
            // 
            this.section_label.AutoSize = true;
            this.section_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_label.Location = new System.Drawing.Point(19, 9);
            this.section_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.section_label.Name = "section_label";
            this.section_label.Size = new System.Drawing.Size(101, 29);
            this.section_label.TabIndex = 39;
            this.section_label.Text = "Section";
            // 
            // end_time_input
            // 
            this.end_time_input.CustomFormat = "";
            this.end_time_input.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end_time_input.Location = new System.Drawing.Point(360, 324);
            this.end_time_input.Margin = new System.Windows.Forms.Padding(2);
            this.end_time_input.Name = "end_time_input";
            this.end_time_input.Size = new System.Drawing.Size(187, 20);
            this.end_time_input.TabIndex = 37;
            // 
            // start_time_input
            // 
            this.start_time_input.CustomFormat = "";
            this.start_time_input.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start_time_input.Location = new System.Drawing.Point(357, 266);
            this.start_time_input.Margin = new System.Windows.Forms.Padding(2);
            this.start_time_input.Name = "start_time_input";
            this.start_time_input.Size = new System.Drawing.Size(190, 20);
            this.start_time_input.TabIndex = 36;
            // 
            // days_checklist
            // 
            this.days_checklist.FormattingEnabled = true;
            this.days_checklist.Items.AddRange(new object[] {
            "MWF",
            "TR",
            "MW",
            "WF",
            "M",
            "T",
            "W",
            "R",
            "F"});
            this.days_checklist.Location = new System.Drawing.Point(357, 73);
            this.days_checklist.Margin = new System.Windows.Forms.Padding(2);
            this.days_checklist.Name = "days_checklist";
            this.days_checklist.Size = new System.Drawing.Size(190, 154);
            this.days_checklist.TabIndex = 35;
            // 
            // capacity_input
            // 
            this.capacity_input.Location = new System.Drawing.Point(21, 324);
            this.capacity_input.Margin = new System.Windows.Forms.Padding(2);
            this.capacity_input.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.capacity_input.Name = "capacity_input";
            this.capacity_input.Size = new System.Drawing.Size(129, 20);
            this.capacity_input.TabIndex = 34;
            // 
            // classroom_input
            // 
            this.classroom_input.Location = new System.Drawing.Point(21, 266);
            this.classroom_input.Margin = new System.Windows.Forms.Padding(2);
            this.classroom_input.Name = "classroom_input";
            this.classroom_input.Size = new System.Drawing.Size(129, 20);
            this.classroom_input.TabIndex = 33;
            // 
            // year_input
            // 
            this.year_input.Location = new System.Drawing.Point(23, 126);
            this.year_input.Margin = new System.Windows.Forms.Padding(2);
            this.year_input.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.year_input.Name = "year_input";
            this.year_input.Size = new System.Drawing.Size(127, 20);
            this.year_input.TabIndex = 30;
            // 
            // term_input
            // 
            this.term_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.term_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.term_input.FormattingEnabled = true;
            this.term_input.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring",
            "Summer"});
            this.term_input.Location = new System.Drawing.Point(180, 73);
            this.term_input.Margin = new System.Windows.Forms.Padding(2);
            this.term_input.Name = "term_input";
            this.term_input.Size = new System.Drawing.Size(112, 21);
            this.term_input.TabIndex = 29;
            // 
            // sectionid_input
            // 
            this.sectionid_input.Location = new System.Drawing.Point(23, 73);
            this.sectionid_input.Margin = new System.Windows.Forms.Padding(2);
            this.sectionid_input.Name = "sectionid_input";
            this.sectionid_input.Size = new System.Drawing.Size(127, 20);
            this.sectionid_input.TabIndex = 28;
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(203, 417);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(164, 25);
            this.sucess_label.TabIndex = 55;
            this.sucess_label.Text = "Section Added: ";
            // 
            // CreateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.dept_input);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.course_label);
            this.Controls.Add(this.end_time_label);
            this.Controls.Add(this.start_time_label);
            this.Controls.Add(this.days_label);
            this.Controls.Add(this.capacity_label);
            this.Controls.Add(this.classroom_label);
            this.Controls.Add(this.dept_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.term_label);
            this.Controls.Add(this.sectionid_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.section_label);
            this.Controls.Add(this.end_time_input);
            this.Controls.Add(this.start_time_input);
            this.Controls.Add(this.days_checklist);
            this.Controls.Add(this.capacity_input);
            this.Controls.Add(this.classroom_input);
            this.Controls.Add(this.year_input);
            this.Controls.Add(this.term_input);
            this.Controls.Add(this.sectionid_input);
            this.Name = "CreateSection";
            this.Text = "Add Section";
            ((System.ComponentModel.ISupportInitialize)(this.capacity_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dept_input;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.Label end_time_label;
        private System.Windows.Forms.Label start_time_label;
        private System.Windows.Forms.Label days_label;
        private System.Windows.Forms.Label capacity_label;
        private System.Windows.Forms.Label classroom_label;
        private System.Windows.Forms.Label dept_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label term_label;
        private System.Windows.Forms.Label sectionid_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label section_label;
        private System.Windows.Forms.DateTimePicker end_time_input;
        private System.Windows.Forms.DateTimePicker start_time_input;
        private System.Windows.Forms.CheckedListBox days_checklist;
        private System.Windows.Forms.NumericUpDown capacity_input;
        private System.Windows.Forms.TextBox classroom_input;
        private System.Windows.Forms.NumericUpDown year_input;
        private System.Windows.Forms.ComboBox term_input;
        private System.Windows.Forms.TextBox sectionid_input;
        private System.Windows.Forms.Label sucess_label;
    }
}