namespace WindowForm.New
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
            this.student_id = new System.Windows.Forms.Label();
            this.term_dropdown = new System.Windows.Forms.ComboBox();
            this.course_dropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.course_list = new System.Windows.Forms.ListView();
            this.confirm_courselist = new System.Windows.Forms.ListView();
            this.add_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.studentid_input = new System.Windows.Forms.TextBox();
            this.fullname_label = new System.Windows.Forms.Label();
            this.student_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Location = new System.Drawing.Point(34, 45);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(87, 20);
            this.student_id.TabIndex = 0;
            this.student_id.Text = "Student ID";
            // 
            // term_dropdown
            // 
            this.term_dropdown.FormattingEnabled = true;
            this.term_dropdown.Location = new System.Drawing.Point(38, 118);
            this.term_dropdown.Name = "term_dropdown";
            this.term_dropdown.Size = new System.Drawing.Size(200, 28);
            this.term_dropdown.TabIndex = 1;
            // 
            // course_dropdown
            // 
            this.course_dropdown.FormattingEnabled = true;
            this.course_dropdown.Location = new System.Drawing.Point(264, 118);
            this.course_dropdown.Name = "course_dropdown";
            this.course_dropdown.Size = new System.Drawing.Size(176, 28);
            this.course_dropdown.TabIndex = 2;
            this.course_dropdown.SelectedIndexChanged += new System.EventHandler(this.course_dropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Term/Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course List";
            // 
            // course_list
            // 
            this.course_list.HideSelection = false;
            this.course_list.Location = new System.Drawing.Point(38, 192);
            this.course_list.Name = "course_list";
            this.course_list.Size = new System.Drawing.Size(350, 442);
            this.course_list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.course_list.TabIndex = 5;
            this.course_list.UseCompatibleStateImageBehavior = false;
            this.course_list.SelectedIndexChanged += new System.EventHandler(this.course_list_DoubleClick);
            // 
            // confirm_courselist
            // 
            this.confirm_courselist.HideSelection = false;
            this.confirm_courselist.Location = new System.Drawing.Point(512, 192);
            this.confirm_courselist.Name = "confirm_courselist";
            this.confirm_courselist.Size = new System.Drawing.Size(350, 442);
            this.confirm_courselist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.confirm_courselist.TabIndex = 6;
            this.confirm_courselist.UseCompatibleStateImageBehavior = false;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(418, 372);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 32);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "->";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(418, 432);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 32);
            this.remove_button.TabIndex = 8;
            this.remove_button.Text = "<-";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(512, 643);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(134, 32);
            this.submit_button.TabIndex = 9;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // studentid_input
            // 
            this.studentid_input.Location = new System.Drawing.Point(141, 38);
            this.studentid_input.Name = "studentid_input";
            this.studentid_input.Size = new System.Drawing.Size(188, 26);
            this.studentid_input.TabIndex = 10;
            this.studentid_input.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // fullname_label
            // 
            this.fullname_label.AutoSize = true;
            this.fullname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_label.Location = new System.Drawing.Point(412, 38);
            this.fullname_label.Name = "fullname_label";
            this.fullname_label.Size = new System.Drawing.Size(107, 29);
            this.fullname_label.TabIndex = 11;
            this.fullname_label.Text = "Student: ";
            // 
            // student_label
            // 
            this.student_label.AutoSize = true;
            this.student_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_label.Location = new System.Drawing.Point(530, 37);
            this.student_label.Name = "student_label";
            this.student_label.Size = new System.Drawing.Size(0, 29);
            this.student_label.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 765);
            this.Controls.Add(this.student_label);
            this.Controls.Add(this.fullname_label);
            this.Controls.Add(this.studentid_input);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.confirm_courselist);
            this.Controls.Add(this.course_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.course_dropdown);
            this.Controls.Add(this.term_dropdown);
            this.Controls.Add(this.student_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.ComboBox term_dropdown;
        private System.Windows.Forms.ComboBox course_dropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView course_list;
        private System.Windows.Forms.ListView confirm_courselist;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.TextBox studentid_input;
        private System.Windows.Forms.Label fullname_label;
        private System.Windows.Forms.Label student_label;
    }
}