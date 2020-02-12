namespace WindowForm.Modify
{
    partial class ModifyCourse
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
            this.modify_course_label = new System.Windows.Forms.Label();
            this.sucess_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dept_label = new System.Windows.Forms.Label();
            this.dept_input = new System.Windows.Forms.ComboBox();
            this.number_label = new System.Windows.Forms.Label();
            this.number_input = new System.Windows.Forms.NumericUpDown();
            this.subject_label = new System.Windows.Forms.Label();
            this.subject_input = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.title_input = new System.Windows.Forms.TextBox();
            this.course_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.year_input = new System.Windows.Forms.NumericUpDown();
            this.credits_label = new System.Windows.Forms.Label();
            this.credits_input = new System.Windows.Forms.NumericUpDown();
            this.description_label = new System.Windows.Forms.Label();
            this.description_input = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).BeginInit();
            this.SuspendLayout();
            // 
            // modify_course_label
            // 
            this.modify_course_label.AutoSize = true;
            this.modify_course_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_course_label.Location = new System.Drawing.Point(12, 9);
            this.modify_course_label.Name = "modify_course_label";
            this.modify_course_label.Size = new System.Drawing.Size(203, 33);
            this.modify_course_label.TabIndex = 115;
            this.modify_course_label.Text = "Modify Course";
            // 
            // sucess_label
            // 
            this.sucess_label.AutoSize = true;
            this.sucess_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucess_label.Location = new System.Drawing.Point(11, 395);
            this.sucess_label.Name = "sucess_label";
            this.sucess_label.Size = new System.Drawing.Size(180, 25);
            this.sucess_label.TabIndex = 120;
            this.sucess_label.Text = "Course Updated: ";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(21, 205);
            this.search_button.Margin = new System.Windows.Forms.Padding(2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(92, 27);
            this.search_button.TabIndex = 117;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_label.Location = new System.Drawing.Point(14, 60);
            this.search_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(66, 20);
            this.search_label.TabIndex = 116;
            this.search_label.Text = "Search";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(222, 461);
            this.splitter1.TabIndex = 121;
            this.splitter1.TabStop = false;
            // 
            // dept_label
            // 
            this.dept_label.AutoSize = true;
            this.dept_label.Location = new System.Drawing.Point(18, 92);
            this.dept_label.Name = "dept_label";
            this.dept_label.Size = new System.Drawing.Size(62, 13);
            this.dept_label.TabIndex = 123;
            this.dept_label.Text = "Department";
            // 
            // dept_input
            // 
            this.dept_input.FormattingEnabled = true;
            this.dept_input.Location = new System.Drawing.Point(21, 108);
            this.dept_input.Name = "dept_input";
            this.dept_input.Size = new System.Drawing.Size(149, 21);
            this.dept_input.TabIndex = 122;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Location = new System.Drawing.Point(18, 139);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(80, 13);
            this.number_label.TabIndex = 125;
            this.number_label.Text = "Course Number";
            // 
            // number_input
            // 
            this.number_input.Location = new System.Drawing.Point(21, 155);
            this.number_input.Name = "number_input";
            this.number_input.Size = new System.Drawing.Size(149, 20);
            this.number_input.TabIndex = 124;
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(455, 93);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(43, 13);
            this.subject_label.TabIndex = 130;
            this.subject_label.Text = "Subject";
            // 
            // subject_input
            // 
            this.subject_input.Location = new System.Drawing.Point(458, 109);
            this.subject_input.Name = "subject_input";
            this.subject_input.Size = new System.Drawing.Size(143, 20);
            this.subject_input.TabIndex = 129;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(275, 93);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(63, 13);
            this.title_label.TabIndex = 128;
            this.title_label.Text = "Course Title";
            // 
            // title_input
            // 
            this.title_input.Location = new System.Drawing.Point(278, 109);
            this.title_input.Name = "title_input";
            this.title_input.Size = new System.Drawing.Size(159, 20);
            this.title_input.TabIndex = 127;
            // 
            // course_label
            // 
            this.course_label.AutoSize = true;
            this.course_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_label.Location = new System.Drawing.Point(270, 61);
            this.course_label.Name = "course_label";
            this.course_label.Size = new System.Drawing.Size(127, 20);
            this.course_label.TabIndex = 126;
            this.course_label.Text = "Course Details";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(455, 291);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(29, 13);
            this.year_label.TabIndex = 138;
            this.year_label.Text = "Year";
            // 
            // year_input
            // 
            this.year_input.Location = new System.Drawing.Point(458, 307);
            this.year_input.Name = "year_input";
            this.year_input.Size = new System.Drawing.Size(143, 20);
            this.year_input.TabIndex = 137;
            // 
            // credits_label
            // 
            this.credits_label.AutoSize = true;
            this.credits_label.Location = new System.Drawing.Point(279, 291);
            this.credits_label.Name = "credits_label";
            this.credits_label.Size = new System.Drawing.Size(39, 13);
            this.credits_label.TabIndex = 136;
            this.credits_label.Text = "Credits";
            // 
            // credits_input
            // 
            this.credits_input.Location = new System.Drawing.Point(282, 307);
            this.credits_input.Name = "credits_input";
            this.credits_input.Size = new System.Drawing.Size(155, 20);
            this.credits_input.TabIndex = 135;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(275, 155);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(96, 13);
            this.description_label.TabIndex = 132;
            this.description_label.Text = "Course Description";
            // 
            // description_input
            // 
            this.description_input.Location = new System.Drawing.Point(278, 171);
            this.description_input.Multiline = true;
            this.description_input.Name = "description_input";
            this.description_input.Size = new System.Drawing.Size(323, 95);
            this.description_input.TabIndex = 131;
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Location = new System.Drawing.Point(518, 398);
            this.delete_button.Margin = new System.Windows.Forms.Padding(2);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(83, 24);
            this.delete_button.TabIndex = 140;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(418, 398);
            this.update_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(80, 24);
            this.update_button.TabIndex = 139;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // ModifyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 461);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.year_input);
            this.Controls.Add(this.credits_label);
            this.Controls.Add(this.credits_input);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.description_input);
            this.Controls.Add(this.subject_label);
            this.Controls.Add(this.subject_input);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.title_input);
            this.Controls.Add(this.course_label);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.number_input);
            this.Controls.Add(this.dept_label);
            this.Controls.Add(this.dept_input);
            this.Controls.Add(this.sucess_label);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.modify_course_label);
            this.Controls.Add(this.splitter1);
            this.Name = "ModifyCourse";
            this.Text = "ModifyCourse";
            ((System.ComponentModel.ISupportInitialize)(this.number_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modify_course_label;
        private System.Windows.Forms.Label sucess_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label dept_label;
        private System.Windows.Forms.ComboBox dept_input;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.NumericUpDown number_input;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox subject_input;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox title_input;
        private System.Windows.Forms.Label course_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.NumericUpDown year_input;
        private System.Windows.Forms.Label credits_label;
        private System.Windows.Forms.NumericUpDown credits_input;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.TextBox description_input;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
    }
}